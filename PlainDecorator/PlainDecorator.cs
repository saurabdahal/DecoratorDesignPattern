using DecoratorDesignPattern.ComponentInterface;


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
