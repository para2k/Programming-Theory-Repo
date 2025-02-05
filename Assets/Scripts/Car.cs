using UnityEngine;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public float TrunkCapacity { get; set; } //in liters

    public override void DisplayInfo()
    {
        Debug.Log($"Car Info: {Make} {Model}, Year: {Year}, Color: {Color}, Number of Doors: {NumberOfDoors}, Trunk Capacity: {TrunkCapacity}");
    }

    public override void Start()
    {
        Debug.Log($"Starting the car: {Make} {Model}");
    }

    public override void Stop()
    {
        Debug.Log($"Stopping the car: {Make} {Model}");
    }
}
