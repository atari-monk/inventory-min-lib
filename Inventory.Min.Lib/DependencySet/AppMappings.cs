using AutoMapper;
using Inventory.Min.Data;
using Unity;

namespace Inventory.Min.Lib;

public class AppMappings 
    : ModelHelper.AppMappings
{
    public AppMappings(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override MapperConfiguration CreateMap() =>
        new (
        c => 
        {
            c.CreateMap<ItemInsertArgs, Item>();
        });
}