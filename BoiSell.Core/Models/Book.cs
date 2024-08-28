using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoiSell.Core.Enums;

namespace BoiSell.Core.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; } = Guid.NewGuid().ToString();

        public string? Description { get; set; }

        [Range(1, 100000)]
        public int Price { get; set; }
        public int Discount { get; set; } = 0;

        public string? SpecialTag { get; set; }

        public string? Publisher { get; set; }

        public DateOnly? PublishedDate { get; set; }

        public int? Pages { get; set; }

        public string? Language { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public string? ImageUrl { get; set; }

        public BookStatus Status { get; set; } = BookStatus.Available;

    }

}
