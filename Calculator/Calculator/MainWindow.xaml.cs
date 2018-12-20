
using System.Windows;
using System.Windows.Controls;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            App.calculatorViewModel = new CalculatorViewModel();           
            this.DataContext = App.calculatorViewModel;
            
        }

        
    }
}
