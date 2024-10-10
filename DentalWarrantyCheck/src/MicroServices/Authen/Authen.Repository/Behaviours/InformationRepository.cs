using Authen.Repository.Interface;
using Core.Entity;
using Core.Model.Query;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Behaviours;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authen.Repository.Behaviours
{
    public class InformationRepository : BaseRepository<InformationEntity>, IInformationRepository
    {
        public InformationRepository(Func<BaseDbContext> func, IConnectionMultiplexer redisCache) : base(func, redisCache)
        {

        }
        public async Task<Guid> AddInformation(InformationEntity model)
        {
            if (model.Id == Guid.Empty)
            {
                model.Id = Guid.NewGuid();
            }
            await AddEntity(model);
            return model.Id;
        }

        public async Task<InformationEntity> GetById(Guid Id)
        {
            return await base.GetById(Id);
        }
        public async Task<bool> UpdateInformation(InformationEntity entity)
        {
            return await base.UpdateEntity(entity);
        }
        public async Task<bool> DeleteInformation(InformationEntity entity)
        {
            return await base.DeleteEntity(entity);
        }
        public async Task<BaseDataCollection<InformationEntity>> GetListInformation(DataGridModel model)
        {
            using (var method = base.context)
            {
                var Information = method.Informations.AsNoTracking().Where(i => !i.Delete);
                var searchInfo = model.SearchInfo;
                var pageInfo = model.PageInfo;
                var orderInfo = model.OrderInfo;
                var filterInfo = model.FilterInfo;
                if (searchInfo?.SearchRule?.Any() == true)
                {
                    var searchValue = searchInfo.SearchRule.First().KeyWord;
                    //if (!string.IsNullOrEmpty(searchValue))
                    //{
                    //    Information = Information.Where(i => i.Title.Contains(searchValue));
                    //}
                }
                int start = pageInfo.Start;
                var total = Information.Count();
                var result = new BaseDataCollection<InformationEntity>();

                result.BaseDatas = await Information.OrderByDescending(item => item.CreateDate).Skip(start == 0 ? (pageInfo.PageSize * (pageInfo.PageNo - 1)) : start).Take(pageInfo.PageSize).ToListAsync();
                result.TotalRecordCount = total;
                result.PageCount = (int)Math.Ceiling(Convert.ToDecimal(total) / Convert.ToDecimal(pageInfo.PageSize));
                result.PageIndex = pageInfo.PageNo;
                return result;
            }
        }
        public async Task<InformationEntity> SearchNumberCard(InformationEntity entity)
        {
            using (var method = base.context)
            {
                var Information = await method.Informations.AsNoTracking().Where(i => !i.Delete && (entity.NumberCard == i.NumberCard || entity.DateOfBirth == i.DateOfBirth)).FirstOrDefaultAsync();
                return Information;
            }
        }
    }
}
