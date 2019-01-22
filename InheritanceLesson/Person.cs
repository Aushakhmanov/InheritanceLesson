using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public abstract class Person          //abstract -класс, экземпляры которого создать невозможно
    {
        private string _addtess;
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }

        public Person(string fullName)

        {
            FullName = fullName;
        }

        public virtual void DoStaff(string staffName)
        {
            Console.WriteLine($"{FullName}делает{staffName}");
        }

        public abstract void SayAllInfo();
        
    }
}
