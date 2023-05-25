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

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="predicate"></param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains elements from the input 
        /// sequence that satisfy the condition.</returns>
        public static IEnumerable<T> Predicate<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return predicate is null ? source : source.Where(predicate);
        }

        /// <summary>
        /// Gets the total number of records from database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="predicate"></param>
        /// <returns>Total Records in database</returns>
        public static async Task<int> TotalCountAsync<T>(this IQueryable<T> query, Expression<Func<T, bool>> predicate)
        {
            return predicate is null ? await query.CountAsync() : await query.CountAsync(predicate);
        }

        /// <summary>
        /// Gets the ids of this entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="select"></param>
        /// <returns>List of ids</returns>
        public static List<long> GetIds<T>(this IQueryable<T> query, Expression<Func<T, long>> select)
        {
            return query.Select(select).ToList();
        }
    }
}