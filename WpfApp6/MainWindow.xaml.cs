using System.Windows;

namespace WpfApp6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCaptcha_Click(object sender, RoutedEventArgs e)
        {
            CaptchaWindow captcha = new CaptchaWindow();
            if (captcha.ShowDialog() == true)
            {
                MessageBox.Show("Капча введена верно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.Owner = this; 
            settings.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите закрыть окно?", "Подтверждение",
                                                      MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true; 
            }
        }
    }
}