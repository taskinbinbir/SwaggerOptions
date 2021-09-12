using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trial.Options
{
    public class SwaggerOptions
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public string JsonRoute { get; set; }
        public string Description { get; set; }
        public string UIEndpoint { get; set; }
    }
}
