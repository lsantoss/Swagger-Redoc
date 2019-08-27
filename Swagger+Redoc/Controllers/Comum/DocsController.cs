using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Swagger_Redoc.Controllers.Comum
{
    [Route("docs")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DocsController : Controller
    {
        [Route(""), HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}