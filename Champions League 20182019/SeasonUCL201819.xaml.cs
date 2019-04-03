using Football_History.Photos.Matches.UCL_matches;
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
    /// Logika interakcji dla klasy SeasonUCL201819.xaml
    /// </summary>
    public partial class SeasonUCL201819 : Window
    {
        public SeasonUCL201819()
        {
            InitializeComponent();
        }
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            LiverpoolPSG32 use = new LiverpoolPSG32();
            use.Show();
        }

        private void ListBoxItem_SelectedBarca(object sender, RoutedEventArgs e)
        {
            BarcelonaPSV_40 use = new BarcelonaPSV_40();
            use.Show();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            CityLyon12 use = new CityLyon12();
            use.Show();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            TottenhamBarca_24 use = new TottenhamBarca_24();
            use.Show();
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            HoffenLyon_33 use = new HoffenLyon_33();
            use.Show();
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            AjaxBayern_33 use = new AjaxBayern_33();
            use.Show();
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            AtlecticoJuve_20 use = new AtlecticoJuve_20();
            use.Show();
        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            RealAjax_14 use = new RealAjax_14();
            use.Show();
        }

        private void ListBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            BarcaLyon_51 use = new BarcaLyon_51();
            use.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Champions_League use = new Champions_League();
            use.Show();
            this.Close();
        }
    }
}
