using Core.Entity;
using Core.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authen.Repository.Interface
{
    public interface IInformationRepository
    {
        Task<InformationEntity> GetById(Guid Id);
        Task<Guid> AddInformation(InformationEntity user);
        Task<BaseDataCollection<InformationEntity>> GetListInformation(DataGridModel model);
        Task<bool> UpdateInformation(InformationEntity entity);
        Task<bool> DeleteInformation(InformationEntity entity);
        Task<InformationEntity> SearchNumberCard(InformationEntity entity);
    }
}
