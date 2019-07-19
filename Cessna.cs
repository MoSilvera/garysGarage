using System;
namespace Garys_Garage{
    public class Cessna: Vehicle, IGasVehicle {  // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public override void Drive(){
        Console.WriteLine($"I, the {MainColor} Cessna, am flying bitches!"); 
    }

    public void RefuelTank () {
        Console.WriteLine("Fueling up the plane...don't know how you do that but here we are");
     }

    public override void Stop(){
        Console.WriteLine($"Oh look the {MainColor} Cessa is stopping....I hope its on the gound. 'Cause it's a plane, ya know?");
    }
}
}