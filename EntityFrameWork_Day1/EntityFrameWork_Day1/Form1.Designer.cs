
namespace EntityFrameWork_Day1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgv_course = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.Name = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.lbl_status = new System.Windows.Forms.Label();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.txt_duratiion = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.cb_topic = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_course)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_course
			// 
			this.dgv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_course.Location = new System.Drawing.Point(101, 262);
			this.dgv_course.Name = "dgv_course";
			this.dgv_course.Size = new System.Drawing.Size(461, 176);
			this.dgv_course.TabIndex = 0;
			this.dgv_course.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_course_RowHeaderMouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(139, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			// 
			// Name
			// 
			this.Name.AutoSize = true;
			this.Name.Location = new System.Drawing.Point(139, 83);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(35, 13);
			this.Name.TabIndex = 2;
			this.Name.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(139, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Topic";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(139, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Duration";
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(128, 215);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(75, 23);
			this.btn_save.TabIndex = 5;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Location = new System.Drawing.Point(235, 215);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(75, 23);
			this.btn_edit.TabIndex = 6;
			this.btn_edit.Text = "Edit";
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(338, 215);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 7;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// lbl_status
			// 
			this.lbl_status.AutoSize = true;
			this.lbl_status.Location = new System.Drawing.Point(439, 225);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(35, 13);
			this.lbl_status.TabIndex = 8;
			this.lbl_status.Text = "label5";
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(210, 39);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(251, 20);
			this.txt_id.TabIndex = 9;
			// 
			// txt_duratiion
			// 
			this.txt_duratiion.Location = new System.Drawing.Point(210, 121);
			this.txt_duratiion.Name = "txt_duratiion";
			this.txt_duratiion.Size = new System.Drawing.Size(251, 20);
			this.txt_duratiion.TabIndex = 10;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(210, 80);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(251, 20);
			this.txt_name.TabIndex = 11;
			// 
			// cb_topic
			// 
			this.cb_topic.FormattingEnabled = true;
			this.cb_topic.Location = new System.Drawing.Point(210, 156);
			this.cb_topic.Name = "cb_topic";
			this.cb_topic.Size = new System.Drawing.Size(251, 21);
			this.cb_topic.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 450);
			this.Controls.Add(this.cb_topic);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.txt_duratiion);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.lbl_status);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv_course);
			//this.Name = "Form1";
			this.Text = "Courses";
			((System.ComponentModel.ISupportInitialize)(this.dgv_course)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_course;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.TextBox txt_duratiion;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.ComboBox cb_topic;
	}
}

