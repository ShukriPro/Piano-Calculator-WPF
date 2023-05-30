using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Piano_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            resultLabel.Content += button.Content.ToString();

            string soundFilePath = "";

            if (button == btnC)
                soundFilePath = "cs.wav";
            else if (button == btnCE)
            {
                soundFilePath = "ds.wav";
                resultLabel.Content = "";
            }
            else if (button == btnPercent)
                soundFilePath = "fs.wav";
            else if (button == btnDivide)
                soundFilePath = "gs.wav";
            else if (button == btn7)
                soundFilePath = "c.wav";
            else if (button == btn8)
                soundFilePath = "d.wav";
            else if (button == btn9)
                soundFilePath = "e.wav";
            else if (button == btnMultiply)
                soundFilePath = "as.wav";
            else if (button == btn4)
                soundFilePath = "f.wav";
            else if (button == btn5)
                soundFilePath = "g.wav";
            else if (button == btn6)
                soundFilePath = "a.wav";
            else if (button == btnSubtract)
                soundFilePath = "cs.wav";
            else if (button == btn1)
                soundFilePath = "b.wav";
            else if (button == btn2)
                soundFilePath = "c.wav";
            else if (button == btn3)
                soundFilePath = "d.wav";
            else if (button == btnAdd)
                soundFilePath = "ds.wav";
            else if (button == btnDoubleZero)
                soundFilePath = "e.wav";
            else if (button == btnZero)
                soundFilePath = "f.wav";
            else if (button == btnDecimal)
                soundFilePath = "g.wav";
            else if (button == btnEquals)
                soundFilePath = "fs.wav";

            if (!string.IsNullOrEmpty(soundFilePath))
            {
                SoundPlayer soundPlayer = new SoundPlayer(soundFilePath);
                soundPlayer.Play();
            }


        }
        private string[] buttonContents = { "Do", "C#", "No" };
        private int currentContentIndex = 0;
        private void Button_Change(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentContentIndex = (currentContentIndex + 1) % buttonContents.Length;
            button.Content = buttonContents[currentContentIndex];

            if (button.Content == "C#")
            {
                btnC.Content = "C#";
                btnCE.Content = "D#";
                btnPercent.Content = "F#";
                btnDivide.Content = "G#";

                btn7.Content = "C";
                btn8.Content = "D";
                btn9.Content = "E";
                btnMultiply.Content = "A#";

                btn4.Content = "F";
                btn5.Content = "G";
                btn6.Content = "A";
                btnSubtract.Content = "C#";

                btn1.Content = "B";
                btn2.Content = "C";
                btn3.Content = "D";
                btnAdd.Content = "D#";

                btnDoubleZero.Content = "E";
                btnZero.Content = "F";
                btnDecimal.Content = "G";
                btnEquals.Content = "F#";

            }
            if (button.Content == "Do")
            {
                btnC.Content = "Do#";
                btnCE.Content = "Re#";
                btnPercent.Content = "Fa#";
                btnDivide.Content = "Sol#";

                btn7.Content = "Do";
                btn8.Content = "Re";
                btn9.Content = "Mi";
                btnMultiply.Content = "La#";

                btn4.Content = "Fa";
                btn5.Content = "Sol";
                btn6.Content = "La";
                btnSubtract.Content = "Do#";

                btn1.Content = "Si";
                btn2.Content = "Do";
                btn3.Content = "Re";
                btnAdd.Content = "Re#";

                btnDoubleZero.Content = "Mi";
                btnZero.Content = "Fa";
                btnDecimal.Content = "Sol";
                btnEquals.Content = "Fa#";
            }
            if (button.Content == "No")
            {
                btnC.Content = "C";
                btnCE.Content = "CE";
                btnPercent.Content = "%";
                btnDivide.Content = "/";

                btn7.Content = "7";
                btn8.Content = "8";
                btn9.Content = "9";
                btnMultiply.Content = "*";

                btn4.Content = "4";
                btn5.Content = "5";
                btn6.Content = "6";
                btnSubtract.Content = "-";

                btn1.Content = "1";
                btn2.Content = "2";
                btn3.Content = "3";
                btnAdd.Content = "+";

                btnDoubleZero.Content = "00";
                btnZero.Content = "0";
                btnDecimal.Content = "/";
                btnEquals.Content = "=";
            }
        }
        private void EqualsButton_Clicked(object sender, RoutedEventArgs e)
        {
            string expression = resultLabel.Content.ToString();
            try
            {
                var dt = new DataTable();
                var result = dt.Compute(expression, "");
                resultLabel.Content = result.ToString();
            }
            catch (Exception ex)
            {
                // Handle any error that may occur during the calculation
                resultLabel.Content = "Error";
            }
        }
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            // Create a SoundPlayer using the sound file path for btnC
            string soundFilePath = "cs.wav";
            SoundPlayer soundPlayer = new SoundPlayer(soundFilePath);
            soundPlayer.Play();
        }
    }
}
