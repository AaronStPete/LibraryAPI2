using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAPI2.Models
{
    public class CheckoutLedger
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string Email { get; set; } = "";

        //Foreign Key

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}