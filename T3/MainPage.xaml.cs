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

namespace T3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double height, lenght, width, area, glassArea, cirlce;
        bool result;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laskuButton_Click(object sender, RoutedEventArgs e)
        {
            result = Double.TryParse(leveysTextBox.Text, out lenght);
            if (result)
            {
                result = Double.TryParse(korkeusTextBox.Text, out height);
                if (result)
                {
                    area = lenght * height;
                    cirlce = (lenght * 2) + (height * 2);

                    result = Double.TryParse(karmiTextBox.Text, out width);
                    if(result)
                    {
                        height = height - (width*2);
                        lenght = lenght - (width*2);
                        glassArea = height * lenght;
                    }
                    else
                    {
                        glassArea = 0;
                    }
                }
                else
                {
                    area = 0;
                    glassArea = 0;
                    cirlce = 0;
                }
            }
            else
            {
                area = 0;
                glassArea = 0;
                cirlce = 0;
            }

            iPATextBox.Text = area.ToString("0.0");
            lPATextBox.Text = glassArea.ToString("0.0");
            piiriTextBox.Text = cirlce.ToString("0.0");
        }
    }
}
