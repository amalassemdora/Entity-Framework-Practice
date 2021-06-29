using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department_EF.Model;

namespace Department_EF
{
	
	public partial class Form1 : Form
	{
		ITIContext db;
		public Form1()
		{
			InitializeComponent();
			db = new ITIContext();
			//retrive date of topics in combobox
			
			cb_dept.DisplayMember = "dept_name";
			cb_dept.ValueMember = "dept_id";
			cb_dept.DataSource = db.Departments.ToList();
			showdept();
		}
		public void showdept()
		{
			int id = int.Parse(cb_dept.SelectedValue.ToString());
			Console.WriteLine(id);
			dgv_student.DataSource = db.Students.Where(n => (n.Dept_Id == id)).Select(n => new { n.St_Id, name = n.St_Fname + " " + n.St_Lname, n.St_Age, n.St_Address, Supervisor = n.Student2.St_Fname + " " + n.Student2.St_Lname }).ToList();
			dgv_inst.DataSource = db.Instructors.Where(n => (n.Dept_Id == id)).ToList();
		}

		private void cb_dept_SelectedIndexChanged(object sender, EventArgs e)
		{
			showdept();
		}


		private void cb_dept_MouseClick(object sender, MouseEventArgs e)
		{
			showdept();
		}
	}
}
