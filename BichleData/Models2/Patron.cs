using System;
using System.Collections.Generic;
using System.Text;

namespace BichleData.Models2
{
    public class Patron
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }

        public LibraryCard LibraryCard { get; set; }
        public LibraryBranch HomeLibraryBranch { get; set; }
    }
}
