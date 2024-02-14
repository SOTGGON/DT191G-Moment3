using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollection.Models {
    public class Author  {
        // Properties

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int NumberOfBooks { get; set; }

        /* public virtual List<Book> Books { get; set; } */

        /* public ICollection<Book> Books {get; set;} */
    }
}