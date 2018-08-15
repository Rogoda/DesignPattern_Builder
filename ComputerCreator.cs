using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Builder
{
    public class ComputerCreator : IComponentCreator
    {
        private Component component;

        public void Create()
        {
            component = new Component("Komputer");
        }

        public Component GetComponent()
        {
            return component;
        }
    }
}
