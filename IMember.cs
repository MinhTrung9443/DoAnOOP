using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnOOP
{
    public interface IMember
    {
        void returnBook(string a, string b, Member mem);
        void issueBook(string a,string b, Member mem);
    }
}