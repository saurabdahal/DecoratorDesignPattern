using DecoratorDesignPattern.ComponentInterface;


namespace DecoratorDesignPattern.ComponentDecorator
{
    /// <summary>
    /// This class inherits from <see cref="Decorator{T}">Decorator</see> and  override the method to add own message
    /// </summary>
    class PlainDecorator(IComponent<string> component) : Decorator<string>(component)
    {
        public override string GetText()
        {
            return "This is the text from plain decorator."+base.GetText();
        }
    }
}
