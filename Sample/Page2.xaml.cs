using System.Windows.Input;
using Xamarin.Forms;

namespace Sample {
    public partial class Page2 : ContentPage {
        
        public Page2() {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = this;

            Button.Command = new Command((obj) => {
                Navigation.PopAsync();
            });
        }
    }
}
