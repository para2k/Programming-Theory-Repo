using System.Collections.Generic;
using UnityEngine;

public class VehicleManager : MonoBehaviour
{
    List<Vehicle> vehicles = new List<Vehicle>();
    
    void Start()
    {
        Car myCar = gameObject.AddComponent<Car>();
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2022;
        myCar.Color = Color.blue;
        myCar.NumberOfDoors = 4;
        myCar.TrunkCapacity = 500f;

        Truck myTruck = gameObject.AddComponent<Truck>();
        myTruck.Make = "Ford";
        myTruck.Model = "F-150";
        myTruck.Year = 2023;
        myTruck.Color = Color.red;
        myTruck.PayloadCapacity = 1000f;
        myTruck.IsFourWheelDrive = true;

        Motorcycle myMotorcycle = gameObject.AddComponent<Motorcycle>();
        myMotorcycle.Make = "Harley-Davidson";
        myMotorcycle.Model = "Street 750";
        myMotorcycle.Year = 2021;
        myMotorcycle.Color = Color.black;
        myMotorcycle.HasSidecar = false;

        // Add vehicles to list
        vehicles.Add(myCar);
        vehicles.Add(myTruck);
        vehicles.Add(myMotorcycle);

        // Demonstrate vehicle behaviors
        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.DisplayInfo();
            vehicle.Stop();
            Debug.Log("");
        }
    }
}
