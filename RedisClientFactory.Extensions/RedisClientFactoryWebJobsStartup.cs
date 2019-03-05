using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using RedisClientFactory.Extensions.Config;

[assembly: WebJobsStartup(typeof(RedisClientFactory.Extensions.RedisClientFactoryWebJobsStartup))]

namespace RedisClientFactory.Extensions
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