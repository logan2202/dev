using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace juste_prix
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int aleatoire = new Random().Next(1, 50);
        int tentative = 0;

        private void valider_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxValue.Text.Trim();
            int number = Int32.Parse(name);
            if (number > aleatoire)
            {
                tentative ++;
                MessageBox.Show("c'est plus petit");
            }
            else if (number < aleatoire)
            {
                tentative ++;
                MessageBox.Show("c'est plus grand");
            }
            else if (number == aleatoire)
            {
                tentative ++;
                MessageBox.Show("Bravo, vous avez gagné en " + tentative + " fois");
            }
        }
    }
}
