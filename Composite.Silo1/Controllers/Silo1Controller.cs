using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Composite.Silo1.Properties;

namespace Composite.Silo1.Controllers
{
    public class Silo1Controller : Controller
    {
        public ActionResult Index()
        {
            return JavaScript(Resources.Silo1);
        }

        public ActionResult GetThings()
        {
            return Json(new ThingContainer { ThingOwners = new List<ThingOwner>
                                                               {
                                                                   new ThingOwner{ Id = Guid.NewGuid(), NumberOfThings = 1 },
                                                                   new ThingOwner{ Id = Guid.NewGuid(), NumberOfThings = 4 },
                                                                   new ThingOwner{ Id = Guid.NewGuid(), NumberOfThings = 7 },
                                                               } }, JsonRequestBehavior.AllowGet);
        }
    }

    public class ThingContainer
    {
        public List<ThingOwner> ThingOwners { get; set; }
    }

    public class ThingOwner
    {
        public Guid Id { get; set; }
        public int NumberOfThings { get; set; }
    }
}
