using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    [Serializable] //Разрешает сериализовать(из объекта в поток) класс
    class Prototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Home { get; set; }
        public string Work { get; set; }
        public Data BirthDay { get; set; }

        public string GetInfo()
        {
            return $"{Name}: {Age} лет \nЖивёт по адресу {Home}\nРаботает по адресу {Work}\nДата выдачи паспорта" +
                $"{BirthDay.Day}.{BirthDay.Month}.{BirthDay.Year}";
        }
        public Prototype Clone()
        {
            Prototype result = new Prototype() { Name = Name, Age = Age, Home = Home, Work = Work, BirthDay = BirthDay.Clone() };
            return result;
        }
    }
}
