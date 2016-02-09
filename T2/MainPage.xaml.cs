using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double euroToMarkka, markkaToEuro;
        bool result, changing;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void euroTextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            changing = true;
        }
        private void markkaTextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            changing = true;
        }

        private void markkaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (changing)
            {
                if (markkaTextBox.Text.Length > 0)
                {
                    result = Double.TryParse(markkaTextBox.Text, out markkaToEuro);
                    if (result)
                    {
                        markkaToEuro = Convert.ToDouble(markkaTextBox.Text);
                        markkaToEuro = markkaToEuro / 5.94573;
                    }
                    else
                    {
                        markkaToEuro = 0;
                    }
                }
                else
                {
                    markkaToEuro = 0;
                }
                euroTextBox.Text = markkaToEuro.ToString("0.00");
                changing = false;
            }
        }

        private void euroTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (changing)
            {
                if (euroTextBox.Text.Length > 0)
                {
                    result = Double.TryParse(euroTextBox.Text, out euroToMarkka);
                    if (result)
                    {
                        euroToMarkka = Convert.ToDouble(euroTextBox.Text);
                        euroToMarkka = euroToMarkka * 5.94573;
                    }
                    else
                    {
                        euroToMarkka = 0;
                    }
                }
                else
                {
                    euroToMarkka = 0;
                }
                markkaTextBox.Text = euroToMarkka.ToString("0.00");
                changing = false;
            }
        }
    }
}
