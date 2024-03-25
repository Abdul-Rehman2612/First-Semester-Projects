using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.BL
{
    internal class Ships
    {
        public string ShipID;
        public string ShipName;
        public string ShipDriver;
        public string ShipDepartureSite;
        public string ShipDestination;
        public List<Passengers> passengers = new List<Passengers>();
        public Ships(string shipID, string shipName, string shipDriver, string shipDepartureSite, string shipDestination)
        {
            ShipID=shipID;
            ShipName=shipName;
            ShipDriver=shipDriver;
            ShipDepartureSite=shipDepartureSite;
            ShipDestination=shipDestination;
        }
        public Ships() { }
        public void AddPassengers(Passengers P)
        {
            passengers.Add(P);
        }
        public void RemovePassenger(int idx)
        {
            passengers.RemoveAt(idx);
        }
        public void UpdateDriverName(string driverName)
        {
            this.ShipDriver = driverName;
        }
        public void UpdateShipName(string shipName)
        {
            this.ShipName=shipName;
        }
        public void UpdateShipDeparture(string departure)
        {
            this.ShipDepartureSite=departure;
        }
        public void UpdateShipDestination(string destination)
        {
            this.ShipDestination=destination;
        }
        public void UpdatePassenger(Passengers P,int idx)
        {
            this.passengers[idx].upadateName(P.PassengerName);
        }
    }
}
