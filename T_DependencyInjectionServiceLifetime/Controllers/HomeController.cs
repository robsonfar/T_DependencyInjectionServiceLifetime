using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using T_DependencyInjectionServiceLifetime.Models;
using T_DependencyInjectionServiceLifetime.Services.Interface;

namespace T_DependencyInjectionServiceLifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        public HomeController(
            ISingletonService singletonService1
            , ISingletonService singletonService2
            , IScopedService scopedService1
            , IScopedService scopedService2
            , ITransientService transientService1
            , ITransientService transientService2)
        {
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _transientService1 = transientService1;
            _transientService2 = transientService2;
        }


        public IActionResult Index()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[Training] Dependency Injection Service Lifetime \n\n\n");

            sb.Append("Press F5 to reload the page and see how it works... \n\n");

            sb.Append($"Singleton 1: {_singletonService1.GetValue()} (New Service - Once per application lifetime) \n");
            sb.Append($"Singleton 2: {_singletonService2.GetValue()} (New Service - Once per application lifetime) \n\n");

            sb.Append($"Scoped 1: {_scopedService1.GetValue()} (New Service - Once per request) \n");
            sb.Append($"Scoped 2: {_scopedService2.GetValue()} (New Service - Once per request) \n\n");

            sb.Append($"Transient 1: {_transientService1.GetValue()} (New Service - Every time requested) \n");
            sb.Append($"Transient 2: {_transientService2.GetValue()} (New Service - Every time requested) \n\n");

            return Ok(sb.ToString());
        }

    }
}
