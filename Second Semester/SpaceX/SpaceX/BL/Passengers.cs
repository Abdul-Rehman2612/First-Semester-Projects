using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.BL
{
    internal class Passengers
    {
        public string PassengerID;
        public string PassengerName;
        public Passengers()
        {
        }
        public void upadateName(string name)
        {
            PassengerName = name;
        }
    }
}
