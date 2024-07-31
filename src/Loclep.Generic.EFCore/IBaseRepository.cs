namespace Loclep.Generic.EFCore;

public interface IBaseRepository<T, TId> 
  where T : class
  where TId : struct
{
  /// <summary>
  /// Get entity by id
  /// </summary>
  Task<T> GetById(TId id);

  /// <summary>
  /// Get all entities
  /// </summary>
  Task<IEnumerable<T>> GetAll();

  /// <summary>
  /// Insert entity
  /// </summary>
  /// <param name="entity">Entity</param>
  /// <returns>The inserted entity</returns>
  Task<T> Create(T entity);

  /// <summary>
  /// Update entity
  /// </summary>
  /// <param name="entity">Entity</param>
  /// <returns>The updated entity</returns>
  Task<T> Update(T entity);
  
  /// <summary>
  /// Delete entity
  /// </summary>
  /// <param name="id">Entity Id</param>
  /// <returns></returns>
  Task Delete(TId id);
}
