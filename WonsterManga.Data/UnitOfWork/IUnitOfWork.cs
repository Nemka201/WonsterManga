using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Noticias.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.Entities;

namespace WonsterManga.Domain.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<Chapter> ChapterRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<ChapterPage> ChapterPageRepository { get; }
        IGenericRepository<Country> CountryRepository { get; }
        IGenericRepository<Role> RoleRepository { get; }
        IGenericRepository<Serie> SerieRepository { get; }
        IGenericRepository<SerieState> SerieStateRepository { get; }
        IGenericRepository<Volume> VolumeRepository { get; }

        void Save();
        Task<Task> SaveAsync();

    }
}
