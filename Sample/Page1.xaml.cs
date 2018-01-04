using System.Windows.Input;
using Xamarin.Forms;

namespace Sample {
    public partial class Page1 : ContentPage {
        
        public Page1() {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = this;

            Button.Command = new Command((obj) => {
                Navigation.PushAsync(new Page2());
            });
        }
    }
}
