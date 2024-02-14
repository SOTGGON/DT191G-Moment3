namespace BookCollection.Models {
    public class Book {
        // Properties

        public int Id {get; set;}
        public string? Name {get; set;}
        public string? AuthorName {get; set;}
        public string? Type {get; set;}
        public string? Description {get; set;}

        public int AuthorId { get; set; } // 外键
        public Author Author { get; set; } // 导航属性
    }
}