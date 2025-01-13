using System;
using System.Collections.Generic;

namespace PartsUnlimited.Utils
{
    internal class NullTelemetryProvider : ITelemetryProvider
    {
        public void TrackEvent(string message)
        {
            // do nothing
        }

        public void TrackEvent(string message, Dictionary<string, string> properties, Dictionary<string, double> measurements)
        {
            // do nothing
        }

        public void TrackException(Exception exception)
        {
            // do nothing
        }

        public void TrackTrace(string message)
        {
            // do nothing
        }
    }
}