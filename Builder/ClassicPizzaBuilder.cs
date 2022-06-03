using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ClassicPizzaBuilder : BuilderClass
    {
        public ClassicPizzaBuilder() : base("тонкой", "чеддер")
        {
            SetTomato();
            SetSausage();
        }
    }
}
