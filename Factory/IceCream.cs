using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class IceCream : IEatable
    {
        private int _price;
        private string _name;
        public IceCream(string name, int price)
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
            return $"{_name} стоит {_price} рублей";
        }

        public string GetName()
        {
            return _name;
        }
    }
}
