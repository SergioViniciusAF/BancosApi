using ProjetoWebApiAtualizado.Dtos;
using ProjetoWebApiAtualizado.Moderls;

namespace ProjetoWebApiAtualizado.Interfaces
{
    public interface IGeral
    {
       
           
            Task<ResponseGeral<List<ParametrosModel>>> BuscarTodosBancos();
            Task<ResponseGeral<ParametrosModel>> BuscarBancos(string codigoBanco);
        
    }
}
