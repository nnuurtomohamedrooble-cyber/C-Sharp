using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string student_name, department;
            int student_id, semester;
            string fullInfo;

            student_name = txtname.Text;
            student_id = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);


            fullInfo = student_name + "," + student_id + "," + department + ", " + semester;

            lbloutput.Text = fullInfo;
        }
    }
}
