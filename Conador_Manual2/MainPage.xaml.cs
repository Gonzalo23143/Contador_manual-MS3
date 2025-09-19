namespace Conador_Manual2
{
    public partial class MainPage : ContentPage
    {
        // Conteo lleva el conteo en la aplicacion
        private int Conteo = 0;
        public MainPage()
        {
            InitializeComponent();
            Conteo = 0;
            ConteoLabel.Text = Conteo.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Conteo ++;
            ConteoLabel.Text = Conteo.ToString();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Conteo = 0;
            ConteoLabel.Text = Conteo.ToString();


        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Conteo = Conteo+5;
            ConteoLabel.Text = Conteo.ToString();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Conteo = Conteo - 1000;
            ConteoLabel.Text = Conteo.ToString();
        }
    }
}
