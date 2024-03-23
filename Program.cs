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
            // Create a ConcreteComponent
            IComponent<string> component = new ConcreteComponent<string>();

            // Create one instance of each decorator
            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> colorDecorator = new ColorDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);

            // Call GetText() on each object and print the result to the console
            Console.WriteLine("Plain Decorator:");
            Console.WriteLine(plainDecorator.GetText());

            Console.WriteLine("\nColor Decorator:");
            Console.WriteLine(colorDecorator.GetText());

            Console.WriteLine("\nUppercase Decorator:");
            Console.WriteLine(upperCaseDecorator.GetText());
        }
    }
}
