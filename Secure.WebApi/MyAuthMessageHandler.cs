using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Secure.WebApi
{
    public class MyAuthMessageHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            if (request.Headers.Authorization != null)
            {
                if ("Token".Equals(request.Headers.Authorization.Scheme) && "securekey".Equals(request.Headers.Authorization.Parameter))
                {
                    SetPrincipal(new GenericPrincipal(new GenericIdentity("Bob"), new[] { "Admin" }));
                }
            }

            // Call the rest of the handler pipeline
            return await base.SendAsync(request, cancellationToken);
        }

        private void SetPrincipal(IPrincipal principal)
        {
            Thread.CurrentPrincipal = principal;
            if (HttpContext.Current != null)
            {
                HttpContext.Current.User = principal;
            }
        }
    }
}