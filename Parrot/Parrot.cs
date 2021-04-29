using System;

namespace Parrot
{
    public class Parrot : IParrot
    {
        protected readonly bool _isNailed;
        protected readonly int _numberOfCoconuts;
        private readonly ParrotTypeEnum _type;
        protected readonly double _voltage;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public static EuropeanParrot EuropeanParrot()
        {
            return new EuropeanParrot();
        }

        public static AfricanParrot AfricanParrot(int numberOfCoconuts)
        {
            return new AfricanParrot(numberOfCoconuts);
        }

        public virtual double GetSpeed()
        {
            switch (_type)
            {
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianParrot(_isNailed, _voltage).GetSpeed();
            }

            throw new Exception("Should be unreachable");
        }

        protected double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        protected double GetLoadFactor()
        {
            return 9.0;
        }

        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}