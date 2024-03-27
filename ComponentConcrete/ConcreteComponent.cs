using DecoratorDesignPattern.ComponentInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ComponentConcrete
{
    class ConcreteComponent<String> : IComponent<string>
    {
        /// <summary>
        /// This is the concerete class that implements the <see cref="IComponent{T}" /> interface.
        /// </summary>
        /// <returns></returns>
        public string GetText()
        {
            return "This is a string from ConcreteComponent";
        }
    }
}
