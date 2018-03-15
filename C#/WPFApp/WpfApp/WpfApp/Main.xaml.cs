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
using Services;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TicketService ticketService;

        public MainWindow()
        {
            InitializeComponent();

            ticketService = new TicketService();
            InitializeData();
        }

        private void InitializeData()
        {
            MainWindowViewModel data = new MainWindowViewModel();
            DateTime today = DateTime.Today;
            data.TotalRevenue = ticketService.GetTotalRevenue();
            data.TodayRevenue = ticketService.GetRevenue(today);
            data.YesterdayRevenue = ticketService.GetRevenue(today.AddDays(-1));

            this.DataContext = data;
        }
    }
}
