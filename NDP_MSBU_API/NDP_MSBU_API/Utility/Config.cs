using Microsoft.Extensions.Configuration;

namespace NDP_MSBU_API.Utility
{
    public class Config
    {
        private readonly IConfiguration _configuration;

        public string ConnStr { get { return _configuration.GetConnectionString(""); } }
    }
}
