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
        ArgumentNullException.ThrowIfNull(FilterArgs.PurchaseDate);
        return l => l.PurchaseDate.HasValue
            && l.PurchaseDate.Value.Date.Equals(FilterArgs.PurchaseDate.Value.Date);
    }    
}