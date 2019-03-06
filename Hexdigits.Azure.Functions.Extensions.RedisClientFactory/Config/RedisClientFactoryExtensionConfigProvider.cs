using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using StackExchange.Redis;
using Hexdigits.Azure.Functions.Extensions.RedisClientFactory.Binding;
using System;

namespace Hexdigits.Azure.Functions.Extensions.RedisClientFactory.Config
{
    [Extension("RedisClientFactory")]
    internal class RedisClientFactoryExtensionConfigProvider : IExtensionConfigProvider
    {
        private readonly RedisClientFactorySettings _settings;

        private Lazy<ConnectionMultiplexer> _connection;

        public RedisClientFactoryExtensionConfigProvider(RedisClientFactorySettings settings)
        {
            _settings = settings;
            _connection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(settings.ConnectionString, null));
        }

        public void Initialize(ExtensionConfigContext context)
        {
            var bindingRule = context.AddBindingRule<RedisClientFactoryAttribute>();

            bindingRule.BindToInput<ConnectionMultiplexer>(x => _connection.Value);

            bindingRule.BindToInput<IDatabase>(x => _connection.Value.GetDatabase(x.DatabaseId));
        }
    }
}