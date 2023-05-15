using System.Linq.Expressions;

namespace Repository.Genric
{
    public interface IGenericRepo<T> where T : class
    {
        /// <summary>
        /// Saves all changes made this context to database.
        /// </summary>
        void Save();

        /// <summary>
        /// Saves all changes made this context to database.
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

        /// <summary>
        /// Begins tracking the given entity, and any other reachable entities that are not
        /// already being tracked, in the Microsoft.EntityFrameworkCore.EntityState.Addedstate such that
        /// they will be inserted into the database when Microsoft.EntityFrameworkCore.DbContext.SaveChangesis called. 
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Begins tracking the given entity, and any other reachable entities that are not
        /// already being tracked, in the Microsoft.EntityFrameworkCore.EntityState.Addedstate such that
        /// they will be inserted into the database when Microsoft.EntityFrameworkCore.DbContext.SaveChangesis called.
        /// This method is async only to allow special value generators, such as the one
        /// used by 'Microsoft.EntityFrameworkCore.Metadata.SqlServerValueGenerationStrategy.SequenceHiLo',
        /// to access the database asynchronously. For all other cases the non async method
        /// hould be used.
        /// </summary>
        Task AddAsync(T entity);

        /// <summary>
        /// Adds an entity in database and begins tracking this entity
        /// </summary>
        /// <param name="entity"></param>
        void AddWithSave(T entity);

        /// <summary>
        /// Adds an entity in database and begins tracking this entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task AddWithSaveAsync(T entity);

        /// <summary>
        /// Sets the entity state as modified
        /// </summary>
        /// <param name="entity"></param>
        Task UpdateAsync(T entity);

        /// <summary>
        /// Set the entity state as modified and saves in database as well
        /// </summary>
        /// <param name="entity"></param>
        Task UpdateWithSaveAsync(T entity);

        /// <summary>
        /// Begins tracking the given entity in the Microsoft.EntityFrameworkCore.EntityState.Deleted
        /// state such that it will be removed from the database when Microsoft.EntityFrameworkCore.DbContext.SaveChanges
        /// is called.
        /// </summary>
        /// <param name="entity"></param>
        Task DeleteAsync(T entity);

        /// <summary>
        /// Removes the entity record from database after setting its state as deleted
        /// </summary>
        /// <param name="entity"></param>
        Task DeleteWithSaveAsync(T entity);

        /// <summary>
        /// Begins tracking the given entities in the <seealso cref="Microsoft.EntityFrameworkCore.EntityState.Deleted"/> state.
        /// </summary>
        /// <param name="entities"></param>
        Task DeleteRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// Begins tracking the given entities in the <seealso cref="Microsoft.EntityFrameworkCore.EntityState.Deleted"/> state
        /// and called <seealso cref="DbContext.DucisDbContext.SaveChangesAsync(bool, CancellationToken)"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns><seealso cref="Task"/></returns>
        Task DeleteRangeWithSaveAsync(IEnumerable<T> entities);

        /// <summary>
        /// Get all records from the source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<IList<T>> GetAllRecords<T>() where T : class;

        /// <summary>
        /// Gets entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns><seealso cref="T"/> entity</returns>
        Task<T> GetByIdAsync(int id);

        /// <summary>
        /// Gets the first entity record from database based on given predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>An entity record filtered by predicate</returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets the query from database based on given predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>A query based on given predicate</returns>
        IQueryable<T> GetAsQueryable(Expression<Func<T, bool>> predicate = null);

        /// <summary>
        /// Gets the first entity record from database based on given predicate and
        /// included related records of navigational properties
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns>An entity record included related records of navigational properties
        /// filtered by predicate</returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets the query from database based on given predicate and
        /// included related records of navigational properties
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns>A query included related records of navigational properties and
        /// based on given predicate</returns>
        IQueryable<T> GetAsQueryable(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets the first entity record from database based on given predicate and
        /// included related records of navigational properties of inner levels as well
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="thenIncludes"></param>
        /// <param name="includes"></param>
        /// <returns>An entity record included related records of navigational properties of inner levels as well
        /// filtered by predicate</returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, List<string> thenIncludes, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets the records from database based on given predicate included records from related navigational properties
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns>A query that contains records of related entities as well</returns>
        IQueryable<T> List(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets the records from database included related navigational properties
        /// </summary>
        /// <param name="includes"></param>
        /// <returns>A query that contains records of related entities as well</returns>
        IQueryable<T> List(params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets the records from database based on given predicate and
        /// included related records of navigational properties of inner levels as well
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="thenIncludes"></param>
        /// <param name="includes"></param>
        /// <returns>A query included related records of navigational properties of inner levels as well and
        /// based on given predicate</returns>
        IQueryable<T> List(Expression<Func<T, bool>> predicate = null, List<string> thenIncludes = null, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets records from database included related navigational properties of inner levels as well
        /// </summary>
        /// <param name="thenIncludes"></param>
        /// <param name="includes"></param>
        /// <returns>A query included related records of navigational properties of inner levels as well</returns>
        IQueryable<T> List(List<string> thenIncludes, params Expression<Func<T, object>>[] includes);

    }
}