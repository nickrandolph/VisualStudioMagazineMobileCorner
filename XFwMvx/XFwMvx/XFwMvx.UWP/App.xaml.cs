using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;

namespace XFwMvx.UWP
{
    sealed partial class App
    {
        public App()
        {
            this.InitializeComponent();
        }
    }


    public abstract class ProxyMvxApplication : MvxWindowsApplication<MvxFormsWindowsSetup<Core.App, XFwMvx.App>, Core.App, XFwMvx.App, MainPage>
    {
    }

}
