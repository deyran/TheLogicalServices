using IntellectusSecretaria.Areas.MapaNotas.MVVM.Views;

namespace IntellectusSecretaria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MapaNotasView();

        }

       protected override Window CreateWindow(IActivationState activationState)
        {
            Window window = base.CreateWindow(activationState);

            //window.X = 100;
            //window.Y = 200;

           // Obter a resolução do monitor principal
           // var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
           // var screenWidth = mainDisplayInfo.Width;
           // var screenHeight = mainDisplayInfo.Height;

            // Ajustar o tamanho da janela com base na resolução
           // window.Width = screenWidth;
            //window.Height = screenHeight;

            return window;
        }
    }
}
