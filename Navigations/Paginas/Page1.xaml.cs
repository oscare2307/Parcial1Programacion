using Dominio;
namespace Navigations.Paginas;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
    }

    public NavigationPage MainPage { get; }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page2());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}