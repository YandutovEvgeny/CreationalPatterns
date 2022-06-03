using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IEatable
    {
        string GetInfo();
        string Eat();
        string GetName();
    }
}
