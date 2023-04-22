using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBildingSource(customerBindingSource);

            LoadAllCustomerList();

            this.view.Show();
        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customerMode = new CustomerModel();
            customerMode.Id = Convert.ToInt32(view.CustomerId);
            customerMode.DocumentNumber = int.Parse(view.CustomerDocumentNumber);
            customerMode.FirstName = view.CustomerFName;
            customerMode.LastName = view.CustomerLName;
            customerMode.Address = view.CustomerAddress;
            customerMode.Birthday = Convert.ToDateTime(view.CustomerBirthday);
            customerMode.PhoneNumber = long.Parse(view.CustomerPhoneNumber);
            customerMode.Email = view.CustomerEmail;

            try
            {
                new Common.ModelDataValidation().Validate(customerMode);
                if (view.IsEdit)
                {
                    repository.Edit(customerMode);
                    view.Message = "Customer Edited Successfuly";
                }
                else
                {
                    repository.Add(customerMode);
                    view.Message = "Customer Added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CustomerId = "0";
            view.CustomerDocumentNumber = "";
            view.CustomerFName = "";
            view.CustomerLName = "";
            view.CustomerAddress = "";
            view.CustomerBirthday = "";
            view.CustomerPhoneNumber = "";
            view.CustomerEmail = "";
        }

        private void DeleteSelectCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customerMode = (CustomerModel)customerBindingSource.Current;
                repository.Delete(customerMode.Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully";
                LoadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete customer";
            }
        }

        private void LoadSelectCustomerToEdit(object? sender, EventArgs e)
        {
            var customerMode = (CustomerModel)customerBindingSource.Current;
            view.CustomerId = customerMode.Id.ToString();
            view.CustomerDocumentNumber = customerMode.DocumentNumber.ToString();
            view.CustomerFName = customerMode.FirstName;
            view.CustomerLName = customerMode.LastName;
            view.CustomerAddress = customerMode.Address;
            view.CustomerBirthday = customerMode.Birthday.ToString();
            view.CustomerPhoneNumber = customerMode.PhoneNumber.ToString();
            view.CustomerEmail = customerMode.Email;
            view.IsEdit = true;
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;
        }
    }
}
