using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5B.DTO
{
    [Table("SinhVien")]
    public class SV
    {
        [Key]
        public string MSSV { get; set; }
        
        public string Ten { get; set; }
        public int IDLop { get; set; }
        [ForeignKey("IDLop")]

        public virtual LSH LopSinhHoat { get; set; }

        public SV()
        {
            Diems = new HashSet<BangDiem>();
        }

        public virtual ICollection<BangDiem> Diems { get; set; }
    }
}
