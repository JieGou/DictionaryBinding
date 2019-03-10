using Prism.Mvvm;
using Prism.Regions;
using PrismDictionaryBinding.Views;

namespace PrismDictionaryBinding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
        }

        public string Title => "Prism Dictionary Binding";
    }
}
