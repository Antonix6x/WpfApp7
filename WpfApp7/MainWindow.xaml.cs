using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pocztowka_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void list_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void paczka_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void sprawdz_cene_Click(object sender, RoutedEventArgs e)
        {
            if (pocztowka.IsChecked == true)
            {
                cena.Text = "Cena: 1zł";
                obaz.Source = new BitmapImage(new Uri("/images.png", UriKind.Relative));
            }
            else if (list.IsChecked == true)
            {

                cena.Text = "cena: 10zł";
                obaz.Source = new BitmapImage(new Uri("/list.jpg", UriKind.Relative));


            }
            else
            {
                cena.Text = "cena: 12zł";
                obaz.Source = new BitmapImage(new Uri("/paczka.png", UriKind.Relative));
            }
        }

        private void zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            int wynik;
            //bool czyLiczba = int.TryParse(wynik.ToString(), out wynik);
        }
    }
}