using DecoratorDesignPattern.ComponentDecorator;


namespace DecoratorDesignPattern.ComponentDecorator
{
    /// <summary>
    /// This class inherits from Decorator class and  override the method to add color to the message
    /// </summary>
    /// <Author>Saurav Dahal</Author>
    class ColorDecorator(ComponentInterface.IComponent<string> component) : Decorator<string>(component)
    {
        public override string GetText()
        {
            string text = base.GetText();
            return $"\u001b[31m{text}\u001b[0m"; 
        }
    }
}
