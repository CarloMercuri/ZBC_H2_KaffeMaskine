using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Implementations
{
    public class MoccamasterCoffeeHolder : ISolidsContainer, IComponentInput, IComponentOutput
    {
        public float SolidsQuantity { get; set; }
        public IApplianceComponent Input { get; set; }
        public IApplianceComponent Output { get; set; }
        public ISolidsFilter Filter { get; set; }

        public MoccamasterCoffeeHolder()
        {
        }

        public void SetInput(IApplianceComponent input)
        {
            this.Input = input;
        }

        public void SetOutput(IApplianceComponent output)
        {
            this.Output = output;
        }

        public void AddCoffeeGrains()
        {
            
        }

        public void AddSolids()
        {
           
        }

        public void RemoveCoffeeGrains()
        {
           
        }

        public void RemoveSolids()
        {
           
        }

        public void AddFilter(ISolidsFilter filter)
        {
            this.Filter = filter;
        }

        public void RemoveFilter()
        {
            this.Filter = null;
        }
    }
}
