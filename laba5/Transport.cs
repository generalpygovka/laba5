using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5;

public abstract class Transport
{
    public bool ExistingDoors { get; set; }
    private string openedDoors;
    public string OpenedDoors
    {
        get
        {
            if (!ExistingDoors)
            {
                openedDoors = "No doors";
            }
            else openedDoors = "Locked";

            return openedDoors;
        }
        set { openedDoors = value; }
    }
    public int Speed { get; set; }
    public int Wheels { get; set; }
    public Transport(int speed)
    {
        Speed = speed;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Швидкість: {Speed} км/год");
        Console.WriteLine($"Кількість колес: {Wheels}");
        Console.WriteLine($"Двері: {OpenedDoors}");
    }
}
