using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{

    public class EmployeeClass
    {
        public List<EmployeeClass> empid { get; set; }
        public int toAdd { get; set; }

        public static EmployeeClass operator+ (EmployeeClass empid, person Person)
        {
            empid.toAdd()
        }
    }  
}
