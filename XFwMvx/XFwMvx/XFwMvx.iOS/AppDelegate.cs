
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace XFwMvx.iOS
{
   [Register("AppDelegate")]
    public partial class AppDelegate
   : MvxFormsApplicationDelegate<MvxFormsIosSetup<XFwMvx.Core.App, XFwMvx.App>, XFwMvx.Core.App, XFwMvx.App>
    {
    }

}
