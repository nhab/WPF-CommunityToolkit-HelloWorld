using System.Windows;
using ViewModels;

namespace auxalia_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel("c:\\autodesk");
           
            InitializeComponent();
        }

        
    }
}
