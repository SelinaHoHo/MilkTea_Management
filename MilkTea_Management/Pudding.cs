using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class Pudding: BaseMilkTea
    {
        BaseMilkTea baseMilkTea;
        public Pudding(BaseMilkTea baseMilkTea)
        {
            this.baseMilkTea = baseMilkTea;
        }
        public override string getDescription()
        {
            return baseMilkTea.getDescription() + ", Pudding";
        }
        public override double Price()
        {
            return 1.2;
        }
    }
}
