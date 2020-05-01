namespace try_application
{
    partial class RegisterPrints
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
            this.SearchStudent = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectedName = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSemclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintBinary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchStudent
            // 
            this.SearchStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchStudent.HintForeColor = System.Drawing.Color.Empty;
            this.SearchStudent.HintText = "Search ";
            this.SearchStudent.isPassword = false;
            this.SearchStudent.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchStudent.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchStudent.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchStudent.LineThickness = 3;
            this.SearchStudent.Location = new System.Drawing.Point(248, 28);
            this.SearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.SearchStudent.Name = "SearchStudent";
            this.SearchStudent.Size = new System.Drawing.Size(379, 33);
            this.SearchStudent.TabIndex = 14;
            this.SearchStudent.Text = " ";
            this.SearchStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(784, 180);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(161, 41);
            this.add.TabIndex = 15;
            this.add.Text = "ADD/UPDATE";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(650, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectedName
            // 
            this.SelectedName.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.SelectedName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.GuardianName,
            this.Address,
            this.ContactInfo,
            this.Status,
            this.AdmissionDate,
            this.ClassId,
            this.ProgramId,
            this.CurrentSemclass,
            this.PrintBinary});
            this.SelectedName.Location = new System.Drawing.Point(18, 100);
            this.SelectedName.Name = "SelectedName";
            this.SelectedName.Size = new System.Drawing.Size(927, 74);
            this.SelectedName.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // GuardianName
            // 
            this.GuardianName.HeaderText = "GuardianName";
            this.GuardianName.Name = "GuardianName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // ContactInfo
            // 
            this.ContactInfo.HeaderText = "ContactInfo";
            this.ContactInfo.Name = "ContactInfo";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // AdmissionDate
            // 
            this.AdmissionDate.HeaderText = "AdmissionDate";
            this.AdmissionDate.Name = "AdmissionDate";
            // 
            // ClassId
            // 
            this.ClassId.HeaderText = "ClassId";
            this.ClassId.Name = "ClassId";
            // 
            // ProgramId
            // 
            this.ProgramId.HeaderText = "ProgramId";
            this.ProgramId.Name = "ProgramId";
            // 
            // CurrentSemclass
            // 
            this.CurrentSemclass.HeaderText = "CurrentSemclass";
            this.CurrentSemclass.Name = "CurrentSemclass";
            // 
            // PrintBinary
            // 
            this.PrintBinary.HeaderText = "Print Binary";
            this.PrintBinary.Name = "PrintBinary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Selected Student";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(617, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 41);
            this.button2.TabIndex = 20;
            this.button2.Text = "Get Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.PrintBinaries});
            this.dataGridView1.Location = new System.Drawing.Point(18, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 299);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(870, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegisterPrints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.SearchStudent);
            this.Name = "RegisterPrints";
            this.Size = new System.Drawing.Size(964, 529);
            this.Load += new System.EventHandler(this.RegisterPrints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchStudent;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView SelectedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentSemclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintBinary;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button button3;
    }
}
