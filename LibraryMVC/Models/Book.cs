namespace LibraryMVC.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string CallNumber { get; set; }
        public string Author { get; set; }
        public string imgfile { get; set; }

        public float price { get; set; }

        public int Quantity { get; set; }
    }
}
