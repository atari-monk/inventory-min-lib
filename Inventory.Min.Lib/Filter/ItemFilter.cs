using System.Linq.Expressions;
using Inventory.Min.Data;

namespace Inventory.Min.Lib;

public class ItemFilter 
    : IFilterFactory<Item, ItemFilterArgs>
{
    private ItemFilterArgs? filterArgs;

    private ItemFilterArgs FilterArgs
    {
        get
        {
            ArgumentNullException.ThrowIfNull(filterArgs);
            return filterArgs;
        }
    }

    public Expression<Func<Item, bool>>? GetFilter(
        ItemFilterArgs filterArgs)
    {
        SetFilter(filterArgs);
        return GetFilterByPurchaseDate();
    }

    private void SetFilter(ItemFilterArgs filterArgs)
    {
        this.filterArgs = filterArgs;
    }

    private Expression<Func<Item, bool>> GetFilterByPurchaseDate()
    {
        if (FilterArgs.PurchaseDate.HasValue) 
            return item => item.PurchaseDate.HasValue
                && item.PurchaseDate.Value.Date.Equals(
                    FilterArgs.PurchaseDate.Value.Date);
        return item => true;
    }    
}