using Microsoft.EntityFrameworkCore.Query;
using Missions11_Cameron.Models;

namespace Missions11_Cameron.Modles
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _context;

        public EFBookRepository(BookstoreContext temp){
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
