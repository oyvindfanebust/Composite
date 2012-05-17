using System.Web.Mvc;
using Composite.Silo1.Properties;

namespace Composite.Silo1.Controllers
{
    public class Silo1Controller : Controller
    {
        public ActionResult Index()
        {
            return Content(Resources.Test2, "application/javascript");
        }

        public ActionResult Foo()
        {
            return Json(new {baz = "Hello!"}, JsonRequestBehavior.AllowGet);
        }
    }
}
