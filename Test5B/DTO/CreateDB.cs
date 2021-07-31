using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Test5B.DTO
{
    public class CreateDB:CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.LSHes.AddRange(new LSH[]
            {
                new LSH{ IDLop = 1 , TenLop = "19TCLC_DT1"},
                new LSH{ IDLop = 2 , TenLop = "19TCLC_DT2"},
                new LSH{ IDLop = 3 , TenLop = "19TCLC_DT3"},
                new LSH{ IDLop = 4 , TenLop = "19TCLC_DT4"},
            });
            context.SVs.AddRange(new SV[]
            {
                new SV{ MSSV = "101" , Ten ="QuyLeThanh" ,  IDLop = 1 },
                new SV{ MSSV = "102" , Ten ="ThanhQuy" ,  IDLop = 2 },
                new SV{ MSSV = "103" , Ten ="QuyThanh" ,  IDLop = 3 },
                new SV{ MSSV = "104" , Ten ="LeThanhQUy" ,  IDLop = 4 },

            });
            context.Khoas.AddRange(new Khoa[]
            {
                new Khoa{IDKhoa = 1 , TenKhoa = "CNTT"},
                new Khoa{IDKhoa = 2 , TenKhoa = "XayDung"},
                new Khoa{IDKhoa = 3 , TenKhoa = "DienTu"},
                new Khoa{IDKhoa = 4 , TenKhoa = "CoKhi"},
            });

            context.MonHocs.AddRange(new MonHoc[]
            {
                new MonHoc{MMH = 1 , Mon = "LapTrinhNET" , IDKhoa = 1 },
                new MonHoc{MMH = 2 , Mon = "XayDungGiDo" , IDKhoa = 2 },
                new MonHoc{MMH = 3 , Mon = "DienTuGiDo" , IDKhoa = 3 },
                new MonHoc{MMH = 4 , Mon = "CoKhiGiDo" , IDKhoa = 4 }
            });

            context.BangDiems.AddRange(new BangDiem[]
            {
                new BangDiem{MMH = 1 , MSSV = "101" , Diem = 2},
                new BangDiem{MMH = 2 , MSSV = "102" , Diem = 4},
                new BangDiem{MMH = 3 , MSSV = "103" , Diem = 6},
                new BangDiem{MMH = 4 , MSSV = "104" , Diem = 8},
            });
        }
    }
}
