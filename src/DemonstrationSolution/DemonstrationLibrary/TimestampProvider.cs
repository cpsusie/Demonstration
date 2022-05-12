using System;
using System.Runtime.CompilerServices;

namespace DemonstrationLibrary
{
    /// <summary>
    /// This class can be used to obtain various types of timestamps
    /// </summary>
    public static class TimestampProvider
    {
        /// <summary>
        /// Get a monotonic stamp for the present time
        /// </summary>
        public static MonoStamp MonotonicNow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => HpTimeStamps.MonotonicTimeStampUtil<MonotonicContext>.StampNow;
        }

        /// <summary>
        /// Get a timestamp based on wall clock (system) time, expressed locally
        /// </summary>
        public static WallStamp LocalWallStamp => DateTime.Now;

        /// <summary>
        /// Get a time stamp based on wall clock (system) time, expressed
        /// as utc time
        /// </summary>
        public static WallStamp UtcWallStamp => DateTime.UtcNow;

        /// <summary>
        /// Get a portable monotonic timestamp for the present time
        /// </summary>
        public static PortableStamp PortableMonotonicNow => (PortableStamp)MonotonicNow;

        /// <summary>
        /// Get a portable timestamp based on wall clock time (portable stamps are always expressed in utc;
        /// conversion from WallStamp to Monostamp performs necessary adjustments based on
        /// nature of wall stamp to convert)
        /// </summary>
        public static PortableStamp PortableWallUtcNow => UtcWallStamp;
    }
}