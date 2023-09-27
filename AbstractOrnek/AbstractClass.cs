using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    public abstract class AbstractClass
    {
        //normal metot
        public int IkiSayiTopla(int x,int y)
        {
            return x + y;
        }

        //abstract metot
        public abstract int IkiSayiCarp(int x, int y);
    }
}
