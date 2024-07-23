using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net_Practice
{
    public class Work
    {
        private readonly IData _data;

        public Work(IData data)
        {
            _data= data;
        }

        public void EmployeeArrival(Employee employee)
        {
            employee.GetIn(_data);
        }

        public void EmployeeDeparture(Employee employee)
        {
            employee.GetOut(_data);
        }
    }
}
