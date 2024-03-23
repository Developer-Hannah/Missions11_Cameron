using Microsoft.EntityFrameworkCore.Query;

namespace Missions11_Cameron.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
