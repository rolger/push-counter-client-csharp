using System;

namespace Parrot
{
    public class EuropeanParrot : Parrot
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