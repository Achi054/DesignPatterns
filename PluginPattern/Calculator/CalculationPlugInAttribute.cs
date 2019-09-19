using System;

namespace Calculator
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CalculationPlugInAttribute : Attribute
    {
        public CalculationPlugInAttribute(string description)
        {
            this.Description = description;
        }

        public string Description { get; private set; }
    }
}
