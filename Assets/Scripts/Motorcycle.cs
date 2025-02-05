using UnityEngine;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void DisplayInfo()
    {
        Debug.Log($"Motorcycle Info: {Make} {Model}, Year: {Year}, Color: {Color}, Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
    }

    public override void Start()
    {
        Debug.Log($"Starting the motorcycle: {Make} {Model}");
    }

    public override void Stop()
    {
        Debug.Log($"Stopping the motorcycle: {Make} {Model}");
    }
}
