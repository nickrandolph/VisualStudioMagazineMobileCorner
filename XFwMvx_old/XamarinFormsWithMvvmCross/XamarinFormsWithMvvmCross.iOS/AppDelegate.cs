
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace XamarinFormsWithMvvmCross.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate
        : MvxFormsApplicationDelegate<MvxFormsIosSetup<Core.App, XamarinFormsWithMvvmCross.App>, Core.App, XamarinFormsWithMvvmCross.App>
        //: MvxApplicationDelegate<MvxIosSetup<App>, App>
        //: global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        //public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        //{
        //    global::Xamarin.Forms.Forms.Init();
        //    LoadApplication(new App());

        //    return base.FinishedLaunching(app, options);
        //}
    }
}
