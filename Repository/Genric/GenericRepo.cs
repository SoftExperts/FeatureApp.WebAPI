using Database;
using Entities.QueryFilters;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository.Genric
{
    public class GenericRopo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext _dbContext;

        public GenericRopo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region public methods

        /// <summary>
        /// Saves all changes made this context to database.
        /// </summary>
        public void Save()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Saves all changes made this context to database. 
        /// </summary>
        public async Task SaveAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Begins tracking the given entity, and any other reachable entities that are not
        /// already being tracked, in the Microsoft.EntityFrameworkCore.EntityState.Addedstate such that
        /// they will be inserted into the database when Microsoft.EntityFrameworkCore.DbContext.SaveChangesis called. 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            try
            {
                Entity().Add(entity);
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Begins tracking the given entity, and any other reachable entities that are not
        /// already being tracked, in the Microsoft.EntityFrameworkCore.EntityState.Addedstate such that
        /// they will be inserted into the database when Microsoft.EntityFrameworkCore.DbContext.SaveChangesis called.
        /// This method is async only to allow special value generators, such as the one
        /// used by 'Microsoft.EntityFrameworkCore.Metadata.SqlServerValueGenerationStrategy.SequenceHiLo',
        /// to access the database asynchronously. For all other cases the non async method
        /// hould be used.
        /// </summary>
        /// <param name="entity"></param>
        public async Task AddAsync(T entity)
        {
            try
            {
                await Entity().AddAsync(entity);
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Adds an entity in database and begins tracking this entity
        /// </summary>
        /// <param name="entity"></param>
        public void AddWithSave(T entity)
        {
            try
            {
                Add(entity);
                Save();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Adds an entity in database and begins tracking this entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddWithSaveAsync(T entity)
        {
            try
            {
                await AddAsync(entity);
                await SaveAsync();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Add Range With Save Async
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task AddRangeWithSaveAsync(IEnumerable<T> entities)
        {
            try
            {
                await Task.Run(() => Entity().AddRangeAsync(entities));
                await Task.CompletedTask;
                await SaveAsync();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Sets the entity state as modified
        /// </summary>
        /// <param name="entity"></param>
        public async Task UpdateAsync(T entity)
        {
            try
            {
                await Task.Run(() => _dbContext.Entry(entity).State = EntityState.Modified);
                await Task.CompletedTask;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Set the entity state as modified and saves in database as well
        /// </summary>
        /// <param name="entity"></param>
        public async Task UpdateWithSaveAsync(T entity)
        {
            try
            {
                await UpdateAsync(entity);
                await SaveAsync();
            }
            catch (Exception) { throw; }
        }

        public async Task UpdateRangeWithSaveAsync(IEnumerable<T> entities)
        {
            try
            {
                await Task.Run(() => Entity().UpdateRange(entities));
                await Task.CompletedTask;
                await SaveAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Begins tracking the given entity in the Microsoft.EntityFrameworkCore.EntityState.Deleted
        /// state such that it will be removed from the database when Microsoft.EntityFrameworkCore.DbContext.SaveChanges
        /// is called.
        /// </summary>
        /// <param name="entity"></param>
        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Entity().Remove(entity));
            await Task.CompletedTask;
        }

        /// <summary>
        /// Removes the entity record from database after setting its state as deleted
        /// </summary>
        /// <param name="entity"></param>
        public async Task DeleteWithSaveAsync(T entity)
        {
            try
            {
                await DeleteAsync(entity);
                await SaveAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete Entities
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await Task.Run(() => Entity().RemoveRange(entities));
                await Task.CompletedTask;
            }
            catch (Exception)
            {
                throw ;
            }
        }

        /// <summary>
        /// Delete Entities with Save
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task DeleteRangeWithSaveAsync(IEnumerable<T> entities)
        {
            try
            {
                await DeleteRangeAsync(entities);
                await SaveAsync();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Get record by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Entity().FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }
        
        /// <summary>
        /// Get record by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(Guid id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Entity().FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        /// <summary>
        /// Gets the first entity record from database based on given predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>An entity record filtered by predicate</returns>
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate) => await Entity().FirstOrDefaultAsync(predicate);

        /// <summary>
        /// Gets the query from database based on given predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>A query based on given predicate</returns>
        public IQueryable<T> GetAsQueryable(Expression<Func<T, bool>>? predicate = null)
        {
            return Entity().Predicate(predicate);
        }

        /// <summary>
        /// Gets the first entity record from database based on given predicate and included related records of navigational properties
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns>An entity record included related records of navigational properties filtered by predicate</returns>
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return await GetAsQueryable(predicate, includes).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Gets the query from database based on given predicate and
        /// included related records of navigational properties
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns>A query included related records of navigational properties and
        /// based on given predicate</returns>
        public IQueryable<T> GetAsQueryable(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return Query().Includes(includes).Predicate(predicate);
        }

        /// <summary>
        /// Gets the first entity record from database based on given predicate and
        /// included related records of navigational properties of inner levels as well
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="thenIncludes"></param>
        /// <param name="includes"></param>
        /// <returns>An entity record included related records of navigational properties of inner levels as well
        /// filtered by predicate</returns>
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, List<string> thenIncludes, params Expression<Func<T, object>>[] includes)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Query().Includes(includes).ThenIncludes(thenIncludes).Predicate(predicate).FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        }

        /// <summary>
        /// Gets the records from database based on given predicate included records from related navigational properties
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns>A query that contains records of related entities as well</returns>
        public IQueryable<T> List(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes)
        {
            return Query().Includes(includes).Predicate(predicate);
        }

        /// <summary>
        /// Gets the records from database included related navigational properties
        /// </summary>
        /// <param name="includes"></param>
        /// <returns>A query that contains records of related entities as well</returns>
        public IQueryable<T> List(params Expression<Func<T, object>>[] includes)
        {
            return Query().Includes(includes);
        }

        /// <summary>
        /// Get all records from the source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<IList<T>> GetAllRecords<T>() where T : class
        {
            return _dbContext.Set<T>().ToList();
        }
        
        
        /// <summary>
        /// Get all records from the source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<IQueryable<T>> GetAllRecordsAsQueryable<T>() where T : class
        {
            return _dbContext.Set<T>().AsQueryable<T>();
        }

        /// <summary>
        /// Gets the records from database based on given predicate and
        /// included related records of navigational properties of inner levels as well
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="thenIncludes"></param>
        /// <param name="includes"></param>
        /// <returns>A query included related records of navigational properties of inner levels as well and
        /// based on given predicate</returns>
        public IQueryable<T> List(Expression<Func<T, bool>> predicate, List<string> thenIncludes, params Expression<Func<T, object>>[] includes)
        {
            return Query().Includes(includes).ThenIncludes(thenIncludes).Predicate(predicate);
        }

        /// <summary>
        /// Gets records from database included related navigational properties of inner levels as well
        /// </summary>
        /// <param name="thenIncludes"></param>
        /// <param name="includes"></param>
        /// <returns>A query included related records of navigational properties of inner levels as well</returns>
        public IQueryable<T> List(List<string> thenIncludes, params Expression<Func<T, object>>[] includes)
        {
            return Query().Includes(includes).ThenIncludes(thenIncludes);
        }
        #endregion

        #region private methods

        /// <summary>
        /// Creates a DbSet<T> and converts it to a generic IQueryable<T>
        /// </summary>
        /// <returns>An IQueryable<T> that represents the input sequence</returns>
        private IQueryable<T> Query()
        {
            return Entity().AsQueryable<T>();
        }

        /// <summary>
        /// Creates a DbSet<T> that can be used to query and save instances of T
        /// </summary>
        /// <returns>A set for the given entity type</returns>
        private DbSet<T> Entity()
        {
            return _dbContext.Set<T>();
        }
        #endregion
    }
}