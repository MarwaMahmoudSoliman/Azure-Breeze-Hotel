using System.ComponentModel.DataAnnotations;

namespace WinFormsApp3.Models
{
    public class KitchenUser
    {
        [Key]
        public required string user_name { get; set; }
        public required string pass_word { get; set; }
    }
}


