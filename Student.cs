using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Student : Person
    {
        decimal scolarship;
        public decimal Scolarship
        {
            get { return scolarship; }
            set { scolarship = value; }
        }

        public Student(string name, int weight, DateTime dateBirth, string sex, decimal scolarship)
             : base(name, weight, dateBirth, sex)
        {
            this.scolarship = scolarship;
        }

        public override string  InfoString()
        {
            string inf = $"\nСтудент\nимя: {Name}" +
                 $"\nВес: {Weight}" +
                 $"\nдата рождения: {DateBirth.ToShortDateString()}" +
                 $"\nпол: {Sex}";

            // Новая информационная строка
            inf = inf + $"\nСтипендия: {scolarship} тенге";
            return inf;
        }


    }
}
