using ProjetoWebApiAtualizado.Dtos;
using ProjetoWebApiAtualizado.Interfaces;
using ProjetoWebApiAtualizado.Moderls;
using System.Dynamic;
using System.Text.Json;

namespace ProjetoWebApiAtualizado.Rest
{
    public class ParametrosApiRest : IGeral
    {


        public async Task<ResponseGeral<List<ParametrosModel>>> BuscarTodosBancos()
        {


            var request = new HttpRequestMessage(HttpMethod.Get,"https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseGeral<List<ParametrosModel>>();
            using (var client = new HttpClient())
            {
                var responseParam = await client.SendAsync(request);
                var contentResp = await responseParam.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<ParametrosModel>>(contentResp);
                if (responseParam.IsSuccessStatusCode)
                {
                    response.codigoHttp = responseParam.StatusCode;
                    response.Dadosretorno = objResponse;
                }
                else
                {
                    response.codigoHttp = responseParam.StatusCode;
                    response.erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;

        }


        public async Task<ResponseGeral<ParametrosModel>> BuscarBancos(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
            var response = new ResponseGeral<ParametrosModel>();
            using (var client = new HttpClient())
            {
                var responseParam = await client.SendAsync(request);
                var contentResp = await responseParam.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<ParametrosModel>(contentResp);
                if (responseParam.IsSuccessStatusCode)
                {
                    response.codigoHttp = responseParam.StatusCode;
                    response.Dadosretorno = objResponse;
                }
                else
                {
                    response.codigoHttp = responseParam.StatusCode;
                    response.erro = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }
    }
}
