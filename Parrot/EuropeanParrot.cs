using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
    class EuropeanParrot : Parrot
    {
        public EuropeanParrot()
            : base(ParrotTypeEnum.EUROPEAN, 0, 0, false)
        {
        }

        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }
}