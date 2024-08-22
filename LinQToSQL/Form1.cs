using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LinQToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // khai báo nguồn dữ liệu 
            QLPhimdbmlDataContext db = new QLPhimdbmlDataContext();
            Thi_du2(db);

        }

         void Thi_du2(QLPhimdbmlDataContext db)
        {
            Table<PHIM> Phims = db.GetTable<PHIM>();
            var kq = from p in Phims select new { p.} ;
            dataGV.DataSource = kq;
        }
        void cau1a(QLPhimdbmlDataContext db )
        {
            var kq = from p in db.Phims
                     where p.MaTL =="HD"
                     orderby p.sotap
                     select new
                     {
                         p.
                     }

        }
        void cau2a(QLPhimdbmlDataContext db)
        {
            var kq.Phims.Where(prop =>)
        }
    }
}
