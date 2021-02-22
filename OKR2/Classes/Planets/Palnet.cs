using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKR2.Classes.Absrtact;

namespace OKR2.Classes.Planets
{
    class Planet:IPlanet
    {
        private Earth earth;
        private Moon moon;
        private Sun sun;
        public void Create(string planet)
        {
            if (planet == "Moon")
            {
                moon = Moon.GetInstance();
            }
            if (planet == "Earth")
            {
                earth = Earth.GetInstance();
            }

            if (planet == "Sun")
            {
                sun = Sun.GetInstance();
            }
        }
    }
}
