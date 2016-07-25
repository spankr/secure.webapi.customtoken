using System.Web.Http;

namespace Secure.WebApi.Controllers
{
    [Authorize]
    public class SecureDataController : ApiController
    {
        /// <summary>
        /// When trying to call this method, make sure the Authorization header is set up properly in the request!
        /// GET /Secure.WebApi/api/SecureData HTTP/1.1
        /// Host: localhost
        /// Authorization: Token securekey
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return $"SecureData for {User.Identity.Name}";
        }

    }
}
