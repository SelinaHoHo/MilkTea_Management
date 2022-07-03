using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class BlackPearl: BaseMilkTea
    {
        BaseMilkTea baseMilkTea;
        public BlackPearl(BaseMilkTea baseMilkTea)
        {
            this.baseMilkTea = baseMilkTea;
        }
        public override string getDescription()
        {
            return baseMilkTea.getDescription() + ", Black Pearl";
        }
        public override double Price()
        {
            return 1;
        }
    }
}
