//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 23.02.2016 17:52:56 by NFX.Templatization.TextCSTemplateCompiler at LAPTOP

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 
using NFX; 
using NFX.Wave; 
using NFX.Wave.Templatization; 
using Tutorial03.Models; 

namespace Tutorial03.Pages 
{

 ///<summary>
 /// Auto-generated from template
 ///</summary>
 public  class Index : NFX.Wave.Templatization.WaveTemplate 
 {

  public IEnumerable<Person> People { get; set; }

  
     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( Index._66_S_LITERAL_0 );
        Target.Write( Index._66_S_LITERAL_1 );
      foreach (var person in People){
        Target.Write( Index._66_S_LITERAL_2 );
        Target.Write(Target.Encode( person.ID ));
        Target.Write( Index._66_S_LITERAL_3 );
        Target.Write(Target.Encode( person.FirstName ));
        Target.Write( Index._66_S_LITERAL_4 );
        Target.Write(Target.Encode( person.LastName ));
        Target.Write( Index._66_S_LITERAL_4 );
        Target.Write(Target.Encode( person.Age ));
        Target.Write( Index._66_S_LITERAL_5 );
      if (person.IsCertified) {
        Target.Write( Index._66_S_LITERAL_6 );
      } else {
        Target.Write( Index._66_S_LITERAL_7 );
      }
        Target.Write( Index._66_S_LITERAL_8 );
        Target.Write(Target.Encode( person.ID ));
        Target.Write( Index._66_S_LITERAL_9 );
        Target.Write(Target.Encode( person.ID ));
        Target.Write( Index._66_S_LITERAL_10 );
      }
        Target.Write( Index._66_S_LITERAL_11 );

     }


     #region Literal blocks content
        private const string _66_S_LITERAL_0 = @"

"; 
        private const string _66_S_LITERAL_1 = @"
  <!DOCTYPE html>

  <html>
  <head>
    <meta charset=""utf-8"" />
    <title>WAVE Tutorial 03</title>
    <style>
      table {
        border-collapse: collapse;
      }
      td {
        border: 1px solid #000;
        padding: 5px;
      }
      thead {
        font-weight: 600;
        background-color: #CCC;
      }
      .container {
        margin-left: 20%;
        margin-top: 50px;
      }
    </style>
    <script src=""/stock/site/script/jquery-2.1.4.min.js""></script>
    <script src=""/stock/site/script/wv.js""></script>
    <script src=""/stock/site/script/wv.gui.js""></script>
  </head>
  <body>
    <div class=""container"">
      <a href=""/MyController/Edit"">Add Person</a>
      <br />
      <br />
      <table>
        <thead>
          <tr>
            <td>FirstName</td>
            <td>LastName</td>
            <td>Age</td>
            <td>IsCertified</td>
            <td></td>
            <td></td>
          </tr>
        </thead>
        "; 
        private const string _66_S_LITERAL_2 = @"
        <tr id="""; 
        private const string _66_S_LITERAL_3 = @""">
          <td>"; 
        private const string _66_S_LITERAL_4 = @"</td>
          <td>"; 
        private const string _66_S_LITERAL_5 = @"</td>
          "; 
        private const string _66_S_LITERAL_6 = @"
          <td style=""color: green;"">Yes</td>
          "; 
        private const string _66_S_LITERAL_7 = @"
          <td style=""color: red;"">No</td>
          "; 
        private const string _66_S_LITERAL_8 = @"
          <td><a href=""/MyController/Edit?personId="; 
        private const string _66_S_LITERAL_9 = @""" style=""text-decoration: none;"">Edit</a></td>
          <td><a onclick=""deletePerson('"; 
        private const string _66_S_LITERAL_10 = @"')"" style=""cursor: pointer; color: blue;"">Delete</a></td>
        </tr>
        "; 
        private const string _66_S_LITERAL_11 = @"
      </table>
    </div>
    <script>
      function deletePerson(pID) {
        var request = new XMLHttpRequest();
        request.open(""POST"", ""/MyController/Delete?personId="" + pID);
        request.onreadystatechange = function () {
          if (request.readyState == 4 && request.status == 200) {
            var row = $('#' + pID);
            row.remove();           
          }
        }
        request.send();
      }
    </script>
  </body>
</html>"; 
     #endregion

 }//class
}//namespace
