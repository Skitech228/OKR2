using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OKR2.Classes
{
    class Regects
    {
        Regex regex = new Regex(@"^ http:\/\/\w *.ru\/\w *\/ index.html\?(\S *)");
    }
}
