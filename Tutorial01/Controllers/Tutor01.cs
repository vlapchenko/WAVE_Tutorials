using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.Wave.MVC;
using Tutorial01.Pages;

namespace Tutorial01.Controllers
{
    public class Tutor01 : Controller
    {
        [Action]
        public object Index()
        {
            return new Index();
        }
    }
}
