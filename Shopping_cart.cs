using System.ComponentModel.DataAnnotations;

    public class Shopping_cart
    {
    [Key]
    public int User_id { get; set; }
    public int Ingredient_id { get; set; }
    public int Quantity { get; set; }
    public string Quantity_measurement { get; set; } = string.Empty;
}

