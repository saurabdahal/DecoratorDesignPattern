using DecoratorDesignPattern.ComponentInterface;


namespace DecoratorDesignPattern.ComponentDecorator
{
    class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<T> component) : base(component)
        { }
            public override T GetText()
        {
            return base.GetText().ToUpper();
        }
    }
    }
}
