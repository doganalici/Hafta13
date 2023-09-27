using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek1
{
    
    public class Test : IInfo
    {
        public string Name;
        public int Age;
        public string GetAge()
        {
            return Age.ToString();
        }

        public string GetName()
        {
            return Name;
        }
    }
}
