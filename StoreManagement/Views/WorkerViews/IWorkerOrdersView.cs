using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerOrdersView
    {
        void DisplayOrders(List<Order> orders);
        Order GetSelectedOrder();
        event EventHandler DeleteOrder;
        void ShowMessage(string message);
    }
}
