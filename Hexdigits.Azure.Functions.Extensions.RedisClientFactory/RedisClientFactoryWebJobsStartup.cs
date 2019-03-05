using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Hexdigits.Azure.Functions.Extensions.RedisClientFactory.Config;

[assembly: WebJobsStartup(typeof(Hexdigits.Azure.Functions.Extensions.RedisClientFactory.RedisClientFactoryWebJobsStartup))]

namespace Hexdigits.Azure.Functions.Extensions.RedisClientFactory
{
    public class RedisClientFactoryWebJobsStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<RedisClientFactoryExtensionConfigProvider>();
            builder.Services.AddTransient<RedisClientFactorySettings>();
        }
    }
}