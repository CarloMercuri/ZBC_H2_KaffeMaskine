using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    public interface ILiquidContainer : IApplianceComponent
    {
        float liquidLevel { get; set; }
        Color color { get; set; }
        void AddLiquid();
        void RemoveLiquid();
    }
}
