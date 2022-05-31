using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    [Serializable]
    class Singletone
    {
        static Singletone _singletone;
        int _count;
        private Singletone()
        {
            _count = 0;
        }

        static public Singletone GetObject()
        {
            if (_singletone == null)
                _singletone = new Singletone();
            return _singletone;
        }
        public int GetCount()
        {
            return _count++;
        }
        public int GetCount1()
        {
            return --_count;
        }

    }
}
