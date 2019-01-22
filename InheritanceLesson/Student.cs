using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
   public sealed class Student: Person //sealed-не имеем права наследоваться от этого класса
    {
      
        public double MarkAvarage { get; set; }
        public string GroupName { get; set; }
        public Student(string fullName,string groupName):base(fullName)                   //base-обращение к базовому классу
        {
            
            GroupName = groupName;
            
        }
        public new void DoStaff(string staffName)
        {
            //мы явно точно создаем свою  реализацию этого метода
        }
        public override void SayAllInfo()
        {
            throw new NotImplementedException(); //реализуем
        }


        public override string ToString()
        {
            return $"{FullName},{GroupName}";
        }
    }
}
