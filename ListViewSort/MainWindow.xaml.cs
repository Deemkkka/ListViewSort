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
using System.ComponentModel;

namespace ListViewSort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User[] Users = new User[]
            {
                new User("Misha", "Russia", 12),
                new User("Dima", "Russia", 14),
                new User("Misha", "America", 22),
                new User("Oleg", "Russia", 16),
                new User("Misha", "Russia", 21),
                new User("Misha", "Brazil", 12),
                new User("Sergey", "Russia", 53),
                new User("Misha", "Africa", 24),
                new User("Misha", "Russia", 32)
            };

        public MainWindow()
        {
            InitializeComponent();

            //заполнили ListView массивом данных
            ListViewData.ItemsSource = Users;

            comboBoxChooseTopic.ItemsSource = new string[] { "name", "country", "age" };
            comboBoxSortAscDesc.ItemsSource = Enum.GetNames<ListSortDirection>();

            comboBoxChooseTopic.SelectionChanged += SelectionChanged;
            comboBoxSortAscDesc.SelectionChanged += SelectionChanged;

            ListViewData.Items.SortDescriptions.Add(new SortDescription("name", ListSortDirection.Ascending));
        }

       

        public void SortList()
        {
            var SortProperty = comboBoxChooseTopic.SelectedItem.ToString();
            var SortDirection = comboBoxSortAscDesc.SelectedItem.ToString() == "Ascending" ? ListSortDirection.Ascending : ListSortDirection.Descending;

            ListViewData.Items.SortDescriptions[0] = new SortDescription(SortProperty, SortDirection);
        }


        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SortList();
        }
    }
}
