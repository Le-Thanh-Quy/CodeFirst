using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test5B.DTO;

namespace Test5B
{
    public partial class Form1 : Form
    {
        CSDL DB;
        public Form1()
        {
            DB = new CSDL();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bangDiemViews();
        }

        private List<BangDiemView> bangDiemViews()
        {
            List<BangDiemView> bd = new List<DTO.BangDiemView>();
            var l = DB.BangDiems.Select(p => p).ToList();
            foreach(BangDiem i in l)
            {
                bd.Add(new BangDiemView
                {
                    TenSinhVien = i.SinhVien.Ten,
                    MonHoc = i.Monhoc.Mon,
                    Khoa = i.Monhoc.khoa.TenKhoa,
                    Diem = i.Diem
                });
            }
            return bd;
        }
    }
}
