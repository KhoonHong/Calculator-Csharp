using System.Windows;
using System.Windows.Input;

namespace WpfApplication1
{
    public partial class MainWindow
    {
        private void UIElement_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.Key == Key.Enter || e.Key == Key.OemPlus)
            {
                //Process user input
                Output_Click(sender, e);
            }
            else if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                SetOutput("0");
            }
            else if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                SetOutput("1");
            }
            else if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                SetOutput("2");
            }
            else if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                SetOutput("3");
            }
            else if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                SetOutput("4");
            }
            else if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                SetOutput("5");
            }
            else if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                SetOutput("6");
            }
            else if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                SetOutput("7");
            }
            else if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                SetOutput("8");
            }
            else if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                SetOutput("9");
            }
            else if (e.Key == Key.Decimal || e.Key == Key.OemPeriod)
            {
                SetOutput(".");
            }
            // '<' key
            else if (e.Key == Key.Back)
            {
                Delete_Button(sender, e);
            }
            // '+' key
            else if (((Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) && Keyboard.IsKeyDown(Key.OemPlus)) || e.Key == Key.Add)
            {
                SetOutput("+");
            }
            // '-'
            else if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
            {
                SetOutput("-");
            }
            // '×'
            else if (e.Key == Key.Multiply || (e.Key == Key.LeftShift || e.Key == Key.RightShift) && e.Key == Key.D8)
            {
                SetOutput("×");
            }
            // '÷'
            else if (e.Key == Key.Divide || (e.Key == Key.LeftShift || e.Key == Key.RightShift) && e.Key == Key.OemQuestion)
            {
                SetOutput("÷");
            }
            // Del key
            else if (e.Key == Key.Delete)
            {
                Result.Text = "0";
            }
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}