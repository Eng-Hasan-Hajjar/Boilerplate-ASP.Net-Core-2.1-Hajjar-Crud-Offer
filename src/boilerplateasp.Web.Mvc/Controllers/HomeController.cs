using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using boilerplateasp.Controllers;

namespace boilerplateasp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : boilerplateaspControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
