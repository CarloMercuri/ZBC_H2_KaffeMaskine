using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    internal interface ISwitch : IApplianceComponent
    {
        bool TurnedOn { get; set; }
        Color Backgroundcolor { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
