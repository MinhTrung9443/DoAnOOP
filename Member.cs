using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnOOP
{
    public class Member : Person, IMember
    {
        public Member() { }
        public Member(string nameValue,int numberValue, string addressValue, int idValue) : base (nameValue,numberValue,addressValue,idValue) { }
        public void issueBook()
        {
            throw new NotImplementedException();
        }

        public override string printfDetail()
        {
            return "Id: " + Id + " Name: " + Name + " Address: " + Address + " Number: " + NumberContact;
        }

        public void returnBook()
        {
            throw new NotImplementedException();
        }

        public override string searchBook()
        {
            throw new NotImplementedException();
        }
    }
}