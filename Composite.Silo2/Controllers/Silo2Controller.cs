using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Composite.Silo2.Properties;

namespace Composite.Silo2.Controllers
{
    public class Silo2Controller : Controller
    {
         public ActionResult Index()
         {
             return JavaScript(Resources.Silo2);
         }

        public ActionResult GetPersons(IEnumerable<Guid> ids)
        {
            var family = new Family(){Persons = new List<Person>()};
            foreach (var id in ids)
            {
                family.Persons.Add(new Person {Id = id, Name = "Person"});
            }

            return Json(family, JsonRequestBehavior.AllowGet);
        }
    }

    public class Family
    {
        public List<Person> Persons { get; set; }
    }

    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}