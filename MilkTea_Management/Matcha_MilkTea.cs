using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class Matcha_MilkTea: BaseMilkTea
    {
        public Matcha_MilkTea()
        {
            description = "Matcha Milk Tea";
        }
        public override double Price()
        {
            return 6;
        }
    }
}
