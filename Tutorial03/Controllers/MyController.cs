using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX;
using NFX.DataAccess.CRUD;
using NFX.DataAccess.MySQL;
using NFX.Serialization.JSON;
using NFX.Wave.Client;
using NFX.Wave.MVC;

using Tutorial03.Models;
using Tutorial03.Pages;

namespace Tutorial03.Controllers
{
  public class MyController : Controller
  {
    [Action]
    public Object Index()
    {
      var query = new Query("Data.Scripts.GetAllPeople", typeof(Person));
      var ds = App.DataStore as MySQLDataStore;
      var people = ds.LoadOneRowset(query).AsEnumerableOf<Person>();

      return new Index { People = people };
    }

    [Action]
    public void Delete(string personId)
    {
      var ds = App.DataStore as MySQLDataStore;
      ds.Delete(new Person { ID = personId });
    }

    [Action(name: "edit", order: 1, matchScript: "match{ methods='GET' }")]
    public Object EditPerson(string personId)
    {
      Person person = null;
      if (personId.IsNotNullOrWhiteSpace())
      {
        var query = new Query("Data.Scripts.GetPersonByID", typeof(Person)) { new Query.Param("pID", personId) };
        var ds = App.DataStore as MySQLDataStore;
        person = ds.LoadOneRow(query) as Person;
      }

      if (person == null)
        person = new Person { ID = Guid.NewGuid().ToString("N"), Age = 18 };

      Exception validationError = null;
      RecordModelGenerator gen = new RecordModelGenerator();
      string personDef = gen.RowToRecordInitJSON(person, validationError).ToJSON();
      return new Edit { PersonDef = personDef };
    }

    [Action(name: "edit", order: 1, matchScript: "match{ methods='POST' }")]
    public Object SavePerson(Person person)
    {
      var validationError = person.Validate();
      if (validationError == null)
      {
        var ds = App.DataStore as MySQLDataStore;
        ds.StringBool = false;
        ds.Upsert(person);
        return new Redirect("/");
      }

      RecordModelGenerator gen = new RecordModelGenerator();
      string personDef = gen.RowToRecordInitJSON(person, validationError).ToJSON();
      return new Edit { PersonDef = personDef };
    }
  }
}
