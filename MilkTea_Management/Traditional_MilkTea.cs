using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class Traditional_MilkTea: BaseMilkTea
    {
        public Traditional_MilkTea()
        {
            description = "Traditional Milk Tea";
        }
        public override double Price()
        {
            return 5;
        }
    }
}
