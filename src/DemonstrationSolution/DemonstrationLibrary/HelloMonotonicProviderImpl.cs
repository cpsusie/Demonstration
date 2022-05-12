using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationLibrary
{
    /// <summary>
    /// This class provides a typical implementation for the <see cref="IHelloMonotonicMessageProvider"/>
    /// interface.
    /// </summary>0
    public sealed class HelloMonotonicProvider : IHelloMonotonicMessageProvider
    {
        internal static HelloMonotonicProvider Instance { get; } = new();
        private HelloMonotonicProvider(){}

        /// <inheritdoc />
        public string GenerateHelloMonoStampMessage() => "Hello, world at [" + TimestampProvider.MonotonicNow + "]!";

        /// <inheritdoc />
        public string GenerateHelloNamedMonoStampMessage(string addressee) =>
            "Hello, " + addressee switch
            {
                {} text when !string.IsNullOrWhiteSpace(text) => text,
                null => throw new ArgumentNullException(nameof(addressee)),
                {}  => throw new ArgumentException(@"Empty or whitespace-only value not allowed.", nameof(addressee)),
            } + " at [" + TimestampProvider.MonotonicNow + "]!";

    }
}
