using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinFormsWithMvvmCross
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
		}
	}
}
