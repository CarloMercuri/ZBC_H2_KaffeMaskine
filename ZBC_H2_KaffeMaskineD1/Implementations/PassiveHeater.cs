using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_KaffeMaskineD1.Interfaces;

namespace ZBC_H2_KaffeMaskineD1.Implementations
{
    public class PassiveHeater : IApplianceHeater, IComponentInput, IComponentOutput
    {
        public bool currentFlow { get; set; }
        public IApplianceComponent Input { get; set; }
        public IApplianceComponent Output { get; set; }


        public void ActivateCurrentFlow()
        {
            currentFlow = true;
        }

        public void DeactivateCurrentFlow()
        {
            currentFlow = false;
        }

        public void SetInput(IApplianceComponent input)
        {
            this.Input = input;
        }

        public void SetOutput(IApplianceComponent output)
        {
            this.Output = output;
        }
    }
}
