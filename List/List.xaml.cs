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
using System.Windows.Shapes;

namespace Football_History
{
    /// <summary>
    /// Logika interakcji dla klasy List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List()
        {
            InitializeComponent();
        }

        private void Champions_Click(object sender, RoutedEventArgs e)
        {
            Champions_League use = new Champions_League();
            use.Show();
            this.Close();
        }

        private void Premier_Click(object sender, RoutedEventArgs e)
        {
            PremierLeague use = new PremierLeague();
            use.Show();
            this.Close();
        }

        private void Bundesliga_Click(object sender, RoutedEventArgs e)
        {
            Bundesliga use = new Bundesliga();
            use.Show();
            this.Close();
        }

        private void LaLiga_Click(object sender, RoutedEventArgs e)
        {
            LaLiga use = new LaLiga();
            use.Show();
            this.Close();
        }

        private void Ligue1_Click(object sender, RoutedEventArgs e)
        {
            Ligue1 use = new Ligue1();
            use.Show();
            this.Close();
        }

        private void SeriaA_Click(object sender, RoutedEventArgs e)
        {
            SeriaA use = new SeriaA();
            use.Show();
            this.Close();
        }
    }
}
