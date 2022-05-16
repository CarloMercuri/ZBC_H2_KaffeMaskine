using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_KaffeMaskineD1.Abstracts
{
    public abstract class KitchenAppliance
    {
        int width;
        int height;
        int depth;
        int consumptionClass;

        public void SetDimensions(int width, int height, int depth, int consumptionClass)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.consumptionClass = consumptionClass;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetDepth()
        {
            return depth;
        }

        public int GetConsumptionClass()
        {
            return consumptionClass;
        }
    }
}
