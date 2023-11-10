using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DoAnOOP
{
    public class Librarian : Person, ILibrarian
    {
        public Librarian() { }
        public Librarian(string nameValue, int numberValue, string addressValue, int idValue) : base(nameValue, numberValue, addressValue, idValue) { }
        public void addBook(List<Book> books, Book a)
        {
            books.Add(a);
        }

        public string generateReport(List<Book> books)
        {
            string tam = string.Empty;
            foreach (var item in books)
            {
                tam += item.bookDetail()+ "\n";
            }
            return tam;
        }

        public override string printfDetail()
        {
            return "Name: " + Name + " Number contact: " + NumberContact + " Address: " + Address + " ID: " + Id+ "\n";
        }

        public override string searchBook()
        {
            throw new NotImplementedException();
        }

        public void viewMemberDetails()
        {
            throw new NotImplementedException();
        }
    }
}