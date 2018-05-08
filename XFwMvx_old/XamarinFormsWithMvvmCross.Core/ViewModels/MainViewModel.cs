using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;

namespace XamarinFormsWithMvvmCross.Core.ViewModels
{
    public class MainViewModel: MvxViewModel
    {
        public string WelcomeText => "Hello Xamarin.Forms with MvvmCross";

        public ObservableCollection<Contact> Contacts { get;  } = new ObservableCollection<Contact>();

        private IMvxNavigationService Navigation { get; set; }

        public MainViewModel(IMvxNavigationService nav)
        {
            Navigation = nav;
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            for (int i = 0; i < 1000; i++)
            {
                Contacts.Add(new Contact { Identity = i, Name = $"Contact {i}" });
            }

        }

        public void ShowDetails(Contact contact)
        {
            Navigation.Navigate<ContactViewModel, Contact>(contact);
        }
    }

    public class Contact
    {
        public int Identity { get; set; }
        public string Name { get; set; }
    }
}
