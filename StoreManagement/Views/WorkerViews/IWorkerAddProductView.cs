using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerAddProductView
    {
        string ProductName { get; }
        string Type { get; }  
        string Colour { get; }
        string Price { get; }  
        string ProductSize { get; }
        int Amount { get; }
        event EventHandler SaveProduct;
        void ShowMessage(string message);
        void ClearForm();
    }
}
