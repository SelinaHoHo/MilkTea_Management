using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class Flan: BaseMilkTea
    {
        BaseMilkTea baseMilkTea;
        public Flan(BaseMilkTea baseMilkTea)
        {
            this.baseMilkTea = baseMilkTea;
        }
        public override string getDescription()
        {
            return baseMilkTea.getDescription() + ", Flan";
        }
        public override double Price()
        {
            return  1.5;
        }
    }
}
