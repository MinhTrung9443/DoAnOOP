using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnOOP
{
    public class Librarian : Person, ILibrarian
    {
        public Librarian() { }
        public Librarian(string nameValue, int numberValue, string addressValue, int idValue) : base(nameValue, numberValue, addressValue, idValue) { }
        public void addBook()
        {
            throw new NotImplementedException();
        }

        public void generateReport()
        {
            throw new NotImplementedException();
        }

        public override string pritfDetail()
        {
            throw new NotImplementedException();
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