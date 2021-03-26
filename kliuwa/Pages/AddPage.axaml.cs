using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace kliuwa.Pages
{
    public class AddPage : UserControl
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
