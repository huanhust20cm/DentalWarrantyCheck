using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBaseRepository<TEntity>
    {
        public Task<List<TEntity>> GetAll();
        public Task<TEntity> GetById(Guid Id);
        public Task<TEntity> AddEntity(TEntity entity, bool dispose = false);
        public Task<bool> UpdateEntity(TEntity entity, bool dispose = false);
        public Task<bool> DeleteEntity(TEntity entity, bool dispose = false);
        public Task<TEntity> GetEntityByCondition(Expression<Func<TEntity, bool>> condition);
        public Task<List<TEntity>> GetDatasByCondition(Expression<Func<TEntity, bool>> condition);
    }
}
