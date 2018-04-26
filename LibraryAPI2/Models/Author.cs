using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAPI2.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? YearBorn { get; set; }
        public int? YearDied { get; set; }

        //Foreign Keys
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}