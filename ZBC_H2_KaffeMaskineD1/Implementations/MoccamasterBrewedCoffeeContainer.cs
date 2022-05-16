using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Implementations
{
    public class MoccamasterBrewedCoffeeContainer : ILiquidContainer, IComponentInput
    {
        public float liquidLevel { get; set; }
        public Color color { get; set; }
        public IApplianceComponent Input { get; set; }

        public void AddLiquid()
        {
           
        }

        public void RemoveLiquid()
        {
           
        }

        public void SetInput(IApplianceComponent input)
        {
            this.Input = input;
        }
    }
}
