using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using StackExchange.Redis;
using Hexdigits.Azure.Functions.Extensions.RedisClientFactory.Binding;

namespace Hexdigits.Azure.Functions.Extensions.RedisPubSubTrigging.Config
{
    [Extension("RedisPubSubTrigging")]
    internal class RedisPubSubTriggingExtensionConfigProvider : IExtensionConfigProvider
    {
        
    }
}