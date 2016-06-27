using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFSkeletonIDE.Views.Panes
{
    /// <summary>
    /// ErrorListPane.xaml の相互作用ロジック
    /// </summary>
    public partial class ErrorListPane : UserControl
    {
        public ErrorListPane()
        {
            InitializeComponent();
        }

        class ErrorItem
        {
            public int Code { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
        }

        CollectionViewSource view = new CollectionViewSource();
        ObservableCollection<ErrorItem> customers = new ObservableCollection<ErrorItem>();

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            int itemcount = 3;
            for (int j = 0; j < itemcount; j++)
            {
                customers.Add(new ErrorItem()
                {
                    Code = j,
                    Description = "Test",
                    Location="Test.cs",
                });
            }

            view.Source = customers;
            this.listView1.DataContext = view;
        }
    }
}
