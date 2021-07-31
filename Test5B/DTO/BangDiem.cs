using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5B.DTO
{
    [Table("BangDiem")]
    public class BangDiem
    {
        public string MSSV { get; set; }
        [ForeignKey("MSSV")]
        public virtual SV SinhVien { get; set; }

        public int MMH { get; set; }
        [ForeignKey("MMH")]
        public virtual MonHoc Monhoc { get; set; }

        public float Diem { get; set; }
    }
}
