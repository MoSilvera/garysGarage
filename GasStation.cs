using System;
using System.Collections.Generic;

namespace Garys_Garage{
    public class GasStation: IRefillStation<IGasVehicle>{
        public int Capacity {get; set;} = 2000;

        public void Refuel(List <IGasVehicle> gasvehicles){
            gasvehicles.ForEach(vehicle => vehicle.RefuelTank());

        }
    }
}