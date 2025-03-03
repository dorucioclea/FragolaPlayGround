﻿using System;

namespace FragolaPlayGround
{
    public static class TimeExtension
    {
        private static readonly DateTime OriginDateTime = new(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        public static uint ToTimespamp(this DateTime date)
        {
            return (uint)(date - OriginDateTime).TotalSeconds;
        }

        public static DateTime FromTimestamp(this int timestamp)
        {
            return OriginDateTime.AddSeconds(timestamp).ToUniversalTime();
        }
    }
}
