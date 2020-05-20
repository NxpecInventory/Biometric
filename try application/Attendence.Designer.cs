namespace try_application
{
    partial class Attendence
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardianNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statuses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionDates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSemclasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintBinaries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedOns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Images = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Student = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.GetPrint = new System.Windows.Forms.Button();
            this.MarkAttendence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ids,
            this.Names,
            this.GuardianNames,
            this.Addresses,
            this.Contact,
            this.Statuses,
            this.AdmissionDates,
            this.Classids,
            this.ProgramIds,
            this.CurrentSemclasses,
            this.PrintBinaries,
            this.AddedOns,
            this.Images});
            this.dataGridView1.Location = new System.Drawing.Point(501, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 589);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ids
            // 
            this.Ids.HeaderText = "Id";
            this.Ids.Name = "Ids";
            // 
            // Names
            // 
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            // 
            // GuardianNames
            // 
            this.GuardianNames.HeaderText = "GuardianName";
            this.GuardianNames.Name = "GuardianNames";
            // 
            // Addresses
            // 
            this.Addresses.HeaderText = "Address";
            this.Addresses.Name = "Addresses";
            // 
            // Contact
            // 
            this.Contact.HeaderText = "ContactInfo";
            this.Contact.Name = "Contact";
            // 
            // Statuses
            // 
            this.Statuses.HeaderText = "Status";
            this.Statuses.Name = "Statuses";
            // 
            // AdmissionDates
            // 
            this.AdmissionDates.HeaderText = "AdmissionDate";
            this.AdmissionDates.Name = "AdmissionDates";
            // 
            // Classids
            // 
            this.Classids.HeaderText = "ClassId";
            this.Classids.Name = "Classids";
            // 
            // ProgramIds
            // 
            this.ProgramIds.HeaderText = "ProgramId";
            this.ProgramIds.Name = "ProgramIds";
            // 
            // CurrentSemclasses
            // 
            this.CurrentSemclasses.HeaderText = "CurrentSemclass";
            this.CurrentSemclasses.Name = "CurrentSemclasses";
            // 
            // PrintBinaries
            // 
            this.PrintBinaries.HeaderText = "Print Binary";
            this.PrintBinaries.Name = "PrintBinaries";
            // 
            // AddedOns
            // 
            this.AddedOns.HeaderText = "AddedOn";
            this.AddedOns.Name = "AddedOns";
            // 
            // Images
            // 
            this.Images.HeaderText = "Image";
            this.Images.Name = "Images";
            // 
            // StudentId
            // 
            this.StudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentId.HintForeColor = System.Drawing.Color.Empty;
            this.StudentId.HintText = "Student Id";
            this.StudentId.isPassword = false;
            this.StudentId.LineFocusedColor = System.Drawing.Color.Blue;
            this.StudentId.LineIdleColor = System.Drawing.Color.Gray;
            this.StudentId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StudentId.LineThickness = 3;
            this.StudentId.Location = new System.Drawing.Point(39, 81);
            this.StudentId.Margin = new System.Windows.Forms.Padding(5);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(436, 41);
            this.StudentId.TabIndex = 23;
            this.StudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Name
            // 
            this.Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name.HintForeColor = System.Drawing.Color.Empty;
            this.Name.HintText = "Student Name";
            this.Name.isPassword = false;
            this.Name.LineFocusedColor = System.Drawing.Color.Blue;
            this.Name.LineIdleColor = System.Drawing.Color.Gray;
            this.Name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Name.LineThickness = 3;
            this.Name.Location = new System.Drawing.Point(39, 190);
            this.Name.Margin = new System.Windows.Forms.Padding(5);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(436, 41);
            this.Name.TabIndex = 24;
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(36, 40);
            this.Student.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(67, 16);
            this.Student.TabIndex = 25;
            this.Student.Text = "Student Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Finger Print: ";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Teal;
            this.Status.Location = new System.Drawing.Point(137, 263);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(108, 18);
            this.Status.TabIndex = 28;
            this.Status.Text = "Not Captured";
            // 
            // GetPrint
            // 
            this.GetPrint.BackColor = System.Drawing.Color.ForestGreen;
            this.GetPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPrint.ForeColor = System.Drawing.Color.White;
            this.GetPrint.Location = new System.Drawing.Point(42, 318);
            this.GetPrint.Name = "GetPrint";
            this.GetPrint.Size = new System.Drawing.Size(161, 41);
            this.GetPrint.TabIndex = 30;
            this.GetPrint.Text = "Get Print";
            this.GetPrint.UseVisualStyleBackColor = false;
            this.GetPrint.Click += new System.EventHandler(this.GetPrint_Click);
            // 
            // MarkAttendence
            // 
            this.MarkAttendence.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MarkAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkAttendence.ForeColor = System.Drawing.Color.White;
            this.MarkAttendence.Location = new System.Drawing.Point(209, 318);
            this.MarkAttendence.Name = "MarkAttendence";
            this.MarkAttendence.Size = new System.Drawing.Size(161, 41);
            this.MarkAttendence.TabIndex = 29;
            this.MarkAttendence.Text = "Mark Attendence";
            this.MarkAttendence.UseVisualStyleBackColor = false;
            this.MarkAttendence.Click += new System.EventHandler(this.MarkAttendence_Click);
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.GetPrint);
            this.Controls.Add(this.MarkAttendence);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
         
            this.Size = new System.Drawing.Size(1285, 651);
            this.Load += new System.EventHandler(this.Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardianNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classids;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentSemclasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintBinaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedOns;
        private System.Windows.Forms.DataGridViewTextBoxColumn Images;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StudentId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Name;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button GetPrint;
        private System.Windows.Forms.Button MarkAttendence;
    }
}
