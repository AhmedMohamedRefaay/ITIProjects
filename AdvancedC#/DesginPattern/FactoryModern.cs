using System;
using System.Collections.Generic;
using System.Text;

namespace DesginPattern
{
    class FactoryModern:Factory
    {
        public override Car MadeCar()
        {
            return new ModernCar();
        }

    }
}
