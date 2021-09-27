namespace Assignment7
{
    partial class AddStudentList
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtStudents = new System.Windows.Forms.TextBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(29, 56);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(109, 13);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Namn på klass/grupp";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(32, 82);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(178, 20);
            this.txtGroupName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtGroupName, "Skriv in namnet på klassen/gruppen här");
            // 
            // txtStudents
            // 
            this.txtStudents.Location = new System.Drawing.Point(32, 125);
            this.txtStudents.Multiline = true;
            this.txtStudents.Name = "txtStudents";
            this.txtStudents.Size = new System.Drawing.Size(232, 493);
            this.txtStudents.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtStudents, "Lägg till eleverna här, en elev per rad");
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(29, 109);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(37, 13);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "Elever";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(270, 582);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 36);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.toolTip1.SetToolTip(this.btnOk, "Klicka här för att spara ändringar");
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(459, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Avbryt";
            this.toolTip1.SetToolTip(this.btnCancel, "Klicka här för att avbryta");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 641);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.txtStudents);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Name = "AddStudentList";
            this.Text = "AddStudentList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStudentList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}