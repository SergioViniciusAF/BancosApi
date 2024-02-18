using AutoMapper;
using ProjetoWebApiAtualizado.Dtos;
using ProjetoWebApiAtualizado.Interfaces;

namespace ProjetoWebApiAtualizado.Services
{
    public class ParametrosService:  IParametros
    {
        private readonly IMapper _mapper;
        private readonly IGeral _parametros;

        public ParametrosService(IMapper mapper, IGeral parametros)
        {
            _mapper = mapper;
            _parametros = parametros;
        }

        public async Task<ResponseGeral<List<ParametrosResponse>>> BuscarTodosBancos()
        {
            var bancos = await _parametros.BuscarTodosBancos();
            return _mapper.Map<ResponseGeral<List<ParametrosResponse>>>(bancos);
        }
        public async Task<ResponseGeral<ParametrosResponse>> BuscarBancos(string codigoBanco)
        {
            var banco = await _parametros.BuscarBancos(codigoBanco);
            return _mapper.Map<ResponseGeral<ParametrosResponse>>(banco);

        }

    }
}
