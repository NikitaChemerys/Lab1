using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Lab1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void showMessClick1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is my default message");
        }

        private void showMessClick2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is my another default message");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showMessClick(object sender, RoutedEventArgs e)
        {
            string str = textEnter.Text;
            MessageBox.Show(str);
        }

        private void doOperationClick(object sender, RoutedEventArgs e)
        {
            string operation = comboBox.Text;


            if (operation == "Clear field")
            {
                textEnter.Text = String.Empty;
            }
            else if (operation == "Copy text")
            {
                Clipboard.SetText(textEnter.Text);
            }
            else if (operation == "Paste text")
            {

                textEnter.Text = Clipboard.GetText();
            }
        }

        private void showProgActCheck(object sender, RoutedEventArgs e)
        {
            comboBox.Visibility = Visibility.Visible;
            doOperation.Visibility = Visibility.Visible;
        }
        private void showProgActUncheck(object sender, RoutedEventArgs e)
        {
            comboBox.Visibility = Visibility.Hidden;
            doOperation.Visibility = Visibility.Hidden;
        }

        private void showMessActCheck(object sender, RoutedEventArgs e)
        {
            showMessage.Visibility = Visibility.Visible;
            textEnter.Visibility = Visibility.Visible;
            showMess1.Visibility = Visibility.Visible;
            showMess2.Visibility = Visibility.Visible;
        }
        private void showMessActUncheck(object sender, RoutedEventArgs e)
        {
            showMessage.Visibility = Visibility.Hidden;
            textEnter.Visibility = Visibility.Hidden;
            showMess1.Visibility = Visibility.Hidden;
            showMess2.Visibility = Visibility.Hidden;
        }

        private void enableMessActCheck(object sender, RoutedEventArgs e)
        {
            textEnter.IsEnabled = true;
            showMessage.IsEnabled = true;
            showMess1.IsEnabled = true;
            showMess2.IsEnabled = true;
        }
        private void enableMessActUncheck(object sender, RoutedEventArgs e)
        {
            textEnter.IsEnabled = false;
            showMessage.IsEnabled = false;
            showMess1.IsEnabled = false;
            showMess2.IsEnabled = false;
        }

        private void enableProgActCheck(object sender, RoutedEventArgs e)
        {
            comboBox.IsEnabled = true;
            doOperation.IsEnabled = true;
        }
        private void enableProgActUncheck(object sender, RoutedEventArgs e)
        {
            comboBox.IsEnabled = false;
            doOperation.IsEnabled = false;
        }
        private void enableGroupsCheck(object sender, RoutedEventArgs e)
        {
            showM_A.IsEnabled = false;
            showP_A.IsEnabled = false;
            enableM_A.IsEnabled = false;
            enableP_A.IsEnabled = false;
        }
        private void enableGroupsUncheck(object sender, RoutedEventArgs e)
        {
            showM_A.IsEnabled = true;
            showP_A.IsEnabled = true;
            enableM_A.IsEnabled = true;
            enableP_A.IsEnabled = true;
        }

        private void sysPathClick(object sender, RoutedEventArgs e)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uriBuilder = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uriBuilder.Path);
            path = System.IO.Path.GetDirectoryName(path);
            MessageBox.Show(path);
        }
    }

}