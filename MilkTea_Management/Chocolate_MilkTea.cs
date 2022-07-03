using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class Chocolate_MilkTea: BaseMilkTea
    {
        public Chocolate_MilkTea()
        {
            description = "Chocolate Milk Tea";
        }
        public override double Price()
        {
            return 6.5;
        }
    }
}
