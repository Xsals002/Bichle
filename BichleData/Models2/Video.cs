using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BichleData.Models2
{
    public class Video : LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}
