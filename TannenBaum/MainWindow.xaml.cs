using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TannenBaum
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();   
        }

        private void button_zeichnen_Click(object sender, RoutedEventArgs e)
        {
            Model model = new Model();
            int zahl = Convert.ToInt32(tb_eingabe.Text);
            if (radio_down.IsChecked == true)
            {
                textBlock_block.Text = model.Down(zahl);
            }
            else if (radio_up.IsChecked == true)
            {
                textBlock_block.Text = model.Up(zahl);
            }
            else if (radio_tannenbaum.IsChecked == true)
            {
                textBlock_block.Text = model.TannenBaum(zahl);
            }
            else
            {
                textBlock_block.Text = "Bitte Wählen Sie eins der Folgenden möglichkeiten aus. und Geben sie eine Zahl in die Eingabe ein!";
            }
            //StartAnimation();
            StartGlowAnimation();

        }

        private async void StartAnimation()
        {
            int i = 140;
            bool increasing = true;

            while (true)
            {
                textBlock_block.Foreground = new SolidColorBrush(Color.FromRgb(0, (byte)i, 0));
                await Task.Delay(500);

                if (increasing)
                {
                    i++;
                    if (i > 200) increasing = false;
                }
                else
                {
                    i--;
                    if (i < 140) increasing = true;
                }
            }
            
        }

        private void StartGlowAnimation()
        {
            textBlock_block.Effect = new DropShadowEffect
            {
                Color = Colors.LightGreen,
                BlurRadius = 10,
                ShadowDepth = 0
            };

            DropShadowEffect glowEffect = (DropShadowEffect)textBlock_block.Effect;

            var blurAnimation = new DoubleAnimation
            {
                From = 10,
                To = 30,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            var colorAnimation = new ColorAnimation
            {
                From = Colors.LightGreen,
                To = Colors.LightSeaGreen,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            glowEffect.BeginAnimation(DropShadowEffect.BlurRadiusProperty, blurAnimation);
            glowEffect.BeginAnimation(DropShadowEffect.ColorProperty, colorAnimation);

            StartAnimation();

        }


    }
}
