using System;

namespace HotelsGarden.Helpers
{
    public static class DateTimeHelper
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ToUtc(this long unixMilliseconds)
        {
            return epoch.AddMilliseconds(unixMilliseconds);
        }
    }
}
