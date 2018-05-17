﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Models
{
    public class Route
    {
        public string Name { get; set; } // descriptive name for debugging
        public string UrlRegex { get; set; }
        public string Method { get; set; }
        public Func<HttpRequest, HttpResponse> Callable { get; set; }
    }
}
