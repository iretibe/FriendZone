using FriendZone.UI.ViewModels;
using System.Windows;

namespace FriendZone.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _mainViewModel;

        public MainWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;
            DataContext = _mainViewModel;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _mainViewModel.Load();
        }
    }
}
