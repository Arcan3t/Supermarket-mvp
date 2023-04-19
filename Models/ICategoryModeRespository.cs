using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategoryModeRespository
    {
        void Add(CategoryModeModel categoryModeModel);
        void Edit(CategoryModeModel categoryModeModel);
        void Delete(int id);
        IEnumerable<CategoryModeModel> GetAll();
        IEnumerable<CategoryModeModel> GetByValue(string value);
    }
}
