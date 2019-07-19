using System.Collections.Generic;

namespace Garys_Garage{
    public interface IRefillStation <T>
    {
        int Capacity {get; set;}
        void Refuel(List<T> vehicles);
    }
}