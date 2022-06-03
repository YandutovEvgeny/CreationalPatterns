using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Pizza
    {
        public string Base { get; set; }    //Основа
        public string Cheese { get; set; }
        public bool Pineapple { get; set; }
        public bool Tomato { get; set; }
        public bool Sausage { get; set; }
        public bool Bacon { get; set; }

        public string GetInfo()
        {
            string result = $"Пицца на {Base} основе с сыром {Cheese}\nСостав:\n";
            if (Pineapple) result += "Ананасы\n";
            if (Tomato) result += "Помидоры\n";
            if (Sausage) result += "Колбаса\n";
            if (Bacon) result += "Бекон\n";
            return result;
        }
    }
}
