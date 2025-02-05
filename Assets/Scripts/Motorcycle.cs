using UnityEngine;

//INHERITANCE
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    //POLYMORPHISM
    public override void DisplayInfo() //POLYMORPHISM
    {
        Debug.Log($"Motorcycle Info: {Make} {Model}, Year: {Year}, Color: {Color}, Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
    }

    public override void StartVehicle() //POLYMORPHISM
    {
        Debug.Log($"Starting the motorcycle: {Make} {Model}");
    }

    public override void StopVehicle() //POLYMORPHISM
    {
        Debug.Log($"Stopping the motorcycle: {Make} {Model}");
    }
}
