using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5;

public class Bicycle : TwoWheeledTransport
{
    public Bicycle(int speed) : base(speed)
    {
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Тип транспорту: Велосипед");
        base.ShowInfo();
    }
}
