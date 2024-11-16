
using System.ComponentModel.DataAnnotations;

public class Recipe_Ingredient_Junction
    {
    [Key]
    public int Recipe_id { get; set; }
    public int Ingredient_id { get; set; }
    public int Quantity_required { get; set; }
    }

