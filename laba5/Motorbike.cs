using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Motorbike : TwoWheeledTransport
    {
        public Motorbike(int speed, int wheels) : base(speed, wheels)
        {
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Тип транспорту: Мотоцикл");
            Console.WriteLine($"Швидкість: {Speed}");
            Console.WriteLine($"Кількість колес: {Wheels}");
        }
    }
}
