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

namespace WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TestViewModel viewModel;

        public MainWindow()
        {
            this.viewModel = new TestViewModel(new TestModel());
            viewModel.Title = "Hello World!";

            DataContext = this.viewModel;
            InitializeComponent();

            viewModel.Title = "Test Changing";
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            TestModel newModel = new TestModel
            {
                Title = "Hello world!"
            };
            this.viewModel = new TestViewModel(newModel);
            DataContext = this.viewModel;
        }
    }
}
