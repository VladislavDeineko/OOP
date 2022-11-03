using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("Ann", 50, new DateTime(2000, 11, 12), "жен");
            Console.WriteLine(per.InfoString());

            Person tc1 = new Teacher("Robert", 80, new DateTime(1980, 1, 3), "муж", 12);
            Console.WriteLine(tc1.InfoString());

            Person tc2 = new Teacher("Alexey", 85, new DateTime(1984, 7, 11), "муж", 8);
            Console.WriteLine(tc2.InfoString());

            Person st1 = new Student("Евгеха", 100, new DateTime(2005, 4, 5), "муж", 131);
            Console.WriteLine(st1.InfoString());

            Person st2 = new Student("Шодиджон", 72, new DateTime(2004, 4, 3), "муж", 1);
            Console.WriteLine(st2.InfoString());

            Person st3 = new Student("Диана", 56, new DateTime(2003, 1, 1), "муж", 111);
            Console.WriteLine(st3.InfoString());


            List<Person> Excursion = new List<Person>()

            {
                tc1,
                tc2,
                st1,
                st2,
                st3
            };

            Console.WriteLine("\nУчастники экскурсии: ");
            for (int i = 0; i < Excursion.Count; i++)
            { Console.WriteLine(Excursion[i].Name); }

            int count = 0;

            for (int i = 0; i < Excursion.Count; i++)
            {
                if (Excursion[i] is Student) { count++; }
            }

            Console.WriteLine("\nКоличество студентов участников экскурсии: " + count);

            //
            List<Person> students = new List<Person>() { st1, st2, st3 };
            List<Person> teachers = new List<Person>() { tc1, tc2, per };
            Lift liftStudent = new Lift("Лифт для студентов", 200);
            Lift liftTeacher = new Lift("Лифт для учителей", 200);
            Console.ForegroundColor = ConsoleColor.Red;
            liftStudent.occupaing(students);
            liftTeacher.occupaing(teachers);
            Console.ForegroundColor = ConsoleColor.Green;
            liftStudent.linfo();
            liftTeacher.linfo();

            Console.ReadLine();
        }
    }
}
