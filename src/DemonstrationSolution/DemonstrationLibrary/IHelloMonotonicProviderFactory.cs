using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationLibrary
{
    public interface IHelloMonotonicProviderFactory
    {
        /// <summary>
        /// Get a message provider instance
        /// </summary>
        /// <returns>a reference to a message provider instance</returns>
        /// <exception cref="InvalidOperationException"></exception>
        IHelloMonotonicMessageProvider GetMessageProvider();
    }

    public interface IHelloMonotonicProviderFactory<out TProvider> : IHelloMonotonicProviderFactory where TProvider : IHelloMonotonicMessageProvider 
    {
        /// <summary>
        /// Get a strongly typed message provider instance
        /// </summary>
        /// <returns>strongly typed instance</returns>
        new TProvider GetMessageProvider();
    }
}
