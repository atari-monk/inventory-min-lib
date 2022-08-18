using System.ComponentModel.DataAnnotations;
using CommandDotNet;
using DotNetExtension;
using Inventory.Min.Data;
using ModelHelper;

namespace Inventory.Min.Lib;

[AtLeastOneProperty(
    nameof(Item.Name)
    , nameof(Item.Description)
    , ErrorMessage = UpdateError)]
public class ItemUpdateArgs
    : Model
        , IArgumentModel
        , IId
{
    private const string UpdateError = 
        "You must supply Name or Description";

    [Operand(
        "id")
        , Required
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
    public int Id { get; set; }

    [Option(
        'n'
        , "name")]
    public string? Name { get; set; }

    [Option(
        'd'
        , "desc")]
    public string? Description { get; set; }
}