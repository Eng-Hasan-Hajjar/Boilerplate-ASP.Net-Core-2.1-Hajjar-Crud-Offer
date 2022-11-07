using Microsoft.AspNetCore.Antiforgery;
using boilerplateasp.Controllers;

namespace boilerplateasp.Web.Host.Controllers
{
    public class AntiForgeryController : boilerplateaspControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
