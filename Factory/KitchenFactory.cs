using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class KitchenFactory
    {
        Menu menu;

        public KitchenFactory()
        {
            menu = new Menu();
        }

        public IEatable GetEat(int num)
        {
            //Выражение в subscript operator нужно для того, чтобы мы не могли "выйти" за пределы списка
            //то есть, если в списке 5 объектов, то мы не сможем выбрать 6
            return menu.MyMenu[num % menu.MyMenu.Count];
        }
    }
}
