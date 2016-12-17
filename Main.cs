using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Main : Form
    {
        private StudentDbEntities db = new StudentDbEntities();

        public Main()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            tblStudent t = new tblStudent
            {
                Fullname = txtFullname.Text,
                Grade = txtGrade.Text,
                ClassNo = txtClassNo.Text
            };
            db.tblStudent.Add(t);
            db.SaveChanges();
            FillGrid();
        }

        private void FillGrid()
        {
            gv.DataSource = db.tblStudent.ToList();
            this.gv.Columns[0].HeaderText = "شناسه";
            this.gv.Columns[1].HeaderText = "نام کامل";
            this.gv.Columns[2].HeaderText = "نمره";
            this.gv.Columns[3].HeaderText = "شماره کلاس";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDelete.Text))
            {
                int id = Convert.ToInt32(txtDelete.Text);
                var delete = db.tblStudent.Where(x => x.Id == id).Single();
                db.tblStudent.Remove(delete);
                db.SaveChanges();
                FillGrid();
            }
        }
    }
}
// private void FillGrid()
 //       {
 //           gv.DataSource = db.tblStudent.ToList();
  //          this.gv.Columns[0].HeaderText = "شناسه";
    //        this.gv.Columns[1].HeaderText = "نام کامل";
  //          this.gv.Columns[2].HeaderText = "نمره";
   //         this.gv.Columns[3].HeaderText = "شماره کلاس";
   //     }
