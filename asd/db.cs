using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    class db
    {
        static zxcEntities inst;
        public static zxcEntities Instance { get { if (inst == null) inst = new zxcEntities(); return inst; } }
    }
}
