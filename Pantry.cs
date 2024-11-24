using System.ComponentModel.DataAnnotations;

public class Pantry
{
    [Key]
    public int User_id { get; set; }
    public int Ingredient_id { get; set; }
    public int Quantity { get; set; }
    public string Measurement { get; set; } = string.Empty;
}