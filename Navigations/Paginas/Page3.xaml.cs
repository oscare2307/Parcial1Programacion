using Dominio;

namespace Navigations.Paginas;

public partial class Page3 : ContentPage
{
    private Persona persona;
    public Page3(Persona persona)
	{
		InitializeComponent();
        this.persona = persona;
       
    }
    // Permite el comportamiento de manera inmediata antes de que la pagina sea visible
    protected override void OnAppearing() 
    {
        base.OnAppearing();

        // Mostrar los datos de persona
        EntryDia.Text = persona.Fecha.ToString();
        EntryEspecialidad.Text = persona.Especialidad;
        EntryMedico.Text = persona.Medico;
    }

    private  async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Page4());
    }
}
