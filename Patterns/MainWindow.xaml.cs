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

namespace Patterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       Singletone serialize1, serialize2, x, y;

        public MainWindow()
        {
            InitializeComponent();
            serialize1 = Singletone.GetObject();
            serialize2 = Singletone.GetObject();
            x = Singletone.GetObject();
            Clonator3000cs clonator3000 = new Clonator3000cs();
            y = (Singletone)clonator3000.Clone(x);
        }

        //Singletone
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(serialize2.GetCount().ToString());
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
           MessageBox.Show(serialize1.GetCount1().ToString());
        }

        //Prototype
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Prototype yandut = new Prototype() 
            { 
                Name = "Яндут", 
                Age = 21, 
                Home = "Айги 15/10", 
                Work = "Тракторостроителей 103А",
                BirthDay = new Data() { Day = 15, Month = 12,Year = 2000}
            };

            //Prototype yandut2 = yandut.Clone();
            Clonator3000cs clonator3000 = new Clonator3000cs();
            Prototype yandut2 = (Prototype)clonator3000.Clone(yandut);

            yandut2.Age = 63;
            yandut2.BirthDay.Year = 1990;
            MessageBox.Show(yandut2.GetInfo() + "\n\n\n" + yandut.GetInfo());
        }

        //Эксперимент с клонированием объекта паттерна Singletone
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(x.GetCount().ToString());
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(y.GetCount1().ToString());
        }
    }
}
