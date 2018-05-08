using XFwMvx.Core.Models;

namespace XFwMvx.Views
{
    public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ContactSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ViewModel.ShowContactDetails(e.SelectedItem as Contact);
        }
    }
}
