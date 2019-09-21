using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
      public  string name { get; set; }
       public int birthMonth { get; set; }
       public int birthday { get; set; }
       public string season { get ; set; }

       public Student(string name, int birthMonth, int birthday)
       {
           this.name = name;
           this.birthMonth = birthMonth;
           this.birthday = birthday;
       }

       public string Season()
       {

           if (birthMonth == 1 || birthMonth == 12 || birthMonth == 2)
           {
               return "Winter";
           }
           if (birthMonth == 3 || birthMonth == 4 || birthMonth == 5)
           {
               return "Spring";
           }
           if (birthMonth == 6 || birthMonth == 7 || birthMonth == 8)
           {
               return "Summer";
           }
           if (birthMonth == 9 || birthMonth == 10 || birthMonth == 11)
           {
               return "Autumn";
           }
           throw new Exception("birth month is not valid");
        }
    }
}
