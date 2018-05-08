using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;

namespace XamarinFormsWithMvvmCross.UWP
{
    sealed partial class App 
    {
        public App()
        {
            this.InitializeComponent();
       }
    }

    public abstract class ProxyMvxApplication : MvxWindowsApplication<MvxFormsWindowsSetup<Core.App, XamarinFormsWithMvvmCross.App>, Core.App, XamarinFormsWithMvvmCross.App, MainPage>
    {
    }
}
