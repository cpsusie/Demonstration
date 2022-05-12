using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationLibrary
{
    /// <summary>
    /// Objects that implement this message generate a
    /// hello message with a monotonic timestamp therein.
    /// </summary>
    public interface IHelloMonotonicMessageProvider
    {
        /// <summary>
        /// Generate a hello message with a monostamp inside.
        /// </summary>
        /// <returns>the message</returns>
        /// <exception cref="InvalidOperationException">For implementation defined reasons, factory
        /// not in a state that permits it to fulfill the request.</exception>
        string GenerateHelloMonoStampMessage();

        /// <summary>
        /// Generate a hello message addressed specially to named addressee
        /// </summary>
        /// <param name="addressee">the named addressee</param>
        /// <returns>A hello message addressed to <paramref name="addressee"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="addressee"/> was null.</exception>
        /// <exception cref="ArgumentException"><paramref name="addressee"/> was empty, or just whitespace.</exception>
        /// <exception cref="InvalidOperationException">For implementation defined reasons, factory
        /// not in a state that permits it to fulfill the request.</exception>
        string GenerateHelloNamedMonoStampMessage(string addressee);
    }
}
