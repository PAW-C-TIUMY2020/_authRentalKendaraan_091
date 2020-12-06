using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_091.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string Nik { get; set; }
        

        [Required(ErrorMessage = "Alamat Wajib diisi")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage = "No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maximal 13 angka")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "No HP Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "NoHP Wajib diisi")]
        public string NoHp { get; set; }


        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
