using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnOOP
{
    public interface ILibrarian
    {
        void addBook(Book a);
        List<qlyMember> viewMemberDetails();
        void generateReport();
    }
}