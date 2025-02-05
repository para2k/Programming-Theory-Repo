using System;
using UnityEngine;

//Base class
public abstract class Vehicle : MonoBehaviour
{
    private string make;
    private string model;
    private int year;
    private Color color;

    //Properties with encapsulation
    public string Make { get => make; set => make = value; }
    public string Model { get => model; set => model = value; }
    public int Year { get => year; set {
        //First automobile was invented in 1886
        if(value > 1885) {
            year = value;
        }
        else {
            throw new ArgumentException("Year must be greater than 1885");
        }
    } }
    public Color Color { get => color; set => color = value; }

    //Abstract methods for polymorphism
    public abstract void Start();
    public abstract void Stop();
    public abstract void DisplayInfo();
}
