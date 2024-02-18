using System.Dynamic;
using System.Net;

namespace ProjetoWebApiAtualizado.Dtos
{
    public class ResponseGeral<t> where t : class
    {
        public HttpStatusCode codigoHttp { get; set; }
        public t? Dadosretorno { get; set; }
        public ExpandoObject? erro { get; set; }

    }
}
