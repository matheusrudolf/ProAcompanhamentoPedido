using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewResult ViewResultado = new ViewResult()
            {
                ViewName = "Resultado",
                ViewData = new ViewDataDictionary(
                    new EmptyModelMetadataProvider(),
                    new ModelStateDictionary())
                {
                    Model = $"Home Controller"
                }
            };
            return ViewResultado;
        }
    }
}