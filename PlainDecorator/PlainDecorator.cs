using DecoratorDesignPattern.ComponentInterface;


namespace DecoratorDesignPattern.ComponentDecorator
{
    class PlainDecorator(IComponent<string> component) : Decorator<string>(component)
    {
        public override string GetText()
        {
            return "Thi is the text from plain decorator."+base.GetText();
        }
    }
}
