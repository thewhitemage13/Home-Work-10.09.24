using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Group
{
    public class ConsoleStudentPrinter : IPrinter<Student>
    {
        public void Print(Student student) 
        {
            Console.WriteLine(student);
        }
    }
}
