namespace WinFormsCommandBindingDemo
{
    public interface IDataContextTarget
    {
        /// <summary>
        /// Gets or sets the data context for an element when it participates in data binding.
        /// </summary>
        object? DataContext { get; set; }
    }
}
