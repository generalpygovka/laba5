using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5;

public class Moped : TwoWheeledTransport
{
    public Moped(int speed) : base(speed)
    {
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"Тип транспорту: Мопед");
        base.ShowInfo();
    }
}
