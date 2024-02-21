namespace DemoDotNet8AutoMapperAndDTOs.DTOs
{
    public class RequestDTO
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}
