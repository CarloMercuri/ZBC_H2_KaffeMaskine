using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    internal interface IComponentOutput
    {
        IApplianceComponent Output { get; set; }
        void SetOutput(IApplianceComponent output);
    }
}
