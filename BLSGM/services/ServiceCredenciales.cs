using BLSGM.interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLSGM.services
{
    public class Credenciales : ICredenciales
    {
        private readonly IConfiguration _cfg;

        public Credenciales(IConfiguration config)
        {
            _cfg = config;
        }

        public string Host => Environment.MachineName;

        public string AmbienteSII => _cfg.GetSection("SII:Environ").Value;

        public string Usuario => "jdonoso@sauro.cl";




    }
}
}
