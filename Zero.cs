using System;
namespace Garys_Garage{

    public class Zero: Vehicle, IElectricVehicle {  // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void ChargeBattery () {
        Console.WriteLine("The Battery is charging");
     }

    public override void Drive(){
        Console.WriteLine($"The {MainColor} Zero is driving. I always though zero was a Candy Bar");
    }
}
}