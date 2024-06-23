using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;

namespace StoreManagement.Views.ClientViews
{
    public interface IClientCartView
    {
        void DisplayCartItems(List<Clothes> cartItems);
        void ShowMessage(string message);
        event EventHandler Purchase;
        string Price { get; set; }
    }
}
