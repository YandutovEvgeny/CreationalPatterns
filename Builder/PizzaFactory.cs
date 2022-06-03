using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PizzaFactory
    {
        public List<BuilderClass> Cooks { get; set; }

        public PizzaFactory()
        {
            Cooks = new List<BuilderClass>()
            {
                new ClassicPizzaBuilder(),
                new PineapplePizzaBuilder(),
                new MargaritaPizzaBuilder()
            };
        }

        public Pizza GetPizza(int num)
        {
            if(num == -1)
            {
                Pizza pizza = new Pizza();
                pizza.Base = "тонкое тесто";
                pizza.Cheese = "4 вида сыра";
                pizza.Bacon = true;
                pizza.Sausage = true;
                return pizza;
            }
            return Cooks[num].GetPizza();
        }
    }
}
