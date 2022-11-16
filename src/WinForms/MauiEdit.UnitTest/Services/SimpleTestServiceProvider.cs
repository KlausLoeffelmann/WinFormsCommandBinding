using System;
using WinFormsCommandBinding.Models.Service;

namespace CommandBindingDemo.UnitTest.Services
{
    public class SimpleTestServiceProvider : IServiceProvider
    {
        private static IServiceProvider? _instance;

        private IDialogService? _winFormsDialogService;

        public object GetService(Type serviceType)
            => serviceType switch
            {
                Type requestedType when typeof(IDialogService).IsAssignableFrom(requestedType)
                    => _winFormsDialogService ??= new SimpleUnitTestDialogService(),

                Type requestedType when typeof(SimpleUnitTestDialogService).IsAssignableFrom(requestedType)
                    => _winFormsDialogService ??= new SimpleUnitTestDialogService(),

                _ => throw new NotImplementedException($"Requested service '{serviceType}' is not supported.")
            };

        public static IServiceProvider GetInstance()
            => _instance ??= new SimpleTestServiceProvider();
    }
}
