using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        /// 
        /// Parses the domain from a URL string or returns the string if no URL was found
        /// 
        /// 
        /// 
        public static string AsDomain(this string url)
        {
            if (string.IsNullOrEmpty(url))
                return url;
            var match = Regex.Match(url, @"^http[s]?[:/]+[^/]+");
            if (match.Success)
                return match.Captures[0].Value;
            else
                return url;
        }
        ///
        /// Parses the domain from a URL
        /// 
        /// 
        /// 
        public static string AsDomain(this Uri url)
        {
            if (url == null)
                return null;
            return url.ToString().AsDomain();
        }
    }
    class WebRobot
    {
    }
}
