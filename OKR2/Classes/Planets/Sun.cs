using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKR2.Classes.Planets
{
    class Sun
    {
        private static Sun instance;

        private Sun()
        { }

        public static Sun GetInstance()
        {
            if (instance == null)
                instance = new Sun();
            return instance;
        }
    }
}
