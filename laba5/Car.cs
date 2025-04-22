using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5;

public class Car : Transport
{
    public Car(int speed) : base(speed)
    {
        ExistingDoors = true;
        Wheels = 4;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Тип: Автомобіль");
        base.ShowInfo();
    }
}
