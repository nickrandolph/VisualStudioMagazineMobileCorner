using MvvmCross.ViewModels;

namespace XamarinFormsWithMvvmCross.Core.ViewModels
{
    public class ContactViewModel : MvxViewModel<Contact>
    {
        public Contact Contact { get; set; }
        public override void Prepare(Contact parameter)
        {
            Contact = parameter;
        }
    }
}
