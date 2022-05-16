﻿using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Implementations
{
    public abstract class CoffeeFilter : ISolidsFilter
    {
        private float HoleSize { get; set; }

        public CoffeeFilter()
        {
            this.HoleSize = 16;
        }
    }
}
