using Excursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion
{
    class Lift
    {
        string lname;
        int capacity;
        int occupacy;
        List<Person> people = new List<Person>();

        public Lift(string liftName, int loadCapacity)
        {
            this.lname = liftName;
            this.capacity = loadCapacity;
        }

        public string LiftName
        { get { return lname; } }

        public int Capacity
        { get { return capacity; } }

        public List<Person> People
        { get { return people; } }

        public int LiftLoading
        {
            get
            {
                occupacy = 0;
                for (int i = 0; i < people.Count; i++)
                {
                    occupacy = occupacy + people[i].Weight;
                }
                return occupacy;
            }
        }

        public void PersonAdd(Person prsn)
        {
            if (capacity >= (LiftLoading + prsn.Weight))
            {
                people.Add(prsn);
            }
        }

        public void occupaing(List<Person> personL)
        {
            for (int i = 0; i < personL.Count; i++)
            {
                PersonAdd(personL[i]);
            }
            Console.WriteLine("\n" + LiftName + " заполнен");
        }

        public void linfo()
        {
            Console.WriteLine("\nНазвание лифта: " + LiftName);
            Console.WriteLine("Список людей в лифте:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].Name);
            }
            Console.WriteLine($"Текущая загруженность лифта " + LiftLoading + "кг из " + Capacity + "кг");

        }
    }
}
