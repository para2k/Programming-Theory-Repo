using UnityEngine;

public class Truck : Vehicle
{
    public float PayloadCapacity { get; set; } //in kg
    public bool IsFourWheelDrive { get; set; }

    public override void DisplayInfo()
    {
        Debug.Log($"Truck Info: {Make} {Model}, Year: {Year}, Color: {Color}, Payload Capacity: {PayloadCapacity}kg, Four-Wheel Drive: {(IsFourWheelDrive ? "Yes" : "No")}");
    }

    public override void Start()
    {
        Debug.Log($"Starting the truck: {Make} {Model}");
    }

    public override void Stop()
    {
        Debug.Log($"Stopping the truck: {Make} {Model}");
    }
}
