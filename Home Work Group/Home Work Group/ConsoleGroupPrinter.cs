using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Group
{
    public class ConsoleGroupPrinter : IPrinter<Group>
    {
        public void Print(Group group)
        {
            Console.WriteLine(group);
        }
    }
}
