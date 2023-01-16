using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionApplikation
{
    internal class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Pet { get; set; }

        //Skapar en static lista för People objekt
        public static List<People> persons = new List<People>();

        public People (int id, string name, int age, string pet)
        {
            Id = id;
            Name = name;
            Age = age;
            Pet = pet;
        }
    }
}
