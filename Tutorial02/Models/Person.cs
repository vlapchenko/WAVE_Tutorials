using NFX.DataAccess.CRUD;
using NFX.Serialization.JSON;

namespace Tutorial02.Models
{
    public class Person : TypedRow
    {
        [Field(required: true, maxLength: 32, description: "First Name")]
        public string FirstName { get; set; }

        [Field(required: true, maxLength: 32, description: "Last Name")]
        public string LastName { get; set; }

        [Field(required: false, kind: DataKind.Number, min: 18, max: 100,  description: "Age")]
        public int Age { get; set; }

        [Field(required: false, dflt: false, description: "Certified C# developer")]
        public bool IsCertified { get; set; }

        public override string ToString()
        {
            return this.ToJSON(JSONWritingOptions.PrettyPrintRowsAsMap);
        }
    }
}
