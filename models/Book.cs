using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_1.models
{
    internal class Book
    {
        [Key]
        public int ISBN { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }
        public decimal price { get; set; }

        public int Pages { get; set; }
        public int PubYear { get; set; }
        public bool Instock { get; set; }


    }
}
