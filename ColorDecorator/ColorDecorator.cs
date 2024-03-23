using DecoratorDesignPattern.ComponentDecorator;


namespace DecoratorDesignPattern.ComponentDecorator
{
    class ColorDecorator(ComponentInterface.IComponent<string> component) : Decorator<string>(component)
    {
        public override string GetText()
        {
            string text = base.GetText();
            return $"\u001b[31m{text}\u001b[0m"; 
        }


    }
}
