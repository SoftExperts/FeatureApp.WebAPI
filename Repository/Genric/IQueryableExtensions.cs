using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository.Genric
{
    public static class IQueryableExtensions
    {
        /// <summary>
        /// Includes related data of given navigational properties if available.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="includes"></param>
        /// <returns>A new query with related records included from navigational properties.</returns>
        public static IQueryable<T> Includes<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes) where T : class
        {
            if (includes is null || !includes.Any())
                return query;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query;
        }

        /// <summary>
        /// Includes related data of given navigational properties of second level if available.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="thenIncludes"></param>
        /// <returns>A new query with related records included from navigational properties of second level.</returns>
        public static IQueryable<T> ThenIncludes<T>(this IQueryable<T> query, List<string> thenIncludes = null) where T : class
        {
            if (thenIncludes is null || !thenIncludes.Any())
                return query;

            foreach (var thenInclude in thenIncludes)
            {
                query = query.Include(thenInclude);
            }

            return query;
        }

        /// <summary>
        /// Filters a sequence of records based on given predicate if predicate was not null.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="query"></param>
        /// <param name="predicate"></param>
        /// <returns>An <see cref="IQueryable{T}"/> that contains elements from the input sequence that 
        /// satisfy the condition specified by <paramref name="predicate"/>.</returns>
        public static IQueryable<T> Predicate<T>(this IQueryable<T> query, Expression<Func<T, bool>> predicate)
        {
            return predicate is null ? query : query.Where(predicate);
        }

        public static IQueryable<TEntity> OrderByCustom<TEntity>(this IQueryable<TEntity> items, string sortBy, string sortOrder)
        {
            var type = typeof(TEntity);
            var expression2 = Expression.Parameter(type, "t");
            var property = type.GetProperty(sortBy);
            var expression1 = Expression.MakeMemberAccess(expression2, property);
            var lambda = Expression.Lambda(expression1, expression2);
            var result = Expression.Call(
                typeof(Queryable),
                sortOrder == "desc" ? "OrderByDescending" : "OrderBy",
                new Type[] { type, property.PropertyType },
                items.Expression,
                Expression.Quote(lambda));

            return items.Provider.CreateQuery<TEntity>(result);
        }
    }
}