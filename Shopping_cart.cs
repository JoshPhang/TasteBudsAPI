using System.ComponentModel.DataAnnotations;

    public class Shopping_cart
    {
    [Key]
    public int Cart_id { get; set; }
    public int User_id { get; set; }
    public int Ingredient_id { get; set; }
    }

