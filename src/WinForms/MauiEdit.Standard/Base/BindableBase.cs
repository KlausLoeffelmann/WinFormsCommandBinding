using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;

namespace WinFormsCommandBinding.Models
{
    /// <summary>
    /// Implementation of <see cref="INotifyPropertyChanged"/> to simplify models.
    /// </summary>
    public abstract class WinFormsViewController : ObservableObject
    {
        /// <summary>
        /// Creates an instance of the BindableBase class.
        /// </summary>
        public WinFormsViewController(IServiceProvider serviceProvider) : base()
        {
            ServiceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider { get; }
    }
}
