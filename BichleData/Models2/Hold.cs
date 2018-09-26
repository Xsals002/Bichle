using System;
using System.Collections.Generic;
using System.Text;

namespace BichleData.Models2
{
    public class Hold
    {
        public int Id { get; set; }
        public virtual LibraryAsset LibraryAsset { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public DateTime HoldPlaced { get; set; }
    }
}
