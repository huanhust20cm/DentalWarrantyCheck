
using Core.Entity;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseServices.Map
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<InformationEntity, InformationModel>();
            CreateMap<InformationModel, InformationEntity>();
        }

    }
}
