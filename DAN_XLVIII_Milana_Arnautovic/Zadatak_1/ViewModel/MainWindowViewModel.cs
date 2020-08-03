using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;

namespace Zadatak_1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        MainWindow main;
        Service service = new Service();

        #region Property

        private vwOrder ordered;
        public vwOrder Ordered
        {
            get
            {
                return ordered;
            }
            set
            {
                ordered = value;
                OnPropertyChanged("Ordered");
            }
        }

        private List<vwOrder> orderList;
        public List<vwOrder> OrderList
        {
            get
            {
                return orderList;
            }
            set
            {
                orderList = value;
                OnPropertyChanged("OrderList");
            }
        }

        #endregion

        #region Constructor


        public MainWindowViewModel(MainWindow employeeOpen)
        {
            main = employeeOpen;
            OrderList = service.GetAllOrders();
        }
        #endregion


    }
}












