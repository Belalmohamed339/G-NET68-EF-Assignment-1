using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_1.models
{
    internal class Author
    {
        [Key]
        public int AuthID { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }
        [EmailAddress]
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }
        
        [Column(TypeName = "varchar(1000)")]
        public string Biography { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }



    }
}
