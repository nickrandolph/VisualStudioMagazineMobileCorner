using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XFwMvx.Core.Models;
using XFwMvx.Core.Services;

namespace XFwMvx.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IContactService ContactService { get;  }
        private IMvxNavigationService NavigationService { get; }
        public MainViewModel(IMvxNavigationService navigationService, IContactService contactService)
        {
            NavigationService = navigationService;
            ContactService = contactService;
        }

        public string WelcomeText => "Hello Xamarin.Forms with MvvmCross";

        public ObservableCollection<Contact> Contacts { get; } = new ObservableCollection<Contact>();
        public override void ViewAppeared()
        {
            base.ViewAppeared();

            var contacts = ContactService.FetchContacts();
            foreach (var contact in contacts)
            {
                Contacts.Add(contact);
            }
        }

        public Task ShowContactDetails(Contact contact)
        {
            return NavigationService.Navigate<ContactDetailsViewModel, Contact>(contact);
        }
    }

}
