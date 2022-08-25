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

    [Option('q', "initialCount")
        , Range(CountMin, CountMax, ErrorMessage = CountError)]
    public int? InitialCount { get; set; }

    [Option("currentCount")
        , Range(CountMin, CountMax, ErrorMessage = CountError)]
    public int? CurrentCount { get; set; }

	[Option('c', "categoryId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? CategoryId { get; set; }

    [Option('p', "purchaseDate"
		, Description = DateOnlyFormat)]
	public DateTime? PurchaseDate { get; set; }

    [Option("currencyId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? CurrencyId { get; set; } = 1;

    [Option('u', "purchasePrice")]
	public decimal? PurchasePrice { get; set; }

    [Option('s', "sellPrice")]
	public decimal? SellPrice { get; set; }

    [Option('i', "imagePath")]
	public string? ImagePath { get; set; }

    [Option("lengthUnitId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? LengthUnitId { get; set; } = 1;

    [Option('l', "length")
        , Range(LengthMin, LengthMax, ErrorMessage = LengthError)]
	public double? Length { get; set; }

    [Option('e', "heigth")
        , Range(LengthMin, LengthMax, ErrorMessage = LengthError)]
	public double? Heigth { get; set; }

    [Option("depth")
        , Range(LengthMin, LengthMax, ErrorMessage = LengthError)]
	public double? Depth { get; set; }

    [Option("diameter")
        , Range(LengthMin, LengthMax, ErrorMessage = LengthError)]
	public double? Diameter { get; set; }

    [Option("volumeUnitId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? VolumeUnitId { get; set; } = 1;

    [Option('v', "volume")
        , Range(LengthMin, LengthMax, ErrorMessage = LengthError)]
	public double? Volume { get; set; }

    [Option('t', "tagId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? TagId { get; set; }

    [Option('a', "stateId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? StateId { get; set; }

    [Option('r', "parentId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? ParentId { get; set; }

    [Option("mass")
        , Range(LengthMin, LengthMax, ErrorMessage = LengthError)]
	public double? Mass { get; set; }

    [Option("massUnitId")
        , Range(IdMin, IdMax, ErrorMessage = IdError)]
	public int? MassUnitId { get; set; } = 3;
}