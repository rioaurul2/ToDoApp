using DesignPatternsPractice.Creational.Factory.Exercitii._2.Interfaces;

namespace DesignPatternsPractice.Creational.Factory.Exercitii._2;

public static class VehicleParkFactory
{
    public static IVehiclePark GetVehicle(VehicleType vehicleType)
    {
        if(vehicleType == VehicleType.Car)
        {
            return new Car();
        }
        else if(vehicleType == VehicleType.Truck)
        {
            return new Truck();
        }
        else
        {
            return new Bike();
        }
    }

    public static IVehiclePark CreateVehicle(VehicleType type)
    {
        return type switch
        {
            VehicleType.Car => new Car(),
            VehicleType.Bike => new Bike(),
            VehicleType.Truck => new Truck(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}
