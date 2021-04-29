namespace Parrot
{
    public class NorwegianParrot : Parrot
    {
        public NorwegianParrot(bool isNailed, double voltage) : base(ParrotTypeEnum.NORWEGIAN_BLUE,0,voltage,isNailed)
        {
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage); ;
        }
    }
}