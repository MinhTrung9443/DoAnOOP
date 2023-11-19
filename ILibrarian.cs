﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnOOP
{
    public interface ILibrarian
    {
        void addBook(List<Book> list, Book a);
        void viewMemberDetails();
        string generateReport(List<Book> books);
    }
}