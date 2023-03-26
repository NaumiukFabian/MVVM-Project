using ReportB2C.ViewModels;
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

namespace ReportB2C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowVM mainWindowVM, DeliveryRaportVM deliveryRaportVM, EpuVM epuVM, EpuMailVM epuMailVM, GeneratorAisocrVM generatorAisocrVM)
        {
            InitializeComponent();
            MainPanel.DataContext = mainWindowVM;
            DeliveryPanel.DataContext = deliveryRaportVM;
            EpuPanel.DataContext = epuVM;
            EpuMailPanel.DataContext = epuMailVM;
            EpuTabs.DataContext = epuVM;
            GeneratorAis.DataContext = generatorAisocrVM;
        }

    }
}
