using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SoHoa.Domain.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        public BaseSpecification(Expression<Func<T, bool>> criteria = null, int skip = 0, int take = 10)
        {

            if (criteria != null)
            {
                Criteria = criteria;
            }
            ApplyPaging(skip, take);
        }
        public BaseSpecification(Expression<Func<T, bool>> criteria = null, Expression<Func<T, object>> orderBy = null, string typeOderby = "")
        {
            if (criteria != null)
            {
                Criteria = criteria;
            }
            if (orderBy != null)
                if (typeOderby == "desc")
                {
                    ApplyOrderByDescending(orderBy);
                }
                else
                {
                    ApplyOrderBy(orderBy);
                }
        }
        public BaseSpecification(Expression<Func<T, bool>> criteria = null, Expression<Func<T, object>> orderBy = null, string typeOderby = "", int skip = 0, int take = 10)
        {
            if (criteria != null)
            {
                Criteria = criteria;
            }
            if (orderBy != null)
                if (typeOderby == "desc")
                {
                    ApplyOrderByDescending(orderBy);
                }
                else
                {
                    ApplyOrderBy(orderBy);
                }

            ApplyPaging(skip, take);

        }
        public Expression<Func<T, bool>> Criteria { get; }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
        public List<string> IncludeStrings { get; } = new List<string>();
        public Expression<Func<T, object>> OrderBy { get; private set; }
        public Expression<Func<T, object>> OrderByDescending { get; private set; }
        public Expression<Func<T, object>> GroupBy { get; private set; }

        public int Take { get; private set; }
        public int Skip { get; private set; }
        public bool IsPagingEnabled { get; private set; } = false;

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
        protected void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
        protected void ApplyOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        protected void ApplyOrderByDescending(Expression<Func<T, object>> orderByDescendingExpression)
        {
            OrderByDescending = orderByDescendingExpression;
        }

        //Not used anywhere at the moment, but someone requested an example of setting this up.
        protected void ApplyGroupBy(Expression<Func<T, object>> groupByExpression)
        {
            GroupBy = groupByExpression;
        }
    }
}
