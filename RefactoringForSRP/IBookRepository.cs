using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringForSRP
{
    public interface IBookRepository
    {
        public void UpdateInventory(Book book);
        public Book GetBookById(int bookId);


    }
}
