using DecoratorDesignPattern.ComponentInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ComponentConcrete
{
    class ConcreteComponent : IComponent<T>
    {
        public T GetText()
        {
            return "this is a ConcreteComponent";
        }
    }
}
