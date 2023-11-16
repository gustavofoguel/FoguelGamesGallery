namespace FoguelGamesGallery.Views;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
			return;

		var parentAnimation = new Animation();

		//Animação dos consoles
		parentAnimation.Add(0, 0.2, new Animation(v => imgPlaystation5.Opacity = v, 0, 1, Easing.CubicIn));
		parentAnimation.Add(0.1, 0.3, new Animation(v => imgXboxSeriesX.Opacity = v, 0, 1, Easing.CubicIn));
		parentAnimation.Add(0.2, 0.4, new Animation(v => imgNintendoSwitch.Opacity = v, 0, 1, Easing.CubicIn));

		// Animação da caixa de introdução
		parentAnimation.Add(0.7, 1, new Animation(v => frmIntro.Opacity = v, 0, 1, Easing.CubicIn));

		// Confirmar animação
		parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
	}

	async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
		=> Application.Current.MainPage = new NavigationPage(new ConsolesPage());
}