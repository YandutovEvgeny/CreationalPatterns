using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Menu
    {
        public List<IEatable> MyMenu { get; set; }

        public Menu()
        {
            MyMenu = new List<IEatable>()
            {
                new IceCream("Вафельный рожок", 20),
                new IceCream("Эскимо", 30),
                new IceCream("Крем-брюле", 35),
                new Water("Coca-Cola", 80, 0.5),
                new Water("Borgomi", 150, 1),
                new Burger("Двойной чизбургер", 150),
                new Burger("Чикен бекон", 120),
                new Burger("Гамбургер", 100)
            };
        }
    }
}
