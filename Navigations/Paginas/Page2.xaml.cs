using Dominio;

namespace Navigations.Paginas;

public partial class Page2 : ContentPage
{
    private Persona persona;
    public Page2()
	{
		InitializeComponent();

	}
    private async void Button_Clicked(object sender, EventArgs e)
    {

        // Analizar EntryFecha.Text en un objeto DateOnly (asumiendo un formato v�lido)
        DateOnly fecha;
        try
        {
            fecha = DateOnly.Parse(EntryFecha.Text);
        }
        catch (FormatException)
        {

            await DisplayAlert("Error", "Formato de fecha no v�lido", "OK");
            return;
        }

        // Crea un objeto Persona
        persona = new Persona
        {
            // Suponiendo que Persona.Fecha es una cadena por ahora
            Fecha = fecha,
            Especialidad = picker.SelectedItem.ToString(),
            Medico = Item.SelectedItem.ToString()
        };

        // Comprobar si se cre� la persona
        if (persona != null && persona.Fecha != null)
        {
            await Navigation.PushAsync(new Page3(persona));
        }
    }
}