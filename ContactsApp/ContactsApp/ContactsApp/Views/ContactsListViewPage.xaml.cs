using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ContactsApp.ViewModels;
using ContactsApp.Model;
using Xamarin.Forms.Xaml;


namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsListViewPage : ContentPage
    {

        public ContactsListViewPage()
        {
            InitializeComponent();

            contactsListView.ItemSelected += (sender, args) =>
            {
                if (contactsListView.SelectedItem == null) return;
                Navigation.PushModalAsync(new EditDeleteContactViewPage());
            };
        }

        private void AddEntry(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddContactViewPage());
        }

        protected override void OnAppearing()
        {
            contactsListView.ItemsSource = ContactsViewModel.Contacts;
        }

    }
}