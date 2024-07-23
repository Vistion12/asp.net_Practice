using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net_Practice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get;  set; }
        public string Surname { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
        public void GetIn(IData data)
        {
            data.SaveData(Name, " пришел на работу", DateTime.Now );
        }

        public void GetOut(IData data)
        {
            data.SaveData(Name, "ушел с работы", DateTime.Now);
        }
    }
}
