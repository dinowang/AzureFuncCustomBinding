using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using StackExchange.Redis;

namespace Hexdigits.Azure.Functions.Extensions.RedisPubSubTrigging.Config
{
    [Extension("RedisPubSubTrigging")]
    internal class RedisPubSubTriggingExtensionConfigProvider : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
        }
    }
}