using System.Windows;
using System.Windows.Input;

namespace WpfApplication1
{
    public partial class MainWindow
    {
        private void UIElement_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.Key)
            {
                //Process user input
                case Key.Enter:
                case Key.OemPlus:
                    Output_Click(sender, e);
                    break;
                
                case Key.NumPad0:
                case Key.D0:
                    SetOutput("0");
                    break;
                
                case Key.NumPad1:
                case Key.D1:
                    SetOutput("1");
                    break;
                
                case Key.NumPad2:
                case Key.D2:
                    SetOutput("2");
                    break;
                
                case Key.NumPad3:
                case Key.D3:
                    SetOutput("3");
                    break;
                
                case Key.NumPad4:
                case Key.D4:
                    SetOutput("4");
                    break;
                
                case Key.NumPad5:
                case Key.D5:
                    SetOutput("5");
                    break;
                
                case Key.NumPad6:
                case Key.D6:
                    SetOutput("6");
                    break;
                
                case Key.NumPad7:
                case Key.D7:
                    SetOutput("7");
                    break;
                
                case Key.NumPad8:
                case Key.D8:
                    SetOutput("8");
                    break;
                
                case Key.NumPad9:
                case Key.D9:
                    SetOutput("9");
                    break;
                
                case Key.Decimal:
                case Key.OemPeriod:
                    SetOutput(".");
                    break;
                
                // '<' key
                case Key.Back:
                    Delete_Button(sender, e);
                    break;
                
                // '+' key
                case Key.Add:
                    SetOutput("+");
                    break;
                
                // '-' 
                case Key.OemMinus:
                case Key.Subtract:
                    SetOutput("-");
                    break;
                
                // '×'
                case Key.Multiply:
                    SetOutput("×");
                    break;
                
                // '÷'
                case Key.Divide:
                    SetOutput("÷");
                    break;
                
                // Del key
                case Key.Delete:
                    Result.Text = "0";
                    break;
            }
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}