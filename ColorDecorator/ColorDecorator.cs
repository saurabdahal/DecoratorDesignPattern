using DecoratorDesignPattern.ComponentDecorator;


namespace DecoratorDesignPattern.ComponentDecorator
{
    /// <summary>
    /// This class inherits from <see cref="Decorator{T}">Decorator</see> and  override the method to add color to the message
    /// </summary>
    class ColorDecorator(ComponentInterface.IComponent<string> component) : Decorator<string>(component)
    {
        public override string GetText()
        {
            string text = base.GetText();
            return $"\u001b[31m{text}\u001b[0m"; 
        }


    }
}
