using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DoAnOOP
{
    public class Book
    {
        private string name;
        private int bookCode;
        private string author;
        private DateTime date;
        private int number;

        public Book(string nameValue, int bookCodeValue, string authorValue, DateTime dateValue,int number)
        {
            Name = nameValue;
            BookCode = bookCodeValue;
            Author = authorValue;
            Date = dateValue;
            Number = number;
        }

        public Book(){}

        public string Name { get => name; set => name = value; }
        public int BookCode { get => bookCode; set => bookCode = value; }
        public string Author { get => author; set => author = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Number { get => number; set => number = value; }

        public string bookDetail()
        {
            return "BookCode: " + BookCode + " Name: " + Name + " Author: " + Author + " Number: "+ Number + Date.ToString();
        }
    }
}