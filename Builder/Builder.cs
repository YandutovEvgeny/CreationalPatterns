using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class BuilderClass
    {
        Pizza pizza;

        public BuilderClass(string Base, string Cheese)
        {
            pizza = new Pizza();
            pizza.Base = Base;
            pizza.Cheese = Cheese;
        }

        protected void SetBacon()
        {
            pizza.Bacon = true;
        }
        protected void SetPineapple()
        {
            pizza.Pineapple = true;
        }
        protected void SetTomato()
        {
            pizza.Tomato = true;
        }
        protected void SetSausage()
        {
            pizza.Sausage = true;
        }
        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
