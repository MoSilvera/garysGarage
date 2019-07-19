using System;
namespace Garys_Garage{
      public class Ram: Vehicle, IGasVehicle {  // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank () {
        Console.WriteLine("Gettin that gas yo!");
    }

    public override void Drive(){
        Console.WriteLine($"The {MainColor} Ram is driving. He doesn't want to say vroom and that is his choice.");
    }
}
}