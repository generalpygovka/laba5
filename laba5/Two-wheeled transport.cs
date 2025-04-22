using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5;

public abstract class TwoWheeledTransport : Transport
{
    public TwoWheeledTransport(int speed) : base(speed)
    {
        ExistingDoors = false;
        Wheels = 2;
    }

}
