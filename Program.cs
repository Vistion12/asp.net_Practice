using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asp.net_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<IData, FileSave>();
            

            services.AddTransient<Work>();
            services.AddTransient<Employee>(provider => new Employee("игорЪ")); 

            var serviceProvider = services.BuildServiceProvider();

            var work = serviceProvider.GetService<Work>();
            var employee = serviceProvider.GetService<Employee>();

            work.EmployeeArrival(employee);
            Thread.Sleep(3000);
            work.EmployeeDeparture(employee);
        }
    }
}
