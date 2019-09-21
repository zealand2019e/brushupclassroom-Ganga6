using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class Class
    {
     public string _className { get; set; }
     private List<Student> students;
        public  DateTime _semesterStart { get; set; }
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public Class()
      {
          students = new List<Student>();
        }
    }
}
