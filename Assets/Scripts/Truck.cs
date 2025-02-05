using UnityEngine;

//INHERITANCE
public class Truck : Vehicle
{
    public float PayloadCapacity { get; set; } //in kg
    public bool IsFourWheelDrive { get; set; }

    //POLYMORPHISM
    public override void DisplayInfo() //POLYMORPHISM
    {
        Debug.Log($"Truck Info: {Make} {Model}, Year: {Year}, Color: {Color}, Payload Capacity: {PayloadCapacity}kg, Four-Wheel Drive: {(IsFourWheelDrive ? "Yes" : "No")}");
    }

    public override void StartVehicle() //POLYMORPHISM
    {
        Debug.Log($"Starting the truck: {Make} {Model}");
    }

    public override void StopVehicle() //POLYMORPHISM
    {
        Debug.Log($"Stopping the truck: {Make} {Model}");
    }
}
