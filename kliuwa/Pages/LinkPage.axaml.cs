using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace kliuwa.Pages
{
    public class LinkPage : UserControl
    {
        public LinkPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
