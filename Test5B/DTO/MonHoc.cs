using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5B.DTO
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        public int MMH { get; set; }

        public string Mon { get; set; }
        public int IDKhoa { get; set; }
        [ForeignKey("IDKhoa")]

        public virtual Khoa khoa { get; set; }


        public MonHoc()
        {
            DB = new HashSet<BangDiem>();
        }
        public virtual ICollection<BangDiem> DB { get; set; }
    }
}
