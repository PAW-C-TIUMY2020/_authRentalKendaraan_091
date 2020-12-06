using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_091.Models.Upload
{
    public class FileDetails
    {
        public string Name { get; set; }

        public string Path { get; set; }
    }


    public class FilesViewModel
    {
        public List<FileDetails> files { get; set; }
        = new List<FileDetails>();
    }
}
