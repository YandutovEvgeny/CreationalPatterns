using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PineapplePizzaBuilder : BuilderClass
    {
        public PineapplePizzaBuilder() : base("Толстое тесто с сырными бортиками", "Фета")
        {
            SetPineapple();
        }
    }
}
