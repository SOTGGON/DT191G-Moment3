using System.ComponentModel.DataAnnotations;

namespace BookCollection.Models
{
    public class Borrow
    {
        // Properties
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual Book? Book { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.Now;


    }
}