using DecoratorDesignPattern.ComponentInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ComponentDecorator
{
    class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<T> component) : base(component) { }
        
        public override T GetText()
        {
            return "This is a text from Plain Decorator";   
        }
    }
}
