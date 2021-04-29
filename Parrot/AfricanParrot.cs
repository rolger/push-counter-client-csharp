using System;

namespace Parrot
{
    public class AfricanParrot : Parrot
    {
        public AfricanParrot(int numberOfCoconuts) : base(ParrotTypeEnum.AFRICAN, numberOfCoconuts, 0, false)
        {

        }

        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }
    }
}