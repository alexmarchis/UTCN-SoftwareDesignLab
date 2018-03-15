using System;
using System.Windows;
using Services;

namespace WpfApp
{
    public partial class MainWindow
    {
        private readonly TicketService ticketService;
        private MainWindowDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            ticketService = new TicketService();
            InitializeData();
        }

        private void InitializeData()
        {
            dataContext = new MainWindowDataContext();
            this.DataContext = dataContext;
            CalculateRevenue();
        }

        private void CalculateRevenue()
        {
            DateTime today = DateTime.Today;
            dataContext.TotalRevenue = ticketService.GetTotalRevenue();
            dataContext.TodayRevenue = ticketService.GetRevenue(today);
            dataContext.YesterdayRevenue = ticketService.GetRevenue(today.AddDays(-1));
        }

        private void OnRecalculate(object sender, RoutedEventArgs routedEventArgs)
        {
            CalculateRevenue();
        }
    }
}
