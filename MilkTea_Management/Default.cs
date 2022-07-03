using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class Default: BaseMilkTea
    {
        public Default()
        {
            description = "None";
        }
        public override double Price()
        {
            return 0;
        }
    }
}
