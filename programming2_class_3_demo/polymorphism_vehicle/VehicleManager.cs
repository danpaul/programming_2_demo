using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_vehicle
{
    public class VehicleManager
    {

        public void TestDrive(Vehicle vehicle)
        {
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();
        }

        public void ServiceVehicle(IServiceable serviceable)
        {
            serviceable.PerformService();
        }
    }
}
