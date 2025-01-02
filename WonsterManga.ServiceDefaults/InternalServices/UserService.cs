using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.DTOs;
using WonsterManga.Domain.UnitOfWork;
using WonsterManga.Domain.Utilities;

namespace WonsterManga.ServiceDefaults.InternalServices
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AuthJWT _authService;
        public UserService(IUnitOfWork unitOfWork, AuthJWT authService)
        {
            _unitOfWork = unitOfWork;
            _authService = authService;
        }

        public async Task<User> AddUser(User user)
        {
            // Password encrypt SHA256
            user.Password = SHA256Encrypter.Convert(user.Password);
            user.Token = _authService.BuildToken(user);
            _unitOfWork.UserRepository.Add(user);
            // Create JWT
            await _unitOfWork.SaveAsync();
            return user;
        }

        public async Task<Result<User>> DeleteUser(int id)
        {
            var user = await GetUser(id);

            if (user == null)
            {
                return Result<User>.Failure("User not found.");
            }

            await _unitOfWork.UserRepository.DeleteAsync(user);
            await _unitOfWork.SaveAsync();

            return Result<User>.Success(user);
        }

        public async Task<User> GetUser(int id)
        {
            return await _unitOfWork.UserRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _unitOfWork.UserRepository.GetAllAsync();
        }

        public async Task<User> Login(LoginDTO loginDTO)
        {
            Expression<Func<User, bool>> predicate = u => u.Username == loginDTO.Username;
            await _unitOfWork.UserRepository.FindByAsync(predicate);
        }

        public async Task<Result<User>> UpdateUser(User user)
        {
            if (user == null)
            {
                return Result<User>.Failure("User not found.");
            }
            _unitOfWork.UserRepository.Edit(user);
            await _unitOfWork.SaveAsync();
            return Result<User>.Success(user);

        }
    }
}
