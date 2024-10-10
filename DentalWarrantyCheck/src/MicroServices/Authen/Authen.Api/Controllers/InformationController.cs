using Authen.Services.Interface;
using Core.Model;
using Core.Model.Query;
using Microsoft.AspNetCore.Mvc;
using BaseServices;

namespace Authen.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class InformationController : Controller
    {
        private readonly IInformationServices _InformationServices;
        public InformationController(IInformationServices InformationServices)
        {
            _InformationServices = InformationServices;
        }

        [HttpPost()]
        [Route("createinformation")]
        public async Task<BaseResponse<Guid>> CreateInformation(InformationModel model)
        {
            return await this.Run(() => _InformationServices.CreateInformation(model));
        }
        [HttpPost()]
        [Route("getlistinformation")]
        public async Task<BaseResponse<BaseDataCollection<InformationModel>>> GetListInformation(DataGridModel model)
        {
            return await this.Run(() => _InformationServices.GetListInformation(model));
        }
        [HttpPost()]
        [Route("updateinformation")]
        public async Task<BaseResponse<bool>> UpdateInformation(InformationModel model)
        {
            return await this.Run(() => _InformationServices.UpdateInformation(model));
        }
        [HttpPost()]
        [Route("deleteinformation")]
        public async Task<BaseResponse<bool>> DeleteInformation(InformationModel model)
        {
            return await this.Run(() => _InformationServices.DeleteInformation(model));
        }
        [HttpPost()]
        [Route("getinformationbyid")]
        public async Task<BaseResponse<InformationModel>> GetInformationById(InformationModel model)
        {
            return await this.Run(() => _InformationServices.GetById(model));
        }
        [HttpPost()]
        [Route("searchnumbercard")]
        public async Task<BaseResponse<InformationModel>> SearchNumberCard(InformationModel model)
        {
            return await this.Run(() => _InformationServices.SearchNumberCard(model));
        }
    }
}
