using AutoMapper;

namespace Utility.Mapper
{
    public class MapperFac : IMapperFac
    {
        public Dictionary<string, IMapper> Mappers { get; set; } = new Dictionary<string, IMapper>();
        public IMapper GetMapper(string mapperName)
        {
            return Mappers[mapperName];
        }

    }
}
