using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_091.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tanggal pengembalian wajib di isi !")]
        public DateTime? TglPengembalian { get; set; }

        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }

        [Required(ErrorMessage = "Denda wajib di isi !")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
