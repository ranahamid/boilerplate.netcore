using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Demo.Controllers;

namespace Demo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
