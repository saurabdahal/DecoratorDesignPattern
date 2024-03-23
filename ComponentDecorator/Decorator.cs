using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.ComponentInterface;

namespace DecoratorDesignPattern.ComponentDecorator
{
    abstract class Decorator<String>(IComponent<string> component) : IComponent<string>
    {

        protected IComponent<string> component = component;

        public virtual string GetText()
        {
            return component.GetText();
        }
    }
}
