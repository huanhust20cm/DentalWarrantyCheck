using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Mapper
{
    public interface IMapperFac
    {
        IMapper GetMapper(string mapperName);
    }
}
