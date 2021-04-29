using System;

namespace Parrot
{
    public class EuropeanParrot : Parrot
    {
        public EuropeanParrot() : base(ParrotTypeEnum.EUROPEAN,0,0,false)
        {
        }

        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }
}