using System;
using System.Collections.Generic;
using System.Text;

namespace DesginPattern
{
    class FactoryOld:Factory
    {
        public override Car MadeCar()
        {
            return new OldCar();
        }
    }
}
