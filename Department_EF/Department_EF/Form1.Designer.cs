
namespace Department_EF
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
			this.dgv_student = new System.Windows.Forms.DataGridView();
			this.dgv_inst = new System.Windows.Forms.DataGridView();
			this.cb_dept = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_inst)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_student
			// 
			this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_student.Location = new System.Drawing.Point(119, 171);
			this.dgv_student.Name = "dgv_student";
			this.dgv_student.Size = new System.Drawing.Size(562, 117);
			this.dgv_student.TabIndex = 0;
			// 
			// dgv_inst
			// 
			this.dgv_inst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_inst.Location = new System.Drawing.Point(167, 314);
			this.dgv_inst.Name = "dgv_inst";
			this.dgv_inst.Size = new System.Drawing.Size(461, 124);
			this.dgv_inst.TabIndex = 1;
			// 
			// cb_dept
			// 
			this.cb_dept.FormattingEnabled = true;
			this.cb_dept.Location = new System.Drawing.Point(271, 66);
			this.cb_dept.Name = "cb_dept";
			this.cb_dept.Size = new System.Drawing.Size(235, 21);
			this.cb_dept.TabIndex = 2;
			this.cb_dept.SelectedIndexChanged += new System.EventHandler(this.cb_dept_SelectedIndexChanged);
			this.cb_dept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_dept_MouseClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cb_dept);
			this.Controls.Add(this.dgv_inst);
			this.Controls.Add(this.dgv_student);
			this.Name = "Form1";
			this.Text = "Department";
			((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_inst)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_student;
		private System.Windows.Forms.DataGridView dgv_inst;
		private System.Windows.Forms.ComboBox cb_dept;
	}
}

