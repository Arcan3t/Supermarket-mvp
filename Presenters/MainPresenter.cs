using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowProvidersView += ShowProviderView;

            this.mainView.ShowPurchaseView += ShowPurchaseView;
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowCategoriesView(object? sender, EventArgs e)
        {
            ICategoryView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoryModeRespository repository = new CategoryModeRespository(sqlConnectionString);
            new CategoryModePresenter(view, repository);
        }
        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetInstance((MainView)mainView);
            ICustomerRepository repository = new CustomerRepository(sqlConnectionString);
            new CustomerPresenter(view, repository);
        }
        private void ShowProductView(object? sender, EventArgs e)
        {
            IProviderView view = ProviderView.GetInstance((MainView)mainView);
            IProviderRepository repository = new ProviderRepository(sqlConnectionString);
            new ProviderPresenter(view, repository);
        }
        private void ShowProviderView(object? sender, EventArgs e)
        {
            IProductView view = PurchaseView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }
        private void ShowPurchaseView(object? sender, EventArgs e)
        {
            IProductView view = PurchaseView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }
    }
}
