using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public abstract class Transport
    {
        public bool ExistingDoors { get; set; }
        private string openedDoors;
        public string OpenedDoors
        {
            get { return openedDoors; }
            set {
                if (!ExistingDoors)
                {
                    openedDoors = "No doors";
                }else
                openedDoors = value; }
        }
        public int Speed { get; set; }
        public int Wheels { get; set; }
        public Transport( int speed, int wheels)
        {
            Speed = speed;
            Wheels = wheels;
        }
        public abstract void ShowInfo();
    }
}
