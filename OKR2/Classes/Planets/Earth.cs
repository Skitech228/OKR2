using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKR2.Classes.Planets
{
    class Earth
    {
        private static Earth instance;

        private Earth()
        { }

        public static Earth GetInstance()
        {
            if (instance == null)
                instance = new Earth();
            return instance;
        }
    }
}
