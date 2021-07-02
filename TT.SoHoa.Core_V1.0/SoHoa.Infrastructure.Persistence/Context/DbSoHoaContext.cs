using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SoHoa.Application.AuthorizeServices.Interfaces;
using SoHoa.Domain.Common;
using SoHoa.Domain.Models;
using SoHoa.Infrastructure.Interfaces;
using SoHoa.Infrastructure.Persistence.Context.Exceptions;
using SoHoa.Infrastructure.Persistence.Context.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;

namespace SoHoa.Infrastructure.Persistence.Context
{
    public class DbSoHoaContext : DbContext, IDbSoHoaContext
    {

		private readonly ICurrentUserService _currentUserService;
		private readonly IDateTime _dateTime;
		private IDbContextTransaction _transaction = null;
		public DbSoHoaContext(DbContextOptions options) : base(options)
        {

        }
		public DbSoHoaContext(DbContextOptions<DbSoHoaContext> options, ICurrentUserService currentUserService, IDateTime dateTime) : base(options)
        {
			_currentUserService = currentUserService;
			_dateTime = dateTime;
        }
        public DbSet<NguoiDung> NguoiDung { get; set; }

		public DbSet<T> DbSet<T>() where T : Entity => this.Set<T>();

		// ITransaction implementations
		public bool IsInTransaction => _transaction != null;

		public void BeginTransaction() => _transaction = this.Database.BeginTransaction();

		public async Task BeginTransactionAsync(CancellationToken cancellationToken = default) => _transaction = await this.Database.BeginTransactionAsync();

		public void EndTransaction()
		{
			_ = _transaction ?? throw new DbSoHoaException("No transaction found.");
			_transaction.Commit();
		}

		public Task EndTransactionAsync(CancellationToken cancellationToken = default)
		{
			_ = _transaction ?? throw new DbSoHoaException("No transaction found.");
			return _transaction.CommitAsync();
		}

		// Override methods
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
		
    }
}
