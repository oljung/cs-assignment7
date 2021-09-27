namespace Assignment7
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblChooseClass = new System.Windows.Forms.Label();
            this.cboxChooseClass = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lstStudentList = new System.Windows.Forms.ListBox();
            this.btnRandomStudent = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.gboxAddDelete = new System.Windows.Forms.GroupBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddDelete = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gboxAddEditGrp = new System.Windows.Forms.GroupBox();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitaltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gboxAddDelete.SuspendLayout();
            this.gboxAddEditGrp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChooseClass
            // 
            this.lblChooseClass.AutoSize = true;
            this.lblChooseClass.Location = new System.Drawing.Point(26, 36);
            this.lblChooseClass.Name = "lblChooseClass";
            this.lblChooseClass.Size = new System.Drawing.Size(52, 13);
            this.lblChooseClass.TabIndex = 0;
            this.lblChooseClass.Text = "Välj Klass";
            // 
            // cboxChooseClass
            // 
            this.cboxChooseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxChooseClass.FormattingEnabled = true;
            this.cboxChooseClass.Location = new System.Drawing.Point(95, 36);
            this.cboxChooseClass.Name = "cboxChooseClass";
            this.cboxChooseClass.Size = new System.Drawing.Size(121, 21);
            this.cboxChooseClass.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cboxChooseClass, "Använd rullgardinen för att välja klass/grupp");
            this.cboxChooseClass.SelectedIndexChanged += new System.EventHandler(this.cboxChooseClass_SelectedIndexChanged);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.Control;
            this.btnChoose.Location = new System.Drawing.Point(235, 36);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Välj";
            this.toolTip1.SetToolTip(this.btnChoose, "Klicka här för att bekräfta vald klass/grupp");
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lstStudentList
            // 
            this.lstStudentList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudentList.FormattingEnabled = true;
            this.lstStudentList.ItemHeight = 14;
            this.lstStudentList.Location = new System.Drawing.Point(364, 30);
            this.lstStudentList.Name = "lstStudentList";
            this.lstStudentList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstStudentList.Size = new System.Drawing.Size(256, 438);
            this.lstStudentList.TabIndex = 3;
            // 
            // btnRandomStudent
            // 
            this.btnRandomStudent.Enabled = false;
            this.btnRandomStudent.Location = new System.Drawing.Point(76, 83);
            this.btnRandomStudent.Name = "btnRandomStudent";
            this.btnRandomStudent.Size = new System.Drawing.Size(140, 42);
            this.btnRandomStudent.TabIndex = 4;
            this.btnRandomStudent.Text = "Slumpa Elev";
            this.toolTip1.SetToolTip(this.btnRandomStudent, "Använd den här knappen för att slumpmässigt välja en elev");
            this.btnRandomStudent.UseVisualStyleBackColor = true;
            this.btnRandomStudent.Click += new System.EventHandler(this.btnRandomStudent_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudent.Location = new System.Drawing.Point(73, 144);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(143, 23);
            this.lblStudent.TabIndex = 5;
            this.lblStudent.Text = "Random Student";
            // 
            // gboxAddDelete
            // 
            this.gboxAddDelete.Controls.Add(this.btnDeleteStudent);
            this.gboxAddDelete.Controls.Add(this.btnAddStudent);
            this.gboxAddDelete.Controls.Add(this.txtAddDelete);
            this.gboxAddDelete.Location = new System.Drawing.Point(24, 197);
            this.gboxAddDelete.Name = "gboxAddDelete";
            this.gboxAddDelete.Size = new System.Drawing.Size(285, 123);
            this.gboxAddDelete.TabIndex = 6;
            this.gboxAddDelete.TabStop = false;
            this.gboxAddDelete.Text = "Lägg till/Ta bort elev (temporärt)";
            this.toolTip1.SetToolTip(this.gboxAddDelete, "Här kan du lägga till/ta bort elever tan att påverka listan till nästa användning" +
        "");
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.Location = new System.Drawing.Point(189, 65);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(90, 33);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Ta bort Elev";
            this.toolTip1.SetToolTip(this.btnDeleteStudent, "Tar bort en elev");
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Enabled = false;
            this.btnAddStudent.Location = new System.Drawing.Point(6, 65);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(90, 33);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Lägg till Elev";
            this.toolTip1.SetToolTip(this.btnAddStudent, "Lägger till en elev");
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddDelete
            // 
            this.txtAddDelete.Location = new System.Drawing.Point(40, 19);
            this.txtAddDelete.Name = "txtAddDelete";
            this.txtAddDelete.Size = new System.Drawing.Size(152, 20);
            this.txtAddDelete.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtAddDelete, "Skriv namnet på den elev du vill lägga till/ta bort här");
            // 
            // gboxAddEditGrp
            // 
            this.gboxAddEditGrp.Controls.Add(this.btnDeleteList);
            this.gboxAddEditGrp.Controls.Add(this.btnEdit);
            this.gboxAddEditGrp.Controls.Add(this.btnAddList);
            this.gboxAddEditGrp.Location = new System.Drawing.Point(22, 344);
            this.gboxAddEditGrp.Name = "gboxAddEditGrp";
            this.gboxAddEditGrp.Size = new System.Drawing.Size(287, 123);
            this.gboxAddEditGrp.TabIndex = 7;
            this.gboxAddEditGrp.TabStop = false;
            this.gboxAddEditGrp.Text = "Lägg till/ändra/ta bort klass eller grupp";
            this.toolTip1.SetToolTip(this.gboxAddEditGrp, "Här kan du lägga till, ta bort eller ändra gruppe permanent");
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Enabled = false;
            this.btnDeleteList.Location = new System.Drawing.Point(206, 44);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteList.TabIndex = 2;
            this.btnDeleteList.Text = "Ta bort";
            this.toolTip1.SetToolTip(this.btnDeleteList, "Tar bort vald grupp");
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(119, 44);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Ändra";
            this.toolTip1.SetToolTip(this.btnEdit, "Öppnar formulär för att ändra i vald grupp");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(6, 44);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(90, 36);
            this.btnAddList.TabIndex = 0;
            this.btnAddList.Text = "Lägg till";
            this.toolTip1.SetToolTip(this.btnAddList, "Lägger till en grupp");
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitaltF4ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // exitaltF4ToolStripMenuItem
            // 
            this.exitaltF4ToolStripMenuItem.Name = "exitaltF4ToolStripMenuItem";
            this.exitaltF4ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitaltF4ToolStripMenuItem.Text = "Exit (alt F4)";
            this.exitaltF4ToolStripMenuItem.Click += new System.EventHandler(this.exitaltF4ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(633, 481);
            this.Controls.Add(this.gboxAddEditGrp);
            this.Controls.Add(this.gboxAddDelete);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnRandomStudent);
            this.Controls.Add(this.lstStudentList);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cboxChooseClass);
            this.Controls.Add(this.lblChooseClass);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Student Randomizer by Patik Österljung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gboxAddDelete.ResumeLayout(false);
            this.gboxAddDelete.PerformLayout();
            this.gboxAddEditGrp.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseClass;
        private System.Windows.Forms.ComboBox cboxChooseClass;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListBox lstStudentList;
        private System.Windows.Forms.Button btnRandomStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.GroupBox gboxAddDelete;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtAddDelete;
        private System.Windows.Forms.GroupBox gboxAddEditGrp;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitaltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

