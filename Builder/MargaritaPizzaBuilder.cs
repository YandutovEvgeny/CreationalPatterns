using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MargaritaPizzaBuilder : BuilderClass
    {
        public MargaritaPizzaBuilder() : base("тонкой", "4 видами сыра")
        {
            SetTomato();
            SetSausage();
            SetBacon();
        }
    }
}
