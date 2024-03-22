using Navigations.Paginas;

namespace Navigations
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }

}
