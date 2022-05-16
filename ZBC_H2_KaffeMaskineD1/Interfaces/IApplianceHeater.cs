using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    internal interface IApplianceHeater : IApplianceComponent
    {
        bool currentFlow { get; set; }
        void ActivateCurrentFlow();
        void DeactivateCurrentFlow();
    }
}
