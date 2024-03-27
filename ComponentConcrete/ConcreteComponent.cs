using DecoratorDesignPattern.ComponentInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ComponentConcrete
{
    class ConcreteComponent<String> : IComponent<string>
    {
        public string GetText()
        {
            return "This is a string from ConcreteComponent";
        }
    }
}
