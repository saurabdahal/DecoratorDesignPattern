using System;
using DecoratorDesignPattern.ComponentConcrete;
using DecoratorDesignPattern.ComponentDecorator;
using DecoratorDesignPattern.ComponentInterface;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> component = new ConcreteComponent<string>();

            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> colorDecorator = new ColorDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);

            Console.WriteLine(plainDecorator.GetText());

            Console.WriteLine(colorDecorator.GetText());

            Console.WriteLine(upperCaseDecorator.GetText());
        }
    }
}
