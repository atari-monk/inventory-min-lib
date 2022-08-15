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
            .RegisterSingleton<IInsertCommand<ItemInsertArgs>, ItemInsertCommand>()
            .RegisterSingleton<IReadCommand<ItemFilterArgs>, ItemReadCommand>();
    }
}