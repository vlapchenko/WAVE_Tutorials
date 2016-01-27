using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.Serialization.JSON;
using NFX.Wave.Client;
using NFX.Wave.MVC;

using Tutorial02.Models;
using Tutorial02.Pages;

namespace Tutorial02.Controllers
{
    public class MyController : Controller
    {
        [Action]
        public Object Index()
        {
            Person pers = new Person { FirstName = "John", LastName = "Smith", Age = 20, IsCertified=true };
            Exception validationError = null;
            RecordModelGenerator gen = new RecordModelGenerator();
            string personDef = gen.RowToRecordInitJSON(pers, validationError).ToJSON();
            return new Index { PersonDef = personDef };
        }

        [Action(name: "person", order: 1, matchScript: "match{ methods='POST' }")]
        public Object SavePerson(Person pers)
        {
            Console.WriteLine(pers.ToString());
            return new { OK = true };
        }
    }
}
