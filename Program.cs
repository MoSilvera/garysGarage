using System;
using System.Collections.Generic;

namespace Garys_Garage
{

    class Program
    {
        static void Main(string[] args)
        {

           Ram BlueRam = new Ram(){
               MainColor = "blue",
               FuelCapacity = 10,
               MaximumOccupancy = 6,
           };

            Tesla RedTesla = new Tesla(){
                MainColor = "Red",
                BatteryKWh = 20,
                MaximumOccupancy = 4,
            };

            Zero GreenZero = new Zero(){
                MainColor = "Green",
                BatteryKWh = 40,
                MaximumOccupancy = 3,
            };

            Cessna PurpleCessna = new Cessna(){
                MainColor = "Purple",
                FuelCapacity = 50,
                MaximumOccupancy = 2,
            };

            // PurpleCessna.Drive();
            // PurpleCessna.Stop();
            // PurpleCessna.Turn("left");
            // GreenZero.Drive();
            // GreenZero.Stop();
            // GreenZero.Turn("right");
            // GreenZero.Stop();
            // RedTesla.Drive();
            // RedTesla.Stop();
            // RedTesla.Turn("left");
            // BlueRam.Drive();
            // BlueRam.Turn("right");
            // BlueRam.Stop();
        List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>(){
            RedTesla,
            GreenZero
        };

        List<IGasVehicle> gasVehicles = new List<IGasVehicle>(){
            BlueRam,
            PurpleCessna
        };

        new BatteryStation().Refuel(electricVehicles);
        new GasStation().Refuel(gasVehicles);


        }
    }
}
