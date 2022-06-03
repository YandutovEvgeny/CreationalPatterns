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

namespace Factory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Menu menu;
        KitchenFactory kitchen;
        public MainWindow()
        {
            InitializeComponent();
            menu = new Menu();
            kitchen = new KitchenFactory();

            foreach (IEatable item in menu.MyMenu)
            {
                listBox.Items.Add(item.GetName());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
                MessageBox.Show(kitchen.GetEat(listBox.SelectedIndex).GetInfo());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
                MessageBox.Show(kitchen.GetEat(listBox.SelectedIndex).Eat());
        }
    }
}
