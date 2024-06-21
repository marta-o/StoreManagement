using StoreManagement.DAL.Entities;
using System;

namespace StoreManagement.Views.WorkerViews
{
    public  interface IWorkerEditProductView
    {
        int ProductId { get; }
        string ProductName { get; }
        string Category { get; }
        string Colour { get; }
        string Price { get; }
        string ProductSize { get; }
        string Amount { get; }
        event EventHandler SaveProduct;
        void ShowMessage(string message);
        void PopulateForm(Clothes clothes);
        void ClearForm();
    }
}
