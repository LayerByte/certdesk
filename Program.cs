using System.Windows;

namespace LayerByte.Certdesk;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        var app = new App();
        app.Run(new Views.MainWindow());
    }
}
