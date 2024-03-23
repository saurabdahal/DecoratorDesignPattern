using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.ComponentInterface;

namespace DecoratorDesignPattern.ComponentDecorator
{
    abstract class Decorator<String> : IComponent<T>
    {

        protected IComponent<T> component;

        public Decorator(IComponent<T> component)
        {
            this.component = component;
        }

        public virtual T GetText()
        {
            return component.GetText();
        }
    }
}
