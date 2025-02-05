using System.Collections.Generic;
using UnityEngine;

public class VehicleManager : MonoBehaviour
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    void Start()
    {
        Debug.Log("Vehicle Manager started.");
        // Create vehicles using the helper method
        CreateVehicle<Car>("Toyota", "Camry", 2022, Color.blue, 4, 500f);
        CreateVehicle<Truck>("Ford", "F-150", 2023, Color.red, 1000f, true);
        CreateVehicle<Motorcycle>("Harley-Davidson", "Street 750", 2021, Color.black, false);

        // Demonstrate vehicle behaviors
        foreach (var vehicle in vehicles)
        {
            vehicle.StartVehicle();
            vehicle.DisplayInfo();
            vehicle.StopVehicle();
        }
    }

    private void CreateVehicle<T>(string make, string model, int year, Color color, params object[] additionalParams) where T : Vehicle
    {
        T vehicle = gameObject.AddComponent<T>();
        vehicle.Make = make;
        vehicle.Model = model;
        vehicle.Year = year;
        vehicle.Color = color;

        // Set additional parameters based on the type of vehicle
        if (vehicle is Car car)
        {
            car.NumberOfDoors = (int)additionalParams[0];
            car.TrunkCapacity = (float)additionalParams[1];
        }
        else if (vehicle is Truck truck)
        {
            truck.PayloadCapacity = (float)additionalParams[0];
            truck.IsFourWheelDrive = (bool)additionalParams[1];
        }
        else if (vehicle is Motorcycle motorcycle)
        {
            motorcycle.HasSidecar = (bool)additionalParams[0];
        }

        // Add the newly created vehicle to the list
        vehicles.Add(vehicle);
    }
}
