using System;
using Microsoft.Azure.WebJobs.Description;

namespace Hexdigits.Azure.Functions.Extensions.RedisClientFactory.Binding
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public sealed class RedisClientFactoryAttribute : Attribute
    {
        public int DatabaseId { get; set; } = 0;
    }
}