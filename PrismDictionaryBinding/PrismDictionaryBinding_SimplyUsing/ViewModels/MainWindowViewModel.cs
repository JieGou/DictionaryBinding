using Prism.Mvvm;
using PrismDictionaryBinding.Views;
using System.Windows.Controls;

namespace PrismDictionaryBinding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            //在主窗口中注册使用自定义控件
            this.UserControlView = new ContentView();
        }

        /// <summary>
        /// 标题
        /// </summary>
        /// <remarks>
        /// 在xaml中直接绑定
        /// </remarks>

        public string Title => "Prism Dictionary Binding";

        #region 使用绑定方法，后台MainWindowViewModel支持

        private UserControl _userUserControlView;

        public UserControl UserControlView
        {
            get => _userUserControlView;
            set => SetProperty(ref _userUserControlView, value);
        }

        #endregion 使用绑定方法，后台MainWindowViewModel支持
    }
}