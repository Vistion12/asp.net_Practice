using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace asp.net_Practice
{
    public class FileSave : IData
    {
        public void SaveData(string name, string action, DateTime time)
        {
            
            Console.WriteLine($"сохраняю в файл : {name} - {action} в {time}");
        }
    }
}
