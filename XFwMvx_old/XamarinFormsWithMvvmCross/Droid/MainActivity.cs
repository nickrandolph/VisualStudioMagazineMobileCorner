
using Android.App;
using Android.Content.PM;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;

namespace XamarinFormsWithMvvmCross.Droid
{
    [Activity(Label = "XamarinFormsWithMvvmCross", Icon = "@mipmap/icon", Theme = "@style/MainTheme", 
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class RootActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<Core.App, App>, Core.App, App>
    {
    }
}

