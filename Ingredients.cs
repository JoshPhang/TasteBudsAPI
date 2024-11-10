using System.ComponentModel.DataAnnotations;

public class Ingredients
{
    [Key]
    public int Ingredient_id { get; set; }
    public string Ingredient_name { get; set; } = string.Empty;
    public byte Is_Vegan { get; set; }
    public byte Is_Vegetarian { get; set; }
    public byte Is_GlutenFree { get; set; }
    public int Quantity { get; set; }
    public string Quantity_measurement { get; set; } = string.Empty;
}