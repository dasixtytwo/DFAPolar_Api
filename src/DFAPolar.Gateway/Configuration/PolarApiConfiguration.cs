using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFAPolar.Gateway.Configuration
{
    /// <summary>
    /// API Configuration model
    /// </summary>
    public class PolarApiConfiguration
    {
        /// <summary>
        /// API endpoint
        /// </summary>
        public string PolarApiEndpoint { get; set; }

        /// <summary>
        /// API endpoint
        /// </summary>
        public string RemoteApiEndpoint { get; set; }

        /// <summary>
        /// API endpoint
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// API endpoint
        /// </summary>
        public string ClientSecret { get; set; }
    }
}
