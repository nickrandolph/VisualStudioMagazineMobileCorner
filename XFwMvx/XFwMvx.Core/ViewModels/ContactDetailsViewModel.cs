using MvvmCross.ViewModels;
using XFwMvx.Core.Models;

namespace XFwMvx.Core.ViewModels
{
    public class ContactDetailsViewModel : MvxViewModel<Contact>
    {
        public Contact Contact { get; private set; }
        public override void Prepare(Contact parameter)
        {
            Contact = parameter;
        }
    }

}
