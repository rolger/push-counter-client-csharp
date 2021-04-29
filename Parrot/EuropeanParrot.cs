using System;

namespace Parrot
{
    internal class EuropeanParrot : Parrot
    {
        public EuropeanParrot() : base(ParrotTypeEnum.EUROPEAN,0,0,false)
        {
        }

        public double GetSpeed()
        {
            return base.GetBaseSpeed();
        }

        internal double GetBaseSpeed()
        {
            return base.GetBaseSpeed();
        }
    }
}