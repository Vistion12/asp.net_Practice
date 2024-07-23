using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net_Practice
{
    public interface IData
    {
        void SaveData(string name, string action, DateTime time);
    }
}
