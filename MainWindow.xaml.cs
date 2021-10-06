using System.Collections.ObjectModel;
using System.Windows;

namespace TestBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Item = new("Item numer 1");
            Items.Add(new ViewModel("item number 2"));
            this.DataContext = this;
            InitializeComponent();
        }

        public ViewModel Item { get; }
        public ObservableCollection<ViewModel> Items { get; } = new();

    }
}
