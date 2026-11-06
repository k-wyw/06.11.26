using System.Windows;
using System.Windows.Media;

namespace WpfApp6
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void BtnRed_Click(object sender, RoutedEventArgs e)
        {
            Owner.Background = (Brush)new BrushConverter().ConvertFromString("#FFDDDD");
        }

        private void BtnGreen_Click(object sender, RoutedEventArgs e)
        {
            Owner.Background = (Brush)new BrushConverter().ConvertFromString("#D9D28B"); 
        }

        private void BtnBlue_Click(object sender, RoutedEventArgs e)
        {
            Owner.Background = (Brush)new BrushConverter().ConvertFromString("#8AD6D1");
        }

        private void BtnWhite_Click(object sender, RoutedEventArgs e)
        {
            Owner.Background = Brushes.White;
        }

        private void WidthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Owner != null) Owner.Width = WidthSlider.Value;
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Owner != null) Owner.Height = HeightSlider.Value;
        }
    }
}