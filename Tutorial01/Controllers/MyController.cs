using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.Wave.MVC;
using Tutorial01.Pages;

namespace Tutorial01.Controllers
{
    public class MyController : Controller
    {
        [Action]
        public object GetTime()
        {
            return new Index();
        }
    }
}
