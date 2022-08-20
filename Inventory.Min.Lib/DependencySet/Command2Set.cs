using CRUDCommandHelper;
using Unity;

namespace Inventory.Min.Lib;

public class Command2Set
    : CommandSet
{
    public Command2Set(
        IUnityContainer container) 
        : base(container)
    {
    }

    protected override void RegisterRead()
    {
        Container
            .RegisterSingleton<IReadCommand<ItemFilterArgs>, ItemRead2Command>();
    }
}