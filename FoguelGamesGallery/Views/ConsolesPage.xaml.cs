using FoguelGamesGallery.Models;
using FoguelGamesGallery.Services;

namespace FoguelGamesGallery.Views;

public partial class ConsolesPage : ContentPage
{
	private const uint AnimationDuration = 800u;
	public ConsolesPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		lstPopularConsoles.ItemsSource =
			ConsolesServico.GetFeaturedConsoles();
		lstPopularConsoles.ItemsSource = ConsolesServico.GetAllConsoles();
    }

	async void Consoles_SelectionChanged(System.Object sender,
		Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new PaginaDetalhesConsoles
			(e.CurrentSelection.First() as Consoles));
	}

	async void ProfilePic_Clicked(System.Object sender,
		System.EventArgs e)
	{
		// Mostra o menu e retira o conteudo principal
		_ = MainContentGrid.TranslateTo(-this.Width * 0.5,
			this.Height * 0.1, AnimationDuration, Easing.CubicIn);
		await MainContentGrid.ScaleTo(0.8, AnimationDuration);
		_ = MainContentGrid.FadeTo(0.8, AnimationDuration);
	}

	async void GridArea_Tapped(System.Object sender, System.EventArgs e)
	{
		await CloseMenu();
	}

	private async Task CloseMenu()
	{
		// Feche o menu e traga de volta o conteúdo principal
		_ = MainContentGrid.FadeTo(1, AnimationDuration);
		_ = MainContentGrid.ScaleTo(1, AnimationDuration);
		await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }


}