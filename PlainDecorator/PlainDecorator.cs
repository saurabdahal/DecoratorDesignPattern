using DecoratorDesignPattern.ComponentInterface;


namespace DecoratorDesignPattern.ComponentDecorator
{
    /// <summary>
    /// This class inherits from Decorator class and  override the method to add own message
    /// </summary>
    /// <Author>Saurav Dahal</Author>
    class PlainDecorator(IComponent<string> component) : Decorator<string>(component)
    {
        public override string GetText()
        {
            return "This is the text from plain decorator."+base.GetText();
        }
    }
}
