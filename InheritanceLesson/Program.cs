using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Student student = new Student
        //    {
        //        FullName = "Василий Петров",
        //        Age = 19,
        //        Gender = 1,
        //        MarkAvarage = 4.6,
        //        GroupName="EE-123"
          

        Person person = new Student("sdsd","sdsd");
            Person mentor = new Mentor("Василий Петрович");

            Console.WriteLine(person);
            Console.ReadLine();
            (person as Student).MarkAvarage = 4.6;     //переменная person будет использоваться как тип Student

            Person[] people = new Person[]
            {
                person,mentor
            };

            foreach(var man in people)
            {
                if (man is Student)
                {
                    Console.WriteLine((man as Student).MarkAvarage);
                    man.DoStaff("какое-то дело студента");
                }
                else if (man is Mentor)
                {
                    Console.WriteLine((man as Mentor).SubjectsName);
                    man.DoStaff("какое-то дело препода");
                }
            }
        }
    }
}
