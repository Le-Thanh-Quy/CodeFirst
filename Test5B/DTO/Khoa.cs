using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5B.DTO
{
    [Table("Khoa")]
    public class Khoa
    {
        [Key]
        public int IDKhoa { get; set; }
        public string TenKhoa { get; set; }

        public Khoa()
        {
            MH = new HashSet<MonHoc>();
        }
        public virtual ICollection<MonHoc> MH { get; set; }
    }

}
