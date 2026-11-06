using System;
using System.Windows;

namespace WpfApp6
{
    public partial class CaptchaWindow : Window
    {
        private string currentCaptcha;

        public CaptchaWindow()
        {
            InitializeComponent();
            GenerateCaptcha(); 
        }

        private void GenerateCaptcha()
        {
            Random rnd = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] captchaArray = new char[10];

            for (int i = 0; i < 10; i++)
            {
                captchaArray[i] = chars[rnd.Next(chars.Length)];
            }

            currentCaptcha = new string(captchaArray);
            CaptchaTextBlock.Text = currentCaptcha;
            InputTextBox.Text = "";
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBox.Text == currentCaptcha)
            {
                DialogResult = true; 
            }
            else
            {
                MessageBox.Show("Неверно! Попробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                GenerateCaptcha(); 
            }
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            GenerateCaptcha();
        }
    }
}