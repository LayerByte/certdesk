using System.Collections.ObjectModel;
using System.Windows;
using LayerByte.Certdesk.Models;
using LayerByte.Certdesk.Services;

namespace LayerByte.Certdesk.Views;

public partial class MainWindow : Window
{
    public ObservableCollection<ReportItem> Items { get; }

    public MainWindow()
    {
        InitializeComponent();
        Items = new SecurityReportService().BuildReport();
        DataContext = this;
    }
}
