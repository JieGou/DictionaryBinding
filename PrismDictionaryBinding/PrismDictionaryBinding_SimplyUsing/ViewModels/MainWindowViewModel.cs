using Prism.Mvvm;
using PrismDictionaryBinding.Views;

namespace PrismDictionaryBinding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            //在主窗口中注册使用自定义控件
            this.ControlViewModel = new ContentViewModel();
        }

        /// <summary>
        /// 标题
        /// </summary>
        /// <remarks>
        /// 在xaml中直接绑定
        /// </remarks>

        public string Title => "Prism Dictionary Binding";

        private BindableBase _controlViewModel;

        public BindableBase ControlViewModel
        {
            get { return _controlViewModel; }
            set { SetProperty(ref _controlViewModel, value); }
        }
    }
}