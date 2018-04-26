﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LibraryAPI2.Models;

namespace LibraryAPI2.LibraryContext
{
    public class LibraryContext:DbContext
    {
        public LibraryContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}