using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace srv
{
    class wurfel
    {
        wurfel() { }
        public int getwurf()
        { 
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }
    }
}
