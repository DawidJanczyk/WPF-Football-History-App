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
using Football_History.Photos.Matches.BPL_matches.Matches_2019_2018;

namespace Football_History.Photos.Matches.BPL_matches
{
    /// <summary>
    /// Logika interakcji dla klasy BPL_20182019.xaml
    /// </summary>
    public partial class BPL_20182019 : Window
    {
        public BPL_20182019()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PremierLeague use = new PremierLeague();
            use.Show();
            this.Close();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            ArsenalTottenham42 use = new ArsenalTottenham42();
            use.Show();
        }

        private void ListBoxItem_Selected0(object sender, RoutedEventArgs e)
        {
            ChealseaCity20 use = new ChealseaCity20();
            use.Show();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            CityArsenal31 use = new CityArsenal31();
            use.Show();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            TottenhamWolves13 use = new TottenhamWolves13();
            use.Show();
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            LiverpoolTottenham21 use = new LiverpoolTottenham21();
            use.Show();
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            CityLiverpool21 use = new CityLiverpool21();
            use.Show();
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            LiverpoolCrystal43 use = new LiverpoolCrystal43();
            use.Show();
        }
    }
}
