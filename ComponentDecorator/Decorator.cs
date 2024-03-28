using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.ComponentInterface;

namespace DecoratorDesignPattern.ComponentDecorator
{
    /// <summary>
    /// This is the abstract class that represents the base decorator.
    /// </summary>
    abstract class Decorator<T> : IComponent<T>
    {

        protected IComponent<T> component;

          public Decorator(IComponent<T> component)
        {
            this.component = component;
        }

        /// <summary>
        /// Fetches the text from the component.
        /// </summary>
        /// <Author>Saurav Dahal</Author>
        public virtual T GetText()
        {
            return component.GetText();
        }
    }
}
