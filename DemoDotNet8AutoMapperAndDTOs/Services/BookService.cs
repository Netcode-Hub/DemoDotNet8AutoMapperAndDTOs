using AutoMapper;
using DemoDotNet8AutoMapperAndDTOs.DTOs;
using DemoDotNet8AutoMapperAndDTOs.Models;

namespace DemoDotNet8AutoMapperAndDTOs.Services
{
    public class BookService
    {
        public BookService(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public List<RequestDTO> GetBooks()
        {
            var mapBooks = mapper.Map<List<RequestDTO>>(books);
            return mapBooks;
        }
        public void AddBook(RequestDTO requestDTO)
        {

            var book = mapper.Map<Book>(requestDTO);
            book.Id = books.Count + 1;
            books.Add(book);
        }
        public ResponseDTO GetBookById(int id)
        {
            var book = books.FirstOrDefault(_ => _.Id == id)!;
            var mapBook = mapper.Map<ResponseDTO>(book);
            return mapBook;
        } 
        public void DeleteBookById(int id) => books.Remove(books.FirstOrDefault(_ => _.Id == id)!);


        private static List<Book> books = 
        [
            new() {Id=1, Title = "The Very Hungry Caterpillar", Author = "Eric Carle", Year = 1969, Price=120m },
            new() {Id=2, Title = "Where the Wild Things Are", Author = "Maurice Sendak", Year = 1963, Price=100m },
            new() {Id=3, Title = "Goodnight Moon", Author = "Margaret Wise Brown", Year = 1947, Price=50m },
            new() {Id=4, Title = "The Cat in the Hat", Author = "Dr. Seuss", Year = 1957, Price=70m},
            new() {Id=5, Title = "Charlotte's Web", Author = "E.B. White", Year = 1952, Price=12.50m },
            new() {Id=6, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", Year = 1997, Price=11.20m },
            new() {Id=7, Title = "The Lion, the Witch and the Wardrobe", Author = "C.S. Lewis", Year = 1950, Price=19.20m },
            new() {Id=8, Title = "Matilda", Author = "Roald Dahl", Year = 1988, Price=120m },
            new() {Id=9, Title = "The Giving Tree", Author = "Shel Silverstein", Year = 1964, Price=120.80m },
            new() {Id=10, Title = "Oh, the Places You'll Go!", Author = "Dr. Seuss", Year = 1990, Price=180.20m }
        ];
        private readonly IMapper mapper;
    }
}
