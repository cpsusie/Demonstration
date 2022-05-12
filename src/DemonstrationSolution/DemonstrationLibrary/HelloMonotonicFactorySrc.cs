using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationLibrary
{
    /// <summary>
    /// Access a factory that yields the default,
    /// library-provided implementation of the <see cref="IHelloMonotonicMessageProvider"/> interface.
    /// </summary>
    public static partial class HelloMonotonicFactorySrc
    {
        /// <summary>
        /// Access a factory to create monotonic hello message providers
        /// </summary>
        public static IHelloMonotonicProviderFactory<HelloMonotonicProvider> FactoryInstance { get; } =
            HelloMonotonicFactoryDefaultImpl.FactoryInstance;
    }
}
