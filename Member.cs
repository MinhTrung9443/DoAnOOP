﻿using System;
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

        public override string pritfDetail()
        {
            throw new NotImplementedException();
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