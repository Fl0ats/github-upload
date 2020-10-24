using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening____Exception_handeling
{
    public class Cat
    {
        public int Age { get; set; }
        public Cat(int age)
        {
            Age = age;
        }

        public static void controlAge(List<Cat> catList)
        {
            Cat[] cats = catList.ToArray();

            if (!Array.TrueForAll(cats, c => c.Age <= 0))
            {
                throw new CustomError($"Kat heeft een ongeldige leeftijd");
            }

        }
    }
}
