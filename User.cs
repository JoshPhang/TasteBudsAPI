using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
       public int User_id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string First_name { get; set; } = string.Empty;
        public string Last_name { get; set; } = string.Empty;
        public string Pwd { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        

    }

