using System.ComponentModel.DataAnnotations;
using CommandDotNet;
using DotNetExtension;
using Inventory.Min.Data;
using ModelHelper;

namespace Inventory.Min.Lib;

[AtLeastOneProperty(
	nameof(Item.Name)
    , nameof(Item.Description)
	, nameof(Item.Quantity)
	, nameof(Item.CategoryId)
	, nameof(Item.PurchaseDate)
	, nameof(Item.CurrencyId)
    , ErrorMessage = UpdateError)]
public class ItemUpdateArgs
    : Model
        , IArgumentModel
        , IId
{
    private const string UpdateError = 
        "You must supply Name or Description or Quantity"
		+ "or CategoryId or PurchaseDate or CurrencyId";

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
	
	[Option(
        'q'
        , "quantity")]
    public int? Quantity { get; set; }
	
	[Option(
        'c'
        , "categoryId")]
    public int? CategoryId { get; set; }
	
	[Option(
        'p'
        , "purchaseDate"
		, Description = DateFormat)]
    public DateTime? PurchaseDate { get; set; }
	
	[Option(
        'u'
        , "currencyId")]
    public int? CurrencyId { get; set; }
}