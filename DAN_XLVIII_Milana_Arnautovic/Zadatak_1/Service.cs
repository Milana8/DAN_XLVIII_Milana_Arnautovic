using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Model;

namespace Zadatak_1
{
    class Service
    {
        public List<tblProduct> GetAllProducts()
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    List<tblProduct> list = new List<tblProduct>();
                    list = (from x in context.tblProducts select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }





        public void DeleteOrder(int orderID)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    tblOrder orderToDelete = (from o in context.tblOrders where o.OrderID == orderID select o).First();
                    context.tblOrders.Remove(orderToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }


        public void AddOrder(string username)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    tblOrder order = new tblOrder
                    {
                        OrderDate = DateTime.Now,
                        Username = username,
                        OrderStatus = "pennding"
                    };
                    context.tblOrders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }

        public vwOrder ViewOrder(string username)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    return context.vwOrders.Where(x => x.Username == username).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public void ConfirmOrder(vwOrder order)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    tblOrder orderToEdit = context.tblOrders.Where(x => x.OrderID == order.OrderID).FirstOrDefault();
                    orderToEdit.OrderDate = DateTime.Now;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }

        public List<vwOrder> GetAllOrders()
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    List<vwOrder> orders = new List<vwOrder>();
                    orders = (from x in context.vwOrders select x).ToList();
                    return orders;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }
        public tblOrder ChangeOrderStatus(tblOrder order)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    tblOrder orderTochange = (from o in context.tblOrders where o.OrderID == order.OrderID select o).First();
                    orderTochange.OrderStatus = order.OrderStatus;

                    context.SaveChanges();
                    return order;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        private vwOrder FindOrderByID(int id)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    vwOrder order = (from x in context.vwOrders where x.OrderID == id select x).FirstOrDefault();
                    return order;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void ApproveOrder(vwOrder order)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    tblOrder orderToApprove = context.tblOrders.Where(x => x.OrderID == order.OrderID).FirstOrDefault();
                    orderToApprove.OrderStatus = "approved";
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }
       
        public void DenyOrder(vwOrder order)
        {
            try
            {
                using (DAN_XLVIIIEntities context = new DAN_XLVIIIEntities())
                {
                    tblOrder orderToReject = context.tblOrders.Where(x => x.OrderID == order.OrderID).FirstOrDefault();
                    orderToReject.OrderStatus = "denied";
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }

    }
}


