using Authen.Repository.Interface;
using Authen.Services.Interface;
using AutoMapper;
using Core.Entity;
using Core.Model;
using Core.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authen.Services.Behaviours
{
    public class InformationServices : IInformationServices
    {
        private readonly IInformationRepository _InformationRepository;
        private readonly IMapper _mapper;
        public InformationServices(
            IInformationRepository InformationRepository,
            IMapper mapper)
        {
            _InformationRepository = InformationRepository;
            _mapper = mapper;
        }

        public async Task<Guid> CreateInformation(InformationModel model)
        {
            var entity = _mapper.Map<InformationModel, InformationEntity>(model);
            Guid result = await _InformationRepository.AddInformation(entity);
            return result;
        }

        public async Task<bool> DeleteInformation(InformationModel model)
        {
            var entity = _mapper.Map<InformationModel, InformationEntity>(model);
            var result = await _InformationRepository.DeleteInformation(entity);
            return result;
        }

        public async Task<BaseDataCollection<InformationModel>> GetListInformation(DataGridModel model)
        {
            var result = await _InformationRepository.GetListInformation(model);
            var realResult = new BaseDataCollection<InformationModel>()
            {
                TotalRecordCount = result.TotalRecordCount,
                PageIndex = result.PageIndex,
                PageCount = result.PageCount
            };
            realResult.BaseDatas = _mapper.Map<List<InformationEntity>, List<InformationModel>>(result.BaseDatas);
            return realResult;
        }

        public async Task<bool> UpdateInformation(InformationModel model)
        {
            var entity = _mapper.Map<InformationModel, InformationEntity>(model);
            var result = await _InformationRepository.UpdateInformation(entity);
            return result;
        }
        public async Task<InformationModel> GetById(InformationModel model)
        {
            var entity = _mapper.Map<InformationModel, InformationEntity>(model);
            var result = await _InformationRepository.GetById(entity.Id);
            var update = _mapper.Map<InformationEntity, InformationModel>(result);
            return update;
        }
        public async Task<InformationModel> SearchNumberCard(InformationModel model)
        {
            var entity = _mapper.Map<InformationModel, InformationEntity>(model);
            var result = await _InformationRepository.SearchNumberCard(entity);
            var update = _mapper.Map<InformationEntity, InformationModel>(result);
            return update;
        }
    }
}
