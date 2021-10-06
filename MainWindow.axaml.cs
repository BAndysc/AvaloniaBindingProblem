using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaBindingProblem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            Item = new("Item numer 1");
            Items.Add(new ViewModel("item number 2"));
            this.DataContext = this;
        }
        
        public ViewModel Item { get; }
        public ObservableCollection<ViewModel> Items { get; } = new();

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}