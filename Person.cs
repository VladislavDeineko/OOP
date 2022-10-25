using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Person
    {
        string name;
        int weight;
        DateTime dateBirth;
        string sex;

        // 3 свойства
        public string Name
        { get { return name; } }

        public int Weight
        { get { return weight; } }

        public DateTime DateBirth
        { get { return dateBirth; } }

        public string Sex
        { get { return sex; } }

        // Метод: информационная строка
        public virtual string InfoString()
        {
            // строим информационную строку, используя интерполяцию строк
            // что такое интерполяция строк - см. Справку 
            string inf = $"\nЧеловек\nимя: {name}" +
                         $"\nВес: {Weight}" +
                         $"\nдата рождения: {dateBirth.ToShortDateString()}" +
                         $"\nпол: {sex}";

            return inf;
        }

        // Конструктор
        public Person(string name, int weight, DateTime dateBirth, string sex)
        {
            this.name = name;
            this.weight = weight;
            this.dateBirth = dateBirth;
            this.sex = sex;
        }
    }
}

