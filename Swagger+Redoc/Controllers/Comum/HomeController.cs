using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Swagger_Redoc.Controllers.Comum
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public object Get()
        {
            return "Versão do Assembly da WebApi ==> " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }

        [HttpGet]
        [Route("error")]
        public string Error()
        {
            throw new Exception("Ocorreu um erro!");
        }
    }
}