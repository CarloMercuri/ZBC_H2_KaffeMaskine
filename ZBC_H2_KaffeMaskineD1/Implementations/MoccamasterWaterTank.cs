using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Implementations
{
    public class MoccamasterWaterTank : ILiquidContainer, IComponentOutput
    {
        public bool Transparent { get; set; }
        public float liquidLevel { get; set; }
        public Color color { get; set; }
        public IApplianceComponent Output { get; set; }

        public MoccamasterWaterTank()
        {
            
        }

        public void SetOutput(IApplianceComponent output)
        {
            Output = output;
        }

        public void AddLiquid()
        {
            
        }

        public void RemoveLiquid()
        {
            
        }
    }
}
