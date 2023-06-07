using System.Collections.ObjectModel;
using UnoAppSVGBug.Models;

namespace UnoAppSVGBug
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<TestModel> Models { get; set; } = new ObservableCollection<TestModel>();
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 27; i++)
            {
                if (i % 3 == 0)
                {
                    Models.Add(new TestModel { AccountSVGIcon = new Uri("ms-appx:///Assets/UnoLogo.svg", UriKind.Absolute), Issuer = "User_" + i, Label = i+ " Label", LogoExists = true });
                }
                if (i % 4 == 0)
                {
                    Models.Add(new TestModel { AccountSVGIcon = new Uri("ms-appx:///Assets/rainbowflag.svg"), Issuer = "User_" + i, Label = i + " Label", Color = "Red", LogoExists = true });
                }
                else
                {
                    Models.Add(new TestModel { Issuer = "User_" + i, Label = i + " Label", Color = "Purple", AccountSVGIcon = null });
                }
            }
        }
    }
}