//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 26.01.2016 17:56:57 by NFX.Templatization.TextCSTemplateCompiler at LAPTOP

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 
using NFX; 
using NFX.Wave; 
using NFX.Wave.Templatization; 

namespace Tutorial01.Pages 
{

 ///<summary>
 /// Auto-generated from template
 ///</summary>
 public  class Index : NFX.Wave.Templatization.WaveTemplate
 {

     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( Index._66_S_LITERAL_0 );
        Target.Write( Index._66_S_LITERAL_1 );
        Target.Write(Target.Encode( DateTime.Now ));
        Target.Write( Index._66_S_LITERAL_2 );

     }


     #region Literal blocks content
        private const string _66_S_LITERAL_0 = @"

"; 
        private const string _66_S_LITERAL_1 = @"
<!DOCTYPE html>

<html>
<head>
    <meta charset=""utf-8"" />
    <title>WAVE Tutorial 01</title>
    <style>
        body {
            text-align: center;
        }
        strong {
            font-size: 20px;
        }
    </style>
</head>
<body>
    <h1>Hello, world!</h1>
    <p>Server's datetime is <strong>"; 
        private const string _66_S_LITERAL_2 = @"</strong></p>
</body>
</html>"; 
     #endregion

 }//class
}//namespace
