using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Burger : IEatable
    {
        string _name;
        int _price;
        public Burger(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string Eat()
        {
            return $"Вы съели {_name}";
        }

        public string GetInfo()
        {
            return $"{_name} стоит {_price}";
        }

        public string GetName()
        {
            return _name;
        }
    }
}
