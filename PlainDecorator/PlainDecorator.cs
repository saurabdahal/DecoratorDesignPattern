using DecoratorDesignPattern.ComponentInterface;


namespace DecoratorDesignPattern.ComponentDecorator
{
    class PlainDecorator(IComponent<string> component) : Decorator<string>(component)
    {
        public override string GetText()
        {
            return "This is a text from Plain Decorator";   
        }
    }
}
