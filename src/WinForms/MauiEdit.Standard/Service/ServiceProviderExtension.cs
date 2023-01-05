using System;

namespace WinFormsCommandBinding.Models.Service
{
    public static class ServiceProviderExtension
    {
        static public T GetRequiredService<T>(this IServiceProvider serviceProvider)
        {
            if (serviceProvider.GetService(typeof(T)) is T service)
            {
                return service;
            }
            else
            {
                throw new InvalidOperationException($"Service {typeof(T).Name} not found.");
            }
        }
    }
}
