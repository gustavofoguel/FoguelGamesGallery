using FoguelGamesGallery.Models;

namespace FoguelGamesGallery.Views;

public partial class PaginaDetalhesConsoles : ContentPage
{
	public PaginaDetalhesConsoles(Consoles consoles)
	{
		InitializeComponent();

		this.BindingContext = consoles;
	}

	async void BackButton_Clicked(System.Object sender,
		System.EventArgs e)
	{
		await Navigation.PopAsync();
	}
}