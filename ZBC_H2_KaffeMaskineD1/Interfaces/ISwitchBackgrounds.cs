using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    internal interface ISwitchBackgrounds
    {
        string OnPicture { get; set; } 
        string OffPicture { get; set; } 
    }
}
