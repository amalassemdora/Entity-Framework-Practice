using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameWork_Day1.Model;

namespace EntityFrameWork_Day1
{
	public partial class Form1 : Form
	{
		ITIContext db;
		
		
		public Form1()
		{
			InitializeComponent();
			db = new ITIContext();
			//Load data from courses in gridview 
			dgv_course.DataSource = db.Courses.Select(n => new { ID = n.Crs_Id, Name = n.Crs_Name, Duration = n.Crs_Duration, Topic = n.Topic.Top_Name }).ToList();
			//retrive date of topics in combobox
			cb_topic.DataSource = db.Topics.ToList();
			cb_topic.DisplayMember = "top_name";
			cb_topic.ValueMember = "top_id";

			//Change the status of buttons and lable 
			btn_save.Enabled = true;
			btn_edit.Enabled = false;
			btn_delete.Enabled = false;
			lbl_status.Text = "";
		}
		
		private void btn_save_Click(object sender, EventArgs e)
		{
			//Retrive data from inputs
			/*
			 * 
			foreach (var item in db.Courses)
			{
				if (item.Crs_Id == id)
				{
					return false;
				}
				else
					return true;
			}
			  */
			
			Course c = new Course()
			{
				//check if course exsist or not
				Crs_Id = int.Parse(txt_id.Text),
				Crs_Name = txt_name.Text,
				Crs_Duration = int.Parse(txt_duratiion.Text),
				Top_Id = (int)cb_topic.SelectedValue
			};
			//Add & save change to courses
			db.Courses.Add(c);
			db.SaveChanges();
			//Reload the gridview
			lbl_status.ForeColor = Color.Green;
			lbl_status.Text = "Added Successfully";
			txt_id.Text = txt_duratiion.Text = txt_name.Text = "";
			dgv_course.DataSource = db.Courses.Select(n => new { ID = n.Crs_Id, Name = n.Crs_Name, Duration = n.Crs_Duration, Topic = n.Topic.Top_Name }).ToList();
			
		}

		private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//retrive id from selected item
			int id = (int)dgv_course.SelectedRows[0].Cells[0].Value;
			//Retrive date from record to inputs
			Course c = db.Courses.Where(n => n.Crs_Id==id).SingleOrDefault();
			txt_id.Text = c.Crs_Id.ToString();
			txt_name.Text = c.Crs_Name;
			txt_duratiion.Text= c.Crs_Duration.ToString();
			cb_topic.SelectedValue = c.Top_Id;

			//Disable change in id
			txt_id.Enabled = false;

			//Change the status of buttons and lable 
			btn_save.Enabled = false;
			btn_edit.Enabled = true;
			btn_delete.Enabled = true;
			lbl_status.Text = "";

		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txt_id.Text);
			Course c = db.Courses.Where(n => n.Crs_Id == id).SingleOrDefault();
			c.Crs_Id = int.Parse(txt_id.Text);
			c.Crs_Name = txt_name.Text;
			c.Crs_Duration = int.Parse(txt_duratiion.Text);
			c.Top_Id = (int)cb_topic.SelectedValue;

			//save change
			db.SaveChanges();

			dgv_course.DataSource = db.Courses.Select(n => new { ID = n.Crs_Id, Name = n.Crs_Name, Duration = n.Crs_Duration, Topic = n.Topic.Top_Name }).ToList();

			//Change the status of buttons and lable
			txt_id.Text = txt_duratiion.Text = txt_name.Text = "";
			btn_save.Enabled = true;
			btn_edit.Enabled = false;
			btn_delete.Enabled = false;
			txt_id.Enabled = true;
			lbl_status.ForeColor = Color.Green;
			lbl_status.Text = "Edit Successfully";
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			int id = (int)dgv_course.SelectedRows[0].Cells[0].Value;
			Course c = db.Courses.Where(n => n.Crs_Id == id).SingleOrDefault();
			db.Courses.Remove(c);
			db.SaveChanges();
			txt_id.Text = txt_duratiion.Text = txt_name.Text = "";
			btn_save.Enabled = true;
			btn_edit.Enabled = false;
			btn_delete.Enabled = false;
			txt_id.Enabled = true;
			lbl_status.ForeColor = Color.Red;
			lbl_status.Text = "Deleted Successfully";
			dgv_course.DataSource = db.Courses.Select(n => new { ID = n.Crs_Id, Name = n.Crs_Name, Duration = n.Crs_Duration, Topic = n.Topic.Top_Name }).ToList();

		}
	}
}
