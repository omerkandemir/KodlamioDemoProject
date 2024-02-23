using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Core
{
    public static class EfQuerable
    {
        public static IQueryable<T> GetIncludes<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] include)
            where T : class
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));
            return include.Aggregate(query, (current, include) => current.Include(include));
        }
    }
}
