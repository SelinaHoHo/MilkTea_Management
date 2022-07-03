using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    abstract class BaseMilkTea
    {
        protected string description = "Milk Tea";
        
        public virtual string getDescription()
        {
            return description;
        }
        public abstract double Price();
    }
}
