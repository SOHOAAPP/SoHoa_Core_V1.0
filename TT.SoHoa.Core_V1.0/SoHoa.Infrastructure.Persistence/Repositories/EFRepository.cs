using Microsoft.EntityFrameworkCore;
using SoHoa.Application.AuthorizeServices.Interfaces;
using SoHoa.Domain.Common;
using SoHoa.Domain.IRepositories;
using SoHoa.Domain.Specifications;
using SoHoa.Infrastructure.Interfaces;
using SoHoa.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoHoa.Infrastructure.Persistence.Repositories
{
    public class EFRepository<T> : IEFRepository<T> where T : Entity
    {

        protected readonly DbSoHoaContext _context;
        protected readonly DbSet<T> _dbSet;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public EFRepository(DbSoHoaContext context, ICurrentUserService currentUserService,IDateTime dateTime)
        {
            _context = context;
            _dbSet = _context.DbSet<T>();
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(string where = null, params object[] parms)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByFlagAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByFlagAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task ExcuteAsync(string sqlquery, params object[] parms)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<dynamic>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<dynamic>> GetAllAsync(string where = null, string orderBy = null, int top = 0, params object[] parms)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<dynamic>> GetPageAsync(string where = null, string orderBy = null, int page = 1, int pageSize = 10, params object[] parms)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<dynamic>> QueryAsync(string sqlquery, params object[] parms)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
