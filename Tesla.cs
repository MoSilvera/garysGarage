using System;
namespace Garys_Garage{
    public class Tesla: Vehicle, IElectricVehicle {  // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery () {
        Console.WriteLine("Look at that Tesla charge");
    }

    public override void Drive(){
        Console.WriteLine($"The {MainColor} Tesla is driving. He with absolutely not say vroom because he is bougie AF");
    }
}
}