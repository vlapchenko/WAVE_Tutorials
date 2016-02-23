using NFX.DataAccess.CRUD;

namespace Tutorial03.Models
{
  public class Person : TypedRow
  {
    [Field(key: true, required: true, visible:false)]
    public string ID { get; set; }

    [Field(required: true, maxLength: 32, description: "First Name")]
    public string FirstName { get; set; }

    [Field(required: true, maxLength: 32, description: "Last Name")]
    public string LastName { get; set; }

    [Field(required: false, min: 18, max: 100, description: "Age")]
    public int Age { get; set; }

    [Field(required: false, dflt: false, description: "Certified C# developer")]
    public bool IsCertified { get; set; }
  }
}
