using SoHoa.Domain.Common;
using SoHoa.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoHoa.Domain.IRepositories
{
    public interface IEFRepository<T> where T : Entity
    {
		Task<IEnumerable<dynamic>> GetAllAsync();
		Task<IReadOnlyList<T>> GetAllAsync(ISpecification<T> spec);
		Task<IEnumerable<dynamic>> GetAllAsync(string where = null, string orderBy = null, int top = 0, params object[] parms);
		Task<IEnumerable<dynamic>> GetPageAsync(string where = null, string orderBy = null, int page = 1, int pageSize = 10, params object[] parms);
		Task<T> GetByIdAsync(Guid id);

		Task<T> AddAsync(T entity);

		Task UpdateAsync(T entity);
		Task UpdateAsync(Guid id, T entity);

		Task DeleteAsync(T entity);
		Task DeleteAsync(Guid id);

		Task DeleteByFlagAsync(T entity);
		Task DeleteByFlagAsync(Guid id);

		Task<int> CountAsync(ISpecification<T> spec);
		Task<int> CountAsync(string where = null, params object[] parms);

		Task ExcuteAsync(string sqlquery, params Object[] parms);

		Task<IEnumerable<dynamic>> QueryAsync(string sqlquery, params Object[] parms);
	}
}
