using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mime;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Implementations
{
    public class MoccamasterOnSwitch : ISwitch, ISwitchBackgrounds
    {
        public bool TurnedOn { get; set; }
        public Color Backgroundcolor { get; set; }
        public string OnPicture { get; set; }
        public string OffPicture { get; set; }

        public void TurnOff()
        {
           
        }

        public void TurnOn()
        {
            
        }
    }
}
