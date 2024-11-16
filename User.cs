using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
       public int User_id { get; set; }
        public string User_name { get; set; } = string.Empty;
        public string First_name { get; set; } = string.Empty;
        public string Last_name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        

    }

