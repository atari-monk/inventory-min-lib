using Better.Console.Tables.Wrapper;
using CLIHelper;
using CRUDCommandHelper;
using Inventory.Min.Data;
using Serilog;

namespace Inventory.Min.Lib;

public class ItemRead2Command
    : ReadCommand<IInventoryUnitOfWork, Item, ItemFilterArgs>
{
    private readonly IDictionary<string, IBetterTable<Item>> tables;
    private readonly IFilterFactory<Item, ItemFilterArgs> filterFactory;

    public ItemRead2Command(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDictionary<string, IBetterTable<Item>> tables
        , IFilterFactory<Item, ItemFilterArgs> filterFactory)
            : base(unitOfWork, output, log, tables["ItemTable"])
    {
        this.tables = tables;
        this.filterFactory = filterFactory;
    }

    protected override List<Item> Get(ItemFilterArgs model)
    {
        return UnitOfWork.Item.GetItem(
            filterFactory.GetFilter(model)).ToList();
    }
}