using Prism.Mvvm;
using Prism.Regions;
using PrismDictionaryBinding.Views;

namespace PrismDictionaryBinding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel(IRegionManager regionManager)
        {
            //在主窗口中注册使用自定义控件
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
        }

        /// <summary>
        /// 标题
        /// </summary>
        /// <remarks>
        /// 在xaml中直接绑定
        /// </remarks>

        public string Title => "Prism Dictionary Binding";
    }
}