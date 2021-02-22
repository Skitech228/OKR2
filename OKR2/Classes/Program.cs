using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OKR2.Classes.Absrtact;
using OKR2.Classes.Planets;

namespace OKR2.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        private static void Task1()
        {
            string str = Console.ReadLine();
            Type mytype = typeof(IPlanet);
            FieldInfo[] filds = mytype.GetFields();
            for (int i = 0; i < filds.Length; i++)
            {
                if (filds[i].IsSpecialName)
                {
                    if (filds[i].Name == str)
                    {
                        Planet planet = new Planet();
                        planet.Create(str);
                    }
                }
            }
        }
    }
}
