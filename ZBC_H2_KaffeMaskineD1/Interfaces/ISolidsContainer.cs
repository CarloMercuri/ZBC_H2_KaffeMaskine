using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    internal interface ISolidsContainer : IApplianceComponent
    {
        float SolidsQuantity { get; set; }
        void AddSolids();
        void RemoveSolids();
        void AddFilter(ISolidsFilter filter);
        void RemoveFilter();
    }
}
