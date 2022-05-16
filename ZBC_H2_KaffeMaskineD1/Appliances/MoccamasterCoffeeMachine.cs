using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Abstracts;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Appliances
{
    public class MoccamasterCoffeeMachine : DripperMachine
    {
        IApplianceComponent OnOffSwitch;
        IApplianceComponent BottomHeater;
        IApplianceComponent HeatLevelSwitch;
        string Model;
        string Color;        

        public MoccamasterCoffeeMachine(IApplianceComponent bottomHeater, IApplianceComponent waterTank, IApplianceComponent coffeeHolder, IApplianceComponent onOffSwitch, IApplianceComponent heatLevelSwitch, IApplianceComponent preparationTank) : base(waterTank, coffeeHolder, preparationTank)
        {
            SetDimensions(24, 30, 18, 2);
            Model = "Moccamaster X-Treme 101";
            Color = "Black";
            this.OnOffSwitch = onOffSwitch;
            this.BottomHeater = bottomHeater;
            this.HeatLevelSwitch = heatLevelSwitch;
        }

        public void SelectFullHeating()
        {

        }

        public void SelectHalfHeating()
        {

        }

        public void TurnOn()
        {
            if(BottomHeater is IApplianceHeater)
            {
                IApplianceHeater applianceHeater = (IApplianceHeater)BottomHeater;
                applianceHeater.ActivateCurrentFlow();
            }
        }

        public void TurnOff()
        {
            if (BottomHeater is IApplianceHeater)
            {
                IApplianceHeater applianceHeater = (IApplianceHeater)BottomHeater;
                applianceHeater.DeactivateCurrentFlow();
            }
        }

    }
}
