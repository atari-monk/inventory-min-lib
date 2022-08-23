using CommandDotNet;
using ModelHelper;

namespace Inventory.Min.Lib;

public class ItemFilterArgs
    : Model
    , IArgumentModel
{
    [Option(
        shortName: 't'
        , longName: "table")]
    public string? Table { get; set; }

    [Option(
        shortName: 'p'
        , longName: "purchaseDate")]
    public DateTime? PurchaseDate { get; set; }

    [Option(
        shortName: 'c'
        , longName: "categoryId")]
    public int? CategoryId { get; set; }
}