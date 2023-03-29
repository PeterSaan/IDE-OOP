using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WingtipsToys.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, ]
    }
}