using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Builder
{
    public class Salesman
    {
        public List<IComponentCreator> componentsCrators { get; set; }

        public Salesman()
        {
            componentsCrators = new List<IComponentCreator>();
        }

        public void Appose()
        {
            foreach(var component in componentsCrators)
            {
                component.Create();
            }
        }
    }
}

