using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServices
{
    public class GlobalTestSettings
    {
        public GlobalTestSettings(IConfiguration cfg)
        {
            var settings = cfg.GetSection("globalSettings");
        }
    }
}
