using DecoratorDesignPattern.ComponentInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ComponentDecorator
{
    class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<T> component) : base(component)
        {
            public override T GetText()
        {
            return base.GetText().ToUpper();
        }
    }
    }
}
