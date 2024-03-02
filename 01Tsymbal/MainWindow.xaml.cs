using System.Windows;

namespace _01Tsymbal;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ViewModel _vm;

    public MainWindow()
    {
        InitializeComponent();
        _vm = new ViewModel(OnDataInputInvalid);
        this.DataContext = _vm;
    }
    private void OnDataInputInvalid(object? sender, DateInputValidator e)
    {
        MessageBox.Show(e.ErrorMsg);
    }
}