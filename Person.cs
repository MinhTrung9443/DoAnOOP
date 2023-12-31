﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAnOOP
{
    public abstract class Person : ISearch
    {
        private string name;
        private int numberContact;
        private string address;
        private int id;

        public string Name { get => name; set => name = value; }
        public int NumberContact { get => numberContact; set => numberContact = value; }
        public string Address { get => address; set => address = value; }
        public int Id { get => id; set => id = value; }

        public abstract string printfDetail();

        public abstract List<qlyBook> searchBook(string a, string b);

        public Person(string nameValue, int numberValue, string addressValue, int idValue)
        {
            Name= nameValue;
            NumberContact = numberValue;
            Address = addressValue;
            Id = idValue;
        }

        public Person() {}
    }
}