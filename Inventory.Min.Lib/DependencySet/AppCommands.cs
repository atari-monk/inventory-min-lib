using CRUDCommandHelper;
using DIHelper.Unity;
using Unity;

namespace Inventory.Min.Lib;

public class AppCommands 
    : UnityDependencySet
{
    public AppCommands(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterInsertCommand();
    }

    private void RegisterInsertCommand()
    {
        Container
            .RegisterSingleton<IReadCommand<ItemFilterArgs>, ItemReadCommand>()
            .RegisterSingleton<IInsertCommand<ItemInsertArgs>, ItemInsertCommand>()
            .RegisterSingleton<IUpdateCommand<ItemUpdateArgs>, ItemUpdateCommand>()
            .RegisterSingleton<IDeleteCommand<DeleteArgs>, ItemDeleteCommand>();
    }
}