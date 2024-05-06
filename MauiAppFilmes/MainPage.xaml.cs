namespace MauiAppFilmes
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void Aventura_Clicked(object sender, EventArgs e)
        {
            try 
            {
                Navigation.PushAsync(new Categorias.aventura());            
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Ficcao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.FiccaoCientifica());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Drama());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Infantil_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Infantil());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Documentario_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Documentario());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Nacional_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Nacional());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Comedia());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Terror_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Terror());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Suspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Suspense());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Animacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Animacao());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Guerra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Guerra());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Romance_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Romance());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
