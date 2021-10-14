using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Button input
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetOutput(((Button) sender).Content.ToString());
        }

        // Control display limit
        private void SetOutput(String text)
        {
            if (Result.Text == "0")
            {
                Result.Text = text;
            }
            else if (Result.Text.Length < 12) // max length is 12 
            {
                Result.Text += text;
            }
        }

        // Make gui draggable
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        // '=' button
        private void Output_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                String input = Result.Text.Replace('×', '*');
                input = input.Replace('÷', '/');
                Result.Text = dt.Compute(input, "").ToString();
            }
            catch (Exception exception)
            {
                Result.Text = "ERROR";
            }
        }

        // '<' button
        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(Result.Text,  @"^[a-zA-Z]+$"))
            {
                Result.Text = "0";
                return;
            }
            Result.Text = (Result.Text == "" || Result.Text == "0") ? "0" : Result.Text.Remove(Result.Text.Length - 1);
            if (Result.Text == "")
            {
                Result.Text += "0";
            }
        }
        
        private void Clear_Button(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
        }

        // Close button
        private void CloseAction(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        // Maximize button
        private void MaximizeAction(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState =
                (Application.Current.MainWindow.WindowState == WindowState.Normal)
                    ? WindowState.Maximized
                    : WindowState.Normal;
        }
        
        // Minimize button
        private void MinimizeAction(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        
    }
}