using Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class RevenueReport : Page
    {
        private readonly TicketService ticketService;
        private RevenueReportViewModel dataContext;

        public RevenueReport()
        {
            InitializeComponent();

            ticketService = new TicketService();
            InitializeData();
        }

        private void InitializeData()
        {
            dataContext = new RevenueReportViewModel();
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
