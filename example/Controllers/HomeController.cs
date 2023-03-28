using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.Controllers
{
    internal class HomeController : System.Mvc.Controller
    {
        public object Index() => View("VST Team");
    }
}
