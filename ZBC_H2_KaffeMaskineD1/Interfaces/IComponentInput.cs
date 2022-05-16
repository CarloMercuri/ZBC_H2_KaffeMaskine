using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    internal interface IComponentInput
    {
        IApplianceComponent Input { get; set; }
        void SetInput(IApplianceComponent input);
    }
}
