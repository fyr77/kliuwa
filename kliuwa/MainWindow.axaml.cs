using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.IO;
using System.IO.Compression;

namespace kliuwa
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadPlace();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void LoadPlace()
        {
            string tempPath = Path.GetTempPath() + "kliuwa-" + Path.GetRandomFileName() + "\\";
            DirectoryInfo tempDirInfo = Directory.CreateDirectory(tempPath);



            tempDirInfo.Delete(true); //Cleanup
        }
    }
}
