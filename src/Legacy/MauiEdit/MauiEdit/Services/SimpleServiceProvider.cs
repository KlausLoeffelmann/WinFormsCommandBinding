using WinFormsCommandBinding.Models.Service;

namespace MauiEdit.Services
{
    public class SimpleServiceProvider : IServiceProvider
    {
        private static IServiceProvider? _instance;

        private IDialogService? _winFormsDialogService;

        public object GetService(Type serviceType)
            => serviceType switch
            {
                Type requestedType when typeof(IDialogService).IsAssignableFrom(requestedType)
                    => _winFormsDialogService ??= new MauiDialogService(),

                Type requestedType when typeof(MauiDialogService).IsAssignableFrom(requestedType)
                    => _winFormsDialogService ??= new MauiDialogService(),

                _ => throw new NotImplementedException($"Requested service '{serviceType}' is not supported.")
            };

        public static IServiceProvider GetInstance()
            => _instance ??= new SimpleServiceProvider();
    }
}
