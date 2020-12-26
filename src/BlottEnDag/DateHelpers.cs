using System;

namespace BlottEnDag
{

    public static class DateHelpers
    {

        public static string getUniversalTimeString(DateTime d)
        {
            // See also
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
            // string search: 6/15/2009 1:45:30 PM (Utc) --> 2009-06-15T13:45:30.0000000Z

            return d.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
        }

    }

}
