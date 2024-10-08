using Core.Model;
using Core.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authen.Services.Interface
{
    public interface IInformationServices
    {
        Task<Guid> CreateInformation(InformationModel data);
        Task<BaseDataCollection<InformationModel>> GetListInformation(DataGridModel model);
        Task<bool> UpdateInformation(InformationModel model);
        Task<bool> DeleteInformation(InformationModel model);
        Task<InformationModel> GetById(InformationModel model);
    }
}
