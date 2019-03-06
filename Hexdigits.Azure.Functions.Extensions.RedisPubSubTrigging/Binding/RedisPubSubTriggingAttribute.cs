using System;

namespace Hexdigits.Azure.Functions.Extensions.RedisPubSubTrigging.Binding
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter)]
    public class RedisPubSubTriggingAttribute : Attribute
    {
        
    }
}