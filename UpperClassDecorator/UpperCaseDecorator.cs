using DecoratorDesignPattern.ComponentInterface;


namespace DecoratorDesignPattern.ComponentDecorator
{
    /// <summary>
    /// This class inherits from <see cref="Decorator{T}">Decorator</see> and  override the method to convert base text to uppercase.
    /// </summary>
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
