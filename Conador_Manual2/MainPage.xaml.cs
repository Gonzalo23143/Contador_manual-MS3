using Conador_Manual2.NewFolder;

namespace Conador_Manual2
{
    public partial class MainPage : ContentPage
    {
        // Conteo lleva el conteo en la aplicacion
        private Class1 contador;
        public MainPage()
        {
            InitializeComponent();
            contador = new Class1();
            ConteoLabel.Text = contador.Conteo.ToString();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            contador.Contar();
            ConteoLabel.Text = contador.Conteo.ToString();
            

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            contador.Reiniciar();
            ConteoLabel.Text = contador.Conteo.ToString();

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
          
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
           
        }
    }
}
