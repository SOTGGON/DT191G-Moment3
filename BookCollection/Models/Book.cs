using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollection.Models {
    public class Book {
        // Properties

        public int Id {get; set;}
        public string Name {get; set;} = null!;
        public string Type {get; set;} = null!;
        public string? Description {get; set;}

        /* public Author Author { get; set; } // Navigeringsegenskaper
        [ForeignKey("AuthorId")] */
        
        public int AuthorId {get; set;}

        [Display(Name = "AuthorID")]
        public virtual Author? Author { get; set; }

        public bool IsBorrowed { get; set; } = false;
    }
}