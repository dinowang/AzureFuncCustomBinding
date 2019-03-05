using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using RedisClientFactory.Extensions.Binding;
using StackExchange.Redis;

namespace RedisClientFactory.Extensions.Config
{
    [Extension("RedisClientFactory")]
    internal class RedisClientFactoryExtensionConfigProvider : IExtensionConfigProvider
    {
        private readonly RedisClientFactorySettings _settings;

        public RedisClientFactoryExtensionConfigProvider(RedisClientFactorySettings settings)
        {
            _settings = settings;
        }

        public void Initialize(ExtensionConfigContext context)
        {
            var bindingRule = context.AddBindingRule<RedisClientFactoryAttribute>();

            bindingRule.BindToInput<ConnectionMultiplexer>(x => ConnectionMultiplexer.Connect(_settings.ConnectionString, null));

            bindingRule.BindToInput<IDatabase>(x => 
            {
                var connection = ConnectionMultiplexer.Connect(_settings.ConnectionString, null);
                return connection.GetDatabase(0);
            });
        }
    }
}