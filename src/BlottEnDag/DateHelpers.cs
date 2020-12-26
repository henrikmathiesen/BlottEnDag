using System;

namespace BlottEnDag
{

    public static class DateHelpers
    {

        public static string getUniversalTimeString(DateTime d)
        {
            return d.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
        }

    }

}
