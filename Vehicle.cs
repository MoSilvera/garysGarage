using System;
namespace Garys_Garage{
        public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive(){
        Console.WriteLine("Vroom");
    }

    public void Turn(string direction){
        Console.WriteLine($"The vehicle is turning {direction}");
    }
    public virtual void Stop(){
        Console.WriteLine("Look, it stopped!");
    }
}
}