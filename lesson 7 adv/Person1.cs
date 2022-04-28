using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7_adv
{
    public class Person1
    {
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }

        public Person1(string name, List<Animal> animals)
        {
            Name = name;
            Animals = animals;
        }
    }
}
