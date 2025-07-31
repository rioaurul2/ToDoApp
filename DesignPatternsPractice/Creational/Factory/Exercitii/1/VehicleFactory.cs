using DesignPatternsPractice.Creational.Factory.Exercitii._1.Interface;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._1;

public static class VehicleFactory
{
    public static IVehicle CreateVehicle(string vehicleType)
    {
        if (vehicleType == "Car")
            return new Car();
        else if (vehicleType == "Truck")
            return new Truck();
        else
            throw new ArgumentException("Unknown vehicle type");
    }
}
