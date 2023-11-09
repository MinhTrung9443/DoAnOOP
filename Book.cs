using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _DATE;
namespace DoAnOOP
{
    public class Book
    {
        private string name;
        private int bookCode;
        private string author;
        private Date_ date;

        public Book(string nameValue, int bookCodeValue, string authorValue, Date_ dateValue)
        {
            Name = nameValue;
            BookCode = bookCodeValue;
            Author = authorValue;
            Date = dateValue;
        }

        public Book(){}

        public string Name { get => name; set => name = value; }
        public int BookCode { get => bookCode; set => bookCode = value; }
        public string Author { get => author; set => author = value; }
        public Date_ Date { get => date; set => date = value; }

        public string bookDetail()
        {
            return "BookCode: " + BookCode + " Name: " + Name + " Author: " + Author + Date.toDateString();
        }
    }
}