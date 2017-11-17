using System.Collections.Generic;

namespace Kostenverdeling.Model.Common
{
    public interface ICostCategoryRepository
    {
        IEnumerable<CostCategory> GetCostCategories();
        CostCategory GetCostCategory(string code);
        CostCategory GetOrAddCostCategory(string code, string description);
    }
}
