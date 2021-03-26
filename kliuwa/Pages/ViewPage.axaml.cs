using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace kliuwa.Pages
{
    public class ViewPage : UserControl
    {
        public ViewPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
