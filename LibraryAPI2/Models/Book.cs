using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAPI2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public string Condition { get; set; }
        public bool IsCheckedOut { get; set; } = false;
        public DateTime DueBackDate { get; set; } = DateTime.Now.AddDays(10);

        //Foreign Keys:

        //public int AuthorId { get; set; }
        //

        //public int GenreId { get; set; }

    }
}