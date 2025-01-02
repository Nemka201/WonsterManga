using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Noticias.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajeros.Data.Context;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.Entities;

namespace WonsterManga.Domain.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WonsterContext _context;
        private bool _disposed = false;
        private IGenericRepository<Category> categoryRepository;
        private IGenericRepository<Chapter> chapterRepository;
        private IGenericRepository<User> userRepository;
        private IGenericRepository<ChapterPage> chapterPageRepository;
        private IGenericRepository<Country> countryRepository;
        private IGenericRepository<Role> roleRepository;
        private IGenericRepository<Serie> serieRepository;
        private IGenericRepository<SerieState> serieStateRepository;
        private IGenericRepository<Volume> volumeRepository;

        public UnitOfWork()
        {
            _context = new WonsterContext();
        }

        public IGenericRepository<Category> CategoryRepository => categoryRepository ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Chapter> ChapterRepository => chapterRepository ??= new GenericRepository<Chapter>(_context);
        public IGenericRepository<User> UserRepository => userRepository ??= new GenericRepository<User>(_context);
        public IGenericRepository<ChapterPage> ChapterPageRepository => chapterPageRepository ??= new GenericRepository<ChapterPage>(_context);
        public IGenericRepository<Country> CountryRepository => countryRepository ??= new GenericRepository<Country>(_context);
        public IGenericRepository<Role> RoleRepository => roleRepository ??= new GenericRepository<Role>(_context);
        public IGenericRepository<SerieState> SerieStateRepository => serieStateRepository ??= new GenericRepository<SerieState>(_context);
        public IGenericRepository<Volume> VolumeRepository => volumeRepository ??= new GenericRepository<Volume>(_context);
        public IGenericRepository<Serie> SerieRepository => serieRepository ??= new GenericRepository<Serie>(_context);


        public void Save()
        {
            _context.SaveChanges();
        }
        public async Task<Task> SaveAsync()
        {
            await _context.SaveChangesAsync();
            return Task.CompletedTask;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
