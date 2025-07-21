using System.Threading.Tasks;

namespace PropertyGridControllerService
{
    public interface IPropertyGridControllerService
    {
        Task SortAlphabeticallyAsync();
        Task SortByCatogeryAsync();
        Task ShowPropertyTabAsync();
        Task ShowEventTabAsync();
        Task CollapseAllAsync();
        Task ExpandAllAsync();

        Task FilterPropertiesAsync(string filterTerm);
    }
}
