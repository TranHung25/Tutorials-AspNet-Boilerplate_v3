using Abp.AutoMapper;
using Acme.SimpleTaskApp.Authentication.External;

namespace Acme.SimpleTaskApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
