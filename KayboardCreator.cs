using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Builder
{
    public class KayboardCreator : IComponentCreator
    {
        private Component component;
        public void Create()
        {
            component = new Component("Klawiatóra");
        }

        public Component GetComponent()
        {
            return component;
        }
    }
}

