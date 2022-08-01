using System.ComponentModel.DataAnnotations;
using CommandDotNet;
using ModelHelper;

namespace Inventory.Min.Lib;

public class ItemInsertArgs 
    : Model
    , IArgumentModel
{
	[Operand(nameof(Name))
        , Required
        , MaxLength(NameMax)]
	public string? Name { get; set; }

    [Option('d', "description")
        , MaxLength(DescriptionMax)]
    public string? Description { get; set; }

    [Option('q', "quantity")
        , Range(0, int.MaxValue, ErrorMessage = IdError)]
    public int? Quantity { get; set; }

	[Option('c', "categoryId")
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int? CategoryId { get; set; }

    [Option('p', "purchaseDate"
		, Description = DateFormat)]
	public DateTime? PurchaseDate { get; set; }

    [Option("currencyId")]
	public int? CurrencyId { get; set; } = 1;

    [Option('u', "purchasePrice")]
	public decimal? PurchasePrice { get; set; }

    [Option('s', "sellPrice")]
	public decimal? SellPrice { get; set; }

    [Option('i', "imagePath")]
	public string? ImagePath { get; set; }

    [Option("lengthUnitId")]
	public int? LengthUnitId { get; set; } = 1;

    [Option('l', "length")]
	public double? Length { get; set; }

    [Option('e', "heigth")]
	public double? Heigth { get; set; }

    [Option("depth")]
	public double? Depth { get; set; }

    [Option("diameter")]
	public double? Diameter { get; set; }

    [Option("volumeUnitId")
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int? VolumeUnitId { get; set; } = 1;

    [Option('v', "volume")]
	public double? Volume { get; set; }

    [Option('t', "tagId")
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int? TagId { get; set; }

    [Option('a', "stateId")
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int? StateId { get; set; }
}