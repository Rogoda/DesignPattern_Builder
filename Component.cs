using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Builder
{
    public class Component
    {
        public string Name { get; private set; }

        public Component(string name)
        {
            Name = name;
        }
    }
}

