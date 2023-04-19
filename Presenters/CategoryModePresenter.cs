using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class CategoryModePresenter
    {
        private ICategoryView view;
        private ICategoryModeRespository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModeModel> categoryList;

        public CategoryModePresenter(ICategoryView view, ICategoryModeRespository repository)
        {
            this.categoryBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBildingSource(categoryBindingSource);

            LoadAllCategoryList();

            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            var categoryMode = new CategoryModeModel();
            categoryMode.Id = Convert.ToInt32(view.CategoryId);
            categoryMode.Name = view.CategoryName;
            categoryMode.Observation = view.CategoryObservation;

            try
            {
                new Common.ModelDataValidation().Validate(categoryMode);
                if (view.IsEdit)
                {
                    repository.Edit(categoryMode);
                    view.Message = "Category Edited Successfuly";
                }
                else
                {
                    repository.Add(categoryMode);
                    view.Message = "Category Added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCategoryList();
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
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryObservation = "";
        }

        private void DeleteSelectCategory(object? sender, EventArgs e)
        {
            try 
            {
                var categoryMode = (CategoryModeModel) categoryBindingSource.Current;
                repository.Delete(categoryMode.Id);
                view.IsSuccessful = true;
                view.Message = "Category deleted successfully";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete category";
            }
        }

        private void LoadSelectCategoryToEdit(object? sender, EventArgs e)
        {
            var categoryMode = (CategoryModeModel)categoryBindingSource.Current;
            view.CategoryId = categoryMode.Id.ToString();
            view.CategoryName = categoryMode.Name;
            view.CategoryObservation = categoryMode.Observation;
            view.IsEdit = true;
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoryList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }
            categoryBindingSource.DataSource = categoryList;
        }
    }
}
