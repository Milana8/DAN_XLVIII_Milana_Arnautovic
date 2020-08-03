using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zadatak_1.Model;

namespace Zadatak_1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        MainWindow main;
        Service service = new Service();

        #region Property

        private tblOrder order;
        public tblOrder Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
                OnPropertyChanged("Order");
            }
        }

        private List<tblOrder> orderList;
        public List<tblOrder> OrderList
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

        private Visibility viewOrder = Visibility.Visible;
        public Visibility ViewOrder
        {
            get
            {
                return viewOrder;
            }
            set
            {
                viewOrder = value;
                OnPropertyChanged("ViewOrder");
            }
        }


        #endregion

        #region Constructor


        public MainWindowViewModel(MainWindow employeeOpen)
        {
            main = employeeOpen;
            using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
            {
                OrderList = context.tblOrders.ToList();
            }
        }
        #endregion
    }
}











