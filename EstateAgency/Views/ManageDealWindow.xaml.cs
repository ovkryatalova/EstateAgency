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

namespace EstateAgency.Views
{
    /// <summary>
    /// Логика взаимодействия для ManageDealWindow.xaml
    /// </summary>
    public partial class ManageDealWindow : Page
    {
        public ManageDealWindow()
        {
            InitializeComponent();
            LbAgents.ItemsSource = App.Context.PersonSet_Agent.ToList();
            LbAgents.SelectedIndex = 0;
        }

        private void LbDeals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
