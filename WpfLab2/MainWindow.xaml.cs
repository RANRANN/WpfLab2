using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace WpfLab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Top = Properties.Settings.Default.Position.Top;//Делаю открытие приложения в старом месте
            this.Left = Properties.Settings.Default.Position.Left;
            this.Height = Properties.Settings.Default.Position.Height;
            this.Width = Properties.Settings.Default.Position.Width;

            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }

            //foreach (UIElement el2 in MainRoot2.Children)
            //{
            //    if (el2 is Button)
            //    {
            //        ((Button)el2).Click += Button2_Click;
            //    }
            //}

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "CE")
                textLabel.Text = "";
            else if(str == "C")
            {
                textLabel.Text = "";

            }
            else if (str == "←")
            {
                string value = new StringBuilder().Remove( , 1);
                textLabel.Text = value;
            }

            else if (str == "%")
            {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }

            else if (str == "1/ꭕ")
            {
                //string value = 1/sender;
                //textLabel.Text = value;
            }
            else if (str == "ꭕ²")
            {
                //string value = new Convert();
                //textLabel.Text = value;
            }
            else if (str == "√ꭕ")
            {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }
            else if (str == "+/-")
            {
                string value = "-"+str;
                textLabel.Text = value;
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }
            else
                textLabel.Text += str; 

        }
        //private void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    string str = (string)((Button)e.OriginalSource).Content;

        //    if (str == "CE")
        //        textLabel2.Text = "";
        //    else if (str == "=")
        //    {
        //        string value = new DataTable().Compute(textLabel2.Text, null).ToString();
        //        textLabel2.Text = value;
        //    }
        //    else
        //        textLabel2.Text += str;
        //}



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Position = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }



        private void NormalExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void IngExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Справочник готов");
        }

        private void ContactsExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Домашняя страница");
        }
    }
}
