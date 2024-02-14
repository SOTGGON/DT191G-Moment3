using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollection.Models {
    public class Book {
        // Properties

        public int Id {get; set;}
        public string? Name {get; set;}
        public string? AuthorName {get; set;}
        public string? Type {get; set;}
        public string? Description {get; set;}

        /* public Author Author { get; set; } // Navigeringsegenskaper
        [ForeignKey("AuthorId")]
        public int AuthorId {get; set;} */
    }
}