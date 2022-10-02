using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp_Controls.Model;

namespace WpfApp_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<string> Items { get; set; }
        public ObservableCollection<Person> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Items = new ObservableCollection<Person>();
            Items.Add(new Person() { Name = "Vladimir", Phone = "25-36-84"});
            Items.Add(new Person() { Name = "Alexandr", Phone = "44-36-88"});
            Items.Add(new Person() { Name = "Victor", Phone = "28-45-31"});
           

            comboBox.ItemsSource = Items;
            ListBox.ItemsSource = Items;

            //comboBox.Items.Add("One");
            //comboBox.Items.Add("Two");
            //comboBox.Items.Add("Three");

        }

        private void ItenAddButton_Click(object sender, RoutedEventArgs e)
        {
            var text = ItemTextBox.Text;
            Items.Add(new Person() {Phone = "000", Name = text});
            ItemTextBox.Text = string.Empty;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    textBlockResult.Text = texBoxText.Text;
        //    MessageBox.Show(textBlockResult.Text);
        //}
    }
}
