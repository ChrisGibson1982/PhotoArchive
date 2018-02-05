using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoArchive.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }
        public string FilePath { get; set; }
        public DateTime DateAdded { get; set; }


    }
}
