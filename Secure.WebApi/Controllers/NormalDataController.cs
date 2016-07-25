using System.Web.Http;

namespace Secure.WebApi.Controllers
{
    public class NormalDataController : ApiController
    {

        public string Get()
        {
            return "NormalData";
        }
    }
}
