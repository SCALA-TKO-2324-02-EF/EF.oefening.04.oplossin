using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using EF.bereken;

namespace EF.oefening._04.oplossin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
            TxtGetal.Focus();
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            if (uint.TryParse(TxtGetal.Text, out uint getal)) {
                if (getal < 1 || getal > 60)
                {
                    FoutMelding();
                }
                else
                {
                    Faculteit faculteit = new Faculteit();
                    ulong resultaat = faculteit.Bereken(getal);
                    TxtResultaat.Text = resultaat.ToString();
                }
            }
            else
            {
                FoutMelding();
            }
        }

        private void FoutMelding()
        {
                MessageBox.Show("Getal moet een positief geheel getal zijn kleiner dan of gelijk aan 60", "Foutief getal");
                TxtGetal.Text = "";
                TxtGetal.Focus();
        }
    }
}