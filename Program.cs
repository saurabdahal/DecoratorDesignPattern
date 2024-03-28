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

            Console.WriteLine("This is the response from Plain Decorator:");
            Console.WriteLine(plainDecorator.GetText());

            Console.WriteLine("\nThis is the response from Color Decorator:");
            Console.WriteLine(colorDecorator.GetText());

            Console.WriteLine("\nThis is the response from Uppercase Decorator:");
            Console.WriteLine(upperCaseDecorator.GetText());
        }
    }
}
