using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
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
namespace WpfApp1
{
    /// <summary>
    /// floateraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Butoon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float result = num1 / num2;
                label3.Content = result.ToString();
            }
            catch (DivideByZeroException)
            {
                label3.Content = "Cannot didvide by zero.";
            }
            catch (FormatException)
            {
                label3.Content = "Please enter only non-decimal number.";
            }
            catch (Exception ex)
            {
                label3.Content = ex.GetType() + ":" + ex.Message;
            }
           


        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
