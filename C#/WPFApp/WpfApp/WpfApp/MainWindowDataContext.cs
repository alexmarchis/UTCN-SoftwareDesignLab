using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp
{
    public class MainWindowDataContext : INotifyPropertyChanged
    {
        private int totalRevenue;
        private int todayRevenue;
        private int yesterdayRevenue;

        public int TotalRevenue
        {
            get { return totalRevenue; }
            set
            {
                totalRevenue = value;
                OnPropertyChanged();
            }
        }

        public int TodayRevenue
        {
            get { return todayRevenue; }
            set
            {
                todayRevenue = value; 
                OnPropertyChanged();
            }
        }

        public int YesterdayRevenue
        {
            get { return yesterdayRevenue; }
            set
            {
                yesterdayRevenue = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
