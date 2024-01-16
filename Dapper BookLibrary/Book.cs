using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BookLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId {  get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }

    }
}
