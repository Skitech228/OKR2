using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OKR2.Classes.Planets
{
    class Moon
    {
        private static Moon instance;

        private Moon()
        { }

        public static Moon GetInstance()
        {
            if (instance == null)
                instance = new Moon();
            return instance;
        }
    }
}
