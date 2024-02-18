using ProjetoWebApiAtualizado.Dtos;


namespace ProjetoWebApiAtualizado.Interfaces
{
    public interface IParametros
    {
        Task<ResponseGeral<List<ParametrosResponse>>> BuscarTodosBancos();
        Task<ResponseGeral<ParametrosResponse>> BuscarBancos(string codigoBanco);
    }
}
