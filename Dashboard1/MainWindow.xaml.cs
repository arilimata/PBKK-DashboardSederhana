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

namespace Dashboard1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Consumption consumption = new Consumption();
            DataContext = new ConsumptionViewModel(consumption);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HeadBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }

    internal class ConsumptionViewModel
    {
        public List<Consumption> Consumption { get; private set; }

        public ConsumptionViewModel(Consumption consumo)
        {
            Consumption = new List<Consumption>();
            Consumption.Add(consumo);
        }
    }

    internal class Consumption
    {
        public string Title { get; private set; }
        public int Percentage { get; private set; }

        public Consumption()
        {
            Title = "Actual Consumption";
            Percentage = CalcularPorcentage();
        }

        private int CalcularPorcentage()
        {
            return 47;
        }
    }
}
