using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOrnek1
{
    public class Test
    {
        public int normal;
        public static int statik=0;

        public Test()
        {
            statik++;

        }
    }
}
