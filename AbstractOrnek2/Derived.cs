using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek2
{
    public class Derived : BaseClass
    {
        public override int X => _x + 10;

        public override int Y => _y + 10;

        public override void AbstractMetot()
        {
            _x++;
            _y++;
        }
    }
}
