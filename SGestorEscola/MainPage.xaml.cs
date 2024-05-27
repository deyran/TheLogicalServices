using SGestorEscola.Models;

namespace SGestorEscola
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            new Boletim().CreatePDF();
        }
    }

}
