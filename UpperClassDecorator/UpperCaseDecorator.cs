using DecoratorDesignPattern.ComponentInterface;


namespace DecoratorDesignPattern.ComponentDecorator
{
    class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component)
        { }
        public override string GetText()
        {
            return base.GetText().ToUpper();
        }

    }
}
