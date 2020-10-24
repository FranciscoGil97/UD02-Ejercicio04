using System;
using System.Windows;
using System.Windows.Controls;

namespace UD02_Ejercicio04
{
    public partial class MainWindow : Window
    {
        private const int NUMERO_MAXIMO_CARACTERES = 140;
        public MainWindow()
        {
            InitializeComponent();
            contadorTextBlock.Text = $"{escribirTextBox.Text.Length}/{NUMERO_MAXIMO_CARACTERES}";
        }

        private void EscribirTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (escribirTextBox.Text.Length >= NUMERO_MAXIMO_CARACTERES)
            {
                escribirTextBox.Text = escribirTextBox.Text.Substring(0, NUMERO_MAXIMO_CARACTERES);
                escribirTextBox.IsReadOnly = true;
            }

            contadorTextBlock.Text = $"{escribirTextBox.Text.Length}/{NUMERO_MAXIMO_CARACTERES}";
        }
    }
}
