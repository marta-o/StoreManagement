using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;

namespace StoreManagement.Views.ClientViews
{
    public interface IClientOrdersView
    {
        void DisplayUsersOrders(List<Order> orders);
        Order GetSelectedOrder();
        event EventHandler DeleteOrder;
        void ShowMessage(string message);
    }
}
