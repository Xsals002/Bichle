using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BichleData.Models2
{
    public class Checkout
    {
        public int Id { get; set; }

        [Required]
        public LibraryAsset LibraryAsset { get; set; }
        //public LibraryBranch LibraryBranch { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
    }
}
