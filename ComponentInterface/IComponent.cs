using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ComponentInterface
{
    /// This is the interface for components. It defines methods that structures the class that implements it.
    public interface IComponent<T>
    {
        /// <summary>
        /// Gets the message of the component
        /// </summary>
        /// <returns>Text defined in the concerete classes</returns>
        /// <Author>Saurav Dahal</Author>
        T GetText();
    }
}
