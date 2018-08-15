using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Builder
{
    public class MauseCreator : IComponentCreator
    {
        private Component component;
        public void Create()
        {
            component = new Component("Myszka");
        }

        public Component GetComponent()
        {
            return component;
        }
    }
}
