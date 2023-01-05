using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

    public class NotifyPropertyChangeDemo : INotifyPropertyChanged
    {
        // The event that is fired when a property changes.
        public event PropertyChangedEventHandler? PropertyChanged;

        // Backing field for the property.
        private string? _lastName;
        private string? _firstName;

        // The property that is being monitored.
        public string? LastName
        {
            get => _lastName;
            
            set
            {
                if (_lastName == value)
                {
                    return;
                }
                
                _lastName = value;

                // Notify the UI that the property has changed.
                // Using CallerMemberName at the call site will automatically fill in
                // the name of the property that changed.
                OnPropertyChanged();
            }
        }

        public string? FirstName
        {
            get => _firstName;

            set
            {
                if (_firstName == value)
                {
                    return;
                }

                _firstName = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "") 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
