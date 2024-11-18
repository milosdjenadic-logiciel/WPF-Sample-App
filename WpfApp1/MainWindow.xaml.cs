using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<Window> _windows = new();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenWpfOnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            for (int i = 0; i <= 100; i++)
            {
                var w = new TestWindow();
                _windows.Add(w);
                w.Show();
            }
            
            Activate();
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.ToString());
        }
    }

    private void CloseEvent(object sender, RoutedEventArgs e)
    {
        foreach (var w in _windows)
        {
            w.Close();
        }
        
        _windows.Clear();
    }

    private void OpenDevexpressOnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            for (int i = 0; i <= 50; i++)
            {
                var w = new DevexpressWindow();
                _windows.Add(w);
                w.Show();
            }
            
            Activate();
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.ToString());
        }
    }
}