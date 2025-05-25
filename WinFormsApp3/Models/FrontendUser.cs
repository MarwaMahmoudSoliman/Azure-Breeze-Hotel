using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WinFormsApp3.Models
{


    public class FrontendUser
    {
        [Key]
        public required string user_name { get; set; }
        public required string pass_word { get; set; }
    }
}

