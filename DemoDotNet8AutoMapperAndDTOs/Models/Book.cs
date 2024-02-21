namespace DemoDotNet8AutoMapperAndDTOs.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}
