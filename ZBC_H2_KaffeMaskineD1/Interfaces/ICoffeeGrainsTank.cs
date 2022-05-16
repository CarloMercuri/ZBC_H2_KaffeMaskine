using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Interfaces
{
    internal interface ICoffeeGrainsTank : ISolidsContainer
    {
        float CoffeeQuantity { get; set; }

        void AddCoffeeGrains();
        void RemoveCoffeeGrains();
    }
}
