using System;
using System.Collections.Generic;

namespace Garys_Garage{
    public class BatteryStation: IRefillStation<IElectricVehicle>{
        public int Capacity {get; set;} = 2000;

        public void Refuel(List <IElectricVehicle> electricVehicles){

               electricVehicles.ForEach(vehicle => vehicle.ChargeBattery());


        }
    }
}