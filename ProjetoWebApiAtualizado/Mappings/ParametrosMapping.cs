using AutoMapper;
using ProjetoWebApiAtualizado.Dtos;
using ProjetoWebApiAtualizado.Moderls;

namespace ProjetoWebApiAtualizado.Mappings
{
    public class ParametrosMapping : Profile
    {
        public ParametrosMapping()
        {
          
            CreateMap(typeof(ResponseGeral<>), typeof(ResponseGeral<>));
            CreateMap<ParametrosResponse, ParametrosModel>();
            CreateMap<ParametrosModel, ParametrosResponse>();
        }

    }
}
