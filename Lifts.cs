using Excursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion
{
    class Lift : Person
    {
        int capacity;
        List<Person> Lift1 = new List<Person>();

        public Lift (int cap, List<Person> lft)
        {
            capacity = cap;
            Lift1 = lft;
        }

        public List<Person> PersonAdd()
        {
            Lift1.Add(); 
        }
    }
}
