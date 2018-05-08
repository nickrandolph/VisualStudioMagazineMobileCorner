using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;
using XFwMvx;

namespace XFwMvx.Droid
{
    [Activity(Label = "XFwMvx", Icon = "@mipmap/icon", Theme = "@style/MainTheme",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class RootActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<Core.App, App>, Core.App, App>
    {
    }

}

