using MvvmCross.Binding.BindingContext;
using XamarinFormsWithMvvmCross.Core.ViewModels;

namespace XamarinFormsWithMvvmCross.Views
{
    public partial class MainPage 
	{
		public MainPage()
		{
			InitializeComponent();
		}

        //public void DetailsClicked(object sender,  System.EventArgs  e)
        //{
        //    ((BindingContext as MvxBindingContext).DataContext as MainViewModel).ShowDetails();
        //}

        private void ListView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ((BindingContext as MvxBindingContext).DataContext as MainViewModel).ShowDetails(e.SelectedItem as Contact);

        }
    }
}
