using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditDeleteContactViewPage : ContentPage
    {
        public EditDeleteContactViewPage()
        {
            InitializeComponent();
        }

        private void ClosePage()
        {
            Navigation.PopModalAsync();
        }

        private void Pop_Clicked(object sender, EventArgs e)
        {
            ClosePage();
        }
    }
}