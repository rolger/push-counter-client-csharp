using System;

namespace Parrot
{
    internal class EuropeanParrot : Parrot
    {
        public EuropeanParrot() : base(ParrotTypeEnum.EUROPEAN,0,0,false)
        {
        }

        internal double GetBaseSpeed()
        {
            return base.GetBaseSpeed();
        }
    }
}