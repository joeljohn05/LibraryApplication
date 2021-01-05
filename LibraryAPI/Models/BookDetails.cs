using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    public class BookDetails
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int BookDetailId { get; set; }
        
        [Column(TypeName ="nvarchar(500)")]
        public string BookTitle { get; set; }
        
        [Column(TypeName = "nvarchar(18)")]
        public string IsbnCode { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Author { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Category { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Publisher { get; set; }

    }
}
