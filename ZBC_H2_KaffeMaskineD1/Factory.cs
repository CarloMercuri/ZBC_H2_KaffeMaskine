using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Appliances;
using ZBC_H2_KaffeMaskineD1.Implementations;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1
{
    public class Factory
    {
        public MoccamasterCoffeeMachine CreateMoccaMasterCoffeeMachine()
        {
            IApplianceComponent waterTank = new MoccamasterWaterTank();
            
            IApplianceComponent coffeeHolder = new MoccamasterCoffeeHolder();
            
            IApplianceComponent bottomHeater = new PassiveHeater();
            IApplianceComponent onOffSwitch = new MoccamasterOnSwitch();
            IApplianceComponent heatLevelSwitch = new MoccamasterHeatLevelSwitch();
            IApplianceComponent finishedCoffee = new MoccamasterBrewedCoffeeContainer();

            if (waterTank is IComponentOutput) ((IComponentOutput)waterTank).SetOutput(bottomHeater);

            if (coffeeHolder is IComponentOutput) ((IComponentOutput)coffeeHolder).SetOutput(finishedCoffee); 
            if (coffeeHolder is IComponentInput) ((IComponentInput)coffeeHolder).SetInput(bottomHeater);

            if (bottomHeater is IComponentInput) ((IComponentInput)bottomHeater).SetInput(waterTank);
            if (bottomHeater is IComponentOutput) ((IComponentOutput)bottomHeater).SetOutput(coffeeHolder);

            if (finishedCoffee is IComponentInput) ((IComponentInput)finishedCoffee).SetInput(coffeeHolder);

            MoccamasterCoffeeMachine coffeeMachine = new MoccamasterCoffeeMachine(bottomHeater, waterTank, coffeeHolder, onOffSwitch, heatLevelSwitch, finishedCoffee);
            return coffeeMachine;
        }
    }
}
