using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class Program
    {
        static void Main(string[] args)
        {
            Class clas =new Class();
            clas._className = "3Q";
            clas._semesterStart=new DateTime(2019-08-26);
            clas.Students.Add(new Student("GAnga",02,1995));
            clas.Students.Add(new Student("Popular", 08, 1993));
            clas.Students.Add(new Student("Khem", 05, 1992));
            Console.WriteLine($"Class Name :{clas._className}" );
            Console.WriteLine(clas._semesterStart.ToString());
            foreach (var item in clas.Students)
            {
                Console.WriteLine($" NAme Of student:{item.name}  BirthMonth: {item.birthMonth} Birthday: {item.birthday} ");
            }

            //Console.WriteLine(clas.NumberOfPeopleWithBirhtMonth(10).ToString());
            Console.ReadLine();
        }
    }
}
