using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek1
{
    class Detay : IInfo
    {

        public string FirstName;
        public string LastName;
        public int Age;


        public string GetAge()
        {
            return Age.ToString();
        }

        public string GetName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }
    }
}
