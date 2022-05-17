using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Abstracts
{
    public class DripperMachine : KitchenAppliance
    {
        IApplianceComponent waterTank;
        IApplianceComponent solidsHolder;
        IApplianceComponent preparedTank;

        public DripperMachine(IApplianceComponent waterTank, IApplianceComponent solidsHolder, IApplianceComponent preparedTank)
        {
            this.waterTank = waterTank;
            this.solidsHolder = solidsHolder;
            this.preparedTank = preparedTank;
        }

        public void ChangeWaterTank(IApplianceComponent tank)
        {
            this.waterTank = tank;
        }

        public void ChangeSolidsHolder(IApplianceComponent solids)
        {
            this.solidsHolder = solids;
        }

        public void ChangePreparedTank(IApplianceComponent prepared)
        {
            this.preparedTank = prepared;
        }

        public void AddSolids()
        {

        }

        public void AddWater()
        {

        }
    }
}
