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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace passwordcheck
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string pass = "kst1337";
            if(tbPass1.Text == pass)
            {
                lblPass.Visibility = Visibility.Hidden;
                tbPass1.Visibility = Visibility.Hidden;
                btnOK.Visibility = Visibility.Hidden;

            }
            else
            {
                MessageBox.Show("Пароль невэрный!");
            }
        }

        private void btnEd1_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void btnAdd1_Click(object sender, RoutedEventArgs e)
        {
            tbMove.AppendText(tbStr.Text + Environment.NewLine);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEd1_Click(object sender, RoutedEventArgs e)
        {
            tbMove.IsEnabled = true;
        }

        private void btMv1_Click(object sender, RoutedEventArgs e)
        {
            string text = ((ListBoxItem)lbDay.SelectedItem).Content.ToString();

            tbMove.AppendText(text + Environment.NewLine);
        }

        private void tbMove_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbMove.IsReadOnly = true;
        }

        private void btnCH_Click(object sender, RoutedEventArgs e)
        {
            dp1.Visibility = Visibility.Visible;
        }
    }
}
