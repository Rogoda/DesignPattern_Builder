using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Builder
{
    public interface IComponentCreator
    {
        void Create();
        Component GetComponent();
    }
}

