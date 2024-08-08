using CMS.Domain;
using CMS.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure
{
    public abstract class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext) => _dbContext = dbContext;

        public virtual void Dispose() => _dbContext?.Dispose();
        public virtual async ValueTask DisposeAsync() => await _dbContext.DisposeAsync();
        public void Save() => _dbContext?.SaveChanges();
        public virtual async Task SaveAsync() => await _dbContext?.SaveChangesAsync();
    }
}
