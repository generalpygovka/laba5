using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Car : Transport
    {
        public Car(int speed, int wheels) : base(speed, wheels)
        {
            ExistingDoors = true;
            OpenedDoors = "Locked";
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Тип: Автомобіль");
            Console.WriteLine($"Швидкість: {Speed}");
            Console.WriteLine($"Кількість колес: {Wheels}");
            Console.WriteLine($"Двері: {OpenedDoors}");
        }
    }
}
