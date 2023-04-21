using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface ICustomerView
    {
        string CustomerId { get; set; }
        string CustomerDocumentNumber { get; set; }
        string CustomerFName { get; set; }
        string CustomerLName { get; set; }
        string CustomerAddress { get; set; }
        string CustomerBirthday { get; set; }
        string CustomerPhoneNumber { get; set; }
        string CustomerEmail { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCustomerListBildingSource(BindingSource customerList);
        void Show();
    }
}
