using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Train : Transport
    {
        public Train(int speed, int wheels) : base(speed, wheels)
        {
            ExistingDoors = true;
            OpenedDoors = "Locked";
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Тип: Поїзд");
            Console.WriteLine($"Швидкість: {Speed}");
            Console.WriteLine($"Кількість колес: {Wheels}");
            Console.WriteLine($"Двері: {OpenedDoors}");
        }
    }
}