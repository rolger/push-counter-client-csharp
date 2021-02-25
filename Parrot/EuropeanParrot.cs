using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
    class EuropeanParrot : Parrot
    {
        public EuropeanParrot(int numberOfCoconuts, double voltage, bool isNailed) 
            : base(ParrotTypeEnum.EUROPEAN, numberOfCoconuts, voltage, isNailed)
        {
        }
    }
}