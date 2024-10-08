

using Core.Constants;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Interface;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Repository.Behaviours
{
    public partial class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private Func<BaseDbContext> _func;
        private readonly IConnectionMultiplexer _redisCache;
        protected BaseDbContext context
        {
            get
            {
                return _func.Invoke();
            }
        }

        public BaseRepository(Func<BaseDbContext> func, IConnectionMultiplexer redisCache)
        {
            _func = func;
            this._redisCache = redisCache;
        }

        public async Task<TEntity> AddEntity(TEntity entity, bool dispose = false)
        {
            await AddEntityCommon(entity, dispose);
            return entity;
        }
        public async Task<TOtherEntity> AddEntityCommon<TOtherEntity>(TOtherEntity entity, bool dispose = false) where TOtherEntity : BaseEntity
        {
            var methodcontext = context;
            var db = _redisCache.GetDatabase();
            var loginId = await db.StringGetAsync(CommonConstants.COOKIE_KEY_AUTH);
            var loginName = await db.StringGetAsync(CommonConstants.COOKIE_KEY_GUID);
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }
            if(loginId.HasValue)
            {
                entity.CreatedBy = Guid.Parse(loginId.ToString());
            }
            if (loginName.HasValue)
            {
                entity.CreatedByLookupName = loginName;
            }
            entity.CreateDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;
            await methodcontext.AddAsync(entity);
            await methodcontext.SaveChangesAsync();
            if(dispose)
            {
                methodcontext.Dispose();
            }
            return entity;
        }
        public async Task<bool> DeleteEntity(TEntity entity, bool dispose = false)
        {
            var methodcontext = context;
            if (entity.Id == Guid.Empty) return await Task.FromResult(false);
            var realEntity = await methodcontext.FindAsync<TEntity>(entity.Id);
            if (realEntity == null) return false;
            methodcontext.Remove<TEntity>(realEntity);
            var result = await methodcontext.SaveChangesAsync() != -1;
            if (dispose)
            {
                methodcontext.Dispose();
            }
            return result;
        }

        public void Dispose()
        {
            Dispose(false);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            var methodcontext = context;
            return await methodcontext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(Guid Id)
        {
            var methodcontext = context;
            return await methodcontext.FindAsync<TEntity>(Id);
        }
        public async Task<TEntity> GetOriginEntity<TOtherEntity>(TOtherEntity entity) where TOtherEntity : BaseEntity
        {
            var methodcontext = context;
            return  await methodcontext.FindAsync<TEntity>(entity.Id);
        }
        public async Task<bool> UpdateEntity(TEntity entity, bool dispose = false)
        {
            var methodcontext = context;
            var db = _redisCache.GetDatabase();
            var loginUser = await db.StringGetAsync(CommonConstants.COOKIE_KEY_AUTH);
            var loginUserName = await db.StringGetAsync(CommonConstants.COOKIE_KEY_GUID);
            if (loginUser.HasValue)
            {
                entity.ModifiedBy = Guid.Parse(loginUser.ToString());
            }
            if (loginUserName.HasValue)
            {
                entity.ModifiedByLookupName = loginUserName;
            }
            var source = await GetOriginEntity(entity);
            if(source == null) throw new ArgumentNullException(nameof(entity));
            var properties = source.GetType().GetProperties();
            foreach(var property in properties)
            {
                ConvertInternal(source, entity, property);
            }
            methodcontext.Update<TEntity>(entity);
            var result = await methodcontext.SaveChangesAsync();
            if (dispose) {
                methodcontext.Dispose(); 
            }
            return result > 0;
            
        }
        public static void ConvertInternal<TOtherEntity>(TEntity source, TOtherEntity update, PropertyInfo property) where TOtherEntity : BaseEntity
        {
            var updateValue = property.GetValue(update);
            property.SetValue(source, updateValue, null);
        }
        public async Task<List<TEntity>> GetDatasByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            var methodcontext = context;
            return await methodcontext.Set<TEntity>().Where(predicate).ToListAsync();
        }
        public async Task<TEntity> GetEntityByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            var methodcontext = context;
            return await methodcontext.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }
    }
}
