
using System.ComponentModel.DataAnnotations;

public class Recipe_Ingredient_Junction
    {
    [Key]
    public int Recipe_id { get; set; }
    public int Ingredient_id { get; set; }
    public int Quantity { get; set; }
    public string Quantity_measurement { get; set; } = string.Empty;
}

