using System;
using System.Linq;
using System.Collections.Generic;

namespace Kostenverdeling.Model.Common
{
    public class CostCategoryRepository : ICostCategoryRepository
    {
        private List<CostCategory> CostCategories { get; } = new List<CostCategory>();

        public CostCategoryRepository() {
        }

        public IEnumerable<CostCategory> GetCostCategories() {
            return CostCategories;
        }

        public CostCategory GetCostCategory(string code) {
            return CostCategories.Where(c => c.Code == code.Trim().ToLower()).SingleOrDefault();
        }

        public CostCategory GetOrAddCostCategory(string code, string description) {
            var costCategory = GetCostCategory(code);

            if(costCategory == null) {
                costCategory = new CostCategory {
                    Code = code.Trim().ToLower(),
                    Description = description.Trim()
                };
                CostCategories.Add(costCategory);
            }

            return costCategory;
        }
    }
}
