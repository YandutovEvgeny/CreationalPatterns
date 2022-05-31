using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns
{
    class Clonator3000cs
    {
        public object Clone(object obj)
        {
            object clone = null;    //То куда мы клонируем
            //Используем поток
            MemoryStream memoryStream = new MemoryStream();
            //Флажочек, который означает клонирование
            StreamingContext context = new StreamingContext(StreamingContextStates.Clone);
            //Класс, который позволяет нам сериализовать объект
            BinaryFormatter binaryFormatter = new BinaryFormatter(null, context);
            //Сериализуем объект (из объекта в поток)
            binaryFormatter.Serialize(memoryStream, obj);
            //Перетаскиваем курсор в начало, копиуем сначала
            memoryStream.Seek(0, SeekOrigin.Begin);
            //Десереализуем поток в объект
            clone = binaryFormatter.Deserialize(memoryStream);
            return clone;
        }
    }
}
