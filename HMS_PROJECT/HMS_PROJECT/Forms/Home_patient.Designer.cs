namespace HMS_PROJECT
{
    partial class Home_patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdPatientData = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mComboCreByPat = new MetroFramework.Controls.MetroComboBox();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_ProjectDBDataSet2 = new HMS_PROJECT.HMS_ProjectDBDataSet2();
            this.mComboReDocPat = new MetroFramework.Controls.MetroComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_ProjectDBDataSet1 = new HMS_PROJECT.HMS_ProjectDBDataSet1();
            this.mComboDepartPat = new MetroFramework.Controls.MetroComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_ProjectDBDataSet = new HMS_PROJECT.HMS_ProjectDBDataSet();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.htmlLabel6 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnbrowse = new MetroFramework.Controls.MetroButton();
            this.txtPatientID = new MetroFramework.Controls.MetroTextBox();
            this.PatIamge = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnShowPatient = new MetroFramework.Controls.MetroButton();
            this.departmentTableAdapter = new HMS_PROJECT.HMS_ProjectDBDataSetTableAdapters.DepartmentTableAdapter();
            this.doctorTableAdapter = new HMS_PROJECT.HMS_ProjectDBDataSet1TableAdapters.DoctorTableAdapter();
            this.userInfoTableAdapter = new HMS_PROJECT.HMS_ProjectDBDataSet2TableAdapters.UserInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientData)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatIamge)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPatientData
            // 
            this.grdPatientData.AllowUserToResizeRows = false;
            this.grdPatientData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdPatientData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPatientData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPatientData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPatientData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPatientData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPatientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPatientData.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdPatientData.EnableHeadersVisualStyles = false;
            this.grdPatientData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPatientData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPatientData.Location = new System.Drawing.Point(-6, 483);
            this.grdPatientData.Name = "grdPatientData";
            this.grdPatientData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPatientData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPatientData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPatientData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPatientData.Size = new System.Drawing.Size(1014, 207);
            this.grdPatientData.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mComboCreByPat);
            this.metroPanel1.Controls.Add(this.mComboReDocPat);
            this.metroPanel1.Controls.Add(this.mComboDepartPat);
            this.metroPanel1.Controls.Add(this.txtAddress);
            this.metroPanel1.Controls.Add(this.htmlLabel6);
            this.metroPanel1.Controls.Add(this.htmlLabel5);
            this.metroPanel1.Controls.Add(this.htmlLabel4);
            this.metroPanel1.Controls.Add(this.htmlLabel3);
            this.metroPanel1.Controls.Add(this.htmlLabel2);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
            this.metroPanel1.Controls.Add(this.btnbrowse);
            this.metroPanel1.Controls.Add(this.txtPatientID);
            this.metroPanel1.Controls.Add(this.PatIamge);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(298, 48);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(491, 390);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mComboCreByPat
            // 
            this.mComboCreByPat.DataSource = this.userInfoBindingSource;
            this.mComboCreByPat.DisplayMember = "UserName";
            this.mComboCreByPat.FormattingEnabled = true;
            this.mComboCreByPat.ItemHeight = 23;
            this.mComboCreByPat.Location = new System.Drawing.Point(286, 349);
            this.mComboCreByPat.Name = "mComboCreByPat";
            this.mComboCreByPat.Size = new System.Drawing.Size(186, 29);
            this.mComboCreByPat.TabIndex = 18;
            this.mComboCreByPat.UseSelectable = true;
            this.mComboCreByPat.ValueMember = "UserInfoID";
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataMember = "UserInfo";
            this.userInfoBindingSource.DataSource = this.hMS_ProjectDBDataSet2;
            // 
            // hMS_ProjectDBDataSet2
            // 
            this.hMS_ProjectDBDataSet2.DataSetName = "HMS_ProjectDBDataSet2";
            this.hMS_ProjectDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mComboReDocPat
            // 
            this.mComboReDocPat.DataSource = this.doctorBindingSource;
            this.mComboReDocPat.DisplayMember = "DocName";
            this.mComboReDocPat.FormattingEnabled = true;
            this.mComboReDocPat.ItemHeight = 23;
            this.mComboReDocPat.Location = new System.Drawing.Point(286, 155);
            this.mComboReDocPat.Name = "mComboReDocPat";
            this.mComboReDocPat.Size = new System.Drawing.Size(186, 29);
            this.mComboReDocPat.TabIndex = 17;
            this.mComboReDocPat.UseSelectable = true;
            this.mComboReDocPat.ValueMember = "DoctorID";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hMS_ProjectDBDataSet1;
            // 
            // hMS_ProjectDBDataSet1
            // 
            this.hMS_ProjectDBDataSet1.DataSetName = "HMS_ProjectDBDataSet1";
            this.hMS_ProjectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mComboDepartPat
            // 
            this.mComboDepartPat.DataSource = this.departmentBindingSource;
            this.mComboDepartPat.DisplayMember = "DeptName";
            this.mComboDepartPat.FormattingEnabled = true;
            this.mComboDepartPat.ItemHeight = 23;
            this.mComboDepartPat.Location = new System.Drawing.Point(286, 110);
            this.mComboDepartPat.Name = "mComboDepartPat";
            this.mComboDepartPat.Size = new System.Drawing.Size(186, 29);
            this.mComboDepartPat.TabIndex = 16;
            this.mComboDepartPat.UseSelectable = true;
            this.mComboDepartPat.ValueMember = "DepartmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.hMS_ProjectDBDataSet;
            // 
            // hMS_ProjectDBDataSet
            // 
            this.hMS_ProjectDBDataSet.DataSetName = "HMS_ProjectDBDataSet";
            this.hMS_ProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(160, 214);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 116);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.Text = "";
            // 
            // htmlLabel6
            // 
            this.htmlLabel6.AutoScroll = true;
            this.htmlLabel6.AutoScrollMinSize = new System.Drawing.Size(51, 23);
            this.htmlLabel6.AutoSize = false;
            this.htmlLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel6.Location = new System.Drawing.Point(57, 249);
            this.htmlLabel6.Name = "htmlLabel6";
            this.htmlLabel6.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel6.TabIndex = 14;
            this.htmlLabel6.Text = "Address";
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(68, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(192, 352);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel5.TabIndex = 12;
            this.htmlLabel5.Text = "Created By:";
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(70, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(192, 158);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel4.TabIndex = 10;
            this.htmlLabel4.Text = "REf.Doctor :";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(73, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(192, 113);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel3.TabIndex = 8;
            this.htmlLabel3.Text = "Department :";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(45, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(192, 68);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel2.TabIndex = 7;
            this.htmlLabel2.Text = "Name :";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(286, 68);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(186, 23);
            this.txtName.TabIndex = 6;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(55, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(192, 24);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 5;
            this.htmlLabel1.Text = "PtientID :";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(48, 203);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 4;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseSelectable = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtPatientID
            // 
            // 
            // 
            // 
            this.txtPatientID.CustomButton.Image = null;
            this.txtPatientID.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtPatientID.CustomButton.Name = "";
            this.txtPatientID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientID.CustomButton.TabIndex = 1;
            this.txtPatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientID.CustomButton.UseSelectable = true;
            this.txtPatientID.CustomButton.Visible = false;
            this.txtPatientID.Lines = new string[0];
            this.txtPatientID.Location = new System.Drawing.Point(286, 24);
            this.txtPatientID.MaxLength = 32767;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.SelectionLength = 0;
            this.txtPatientID.SelectionStart = 0;
            this.txtPatientID.ShortcutsEnabled = true;
            this.txtPatientID.Size = new System.Drawing.Size(186, 23);
            this.txtPatientID.TabIndex = 3;
            this.txtPatientID.UseSelectable = true;
            this.txtPatientID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PatIamge
            // 
            this.PatIamge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatIamge.Location = new System.Drawing.Point(14, 24);
            this.PatIamge.Name = "PatIamge";
            this.PatIamge.Size = new System.Drawing.Size(164, 143);
            this.PatIamge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatIamge.TabIndex = 2;
            this.PatIamge.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(298, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(401, 444);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShowPatient
            // 
            this.btnShowPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowPatient.Location = new System.Drawing.Point(661, 444);
            this.btnShowPatient.Name = "btnShowPatient";
            this.btnShowPatient.Size = new System.Drawing.Size(128, 23);
            this.btnShowPatient.TabIndex = 10;
            this.btnShowPatient.Text = "Show";
            this.btnShowPatient.UseSelectable = true;
            this.btnShowPatient.Click += new System.EventHandler(this.btnShowPatient_Click);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Home_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 713);
            this.Controls.Add(this.btnShowPatient);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.grdPatientData);
            this.Name = "Home_patient";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientData)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatIamge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdPatientData;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.RichTextBox txtAddress;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel6;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton btnbrowse;
        private MetroFramework.Controls.MetroTextBox txtPatientID;
        private System.Windows.Forms.PictureBox PatIamge;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnShowPatient;
        private MetroFramework.Controls.MetroComboBox mComboCreByPat;
        private MetroFramework.Controls.MetroComboBox mComboReDocPat;
        private MetroFramework.Controls.MetroComboBox mComboDepartPat;
        private HMS_ProjectDBDataSet hMS_ProjectDBDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HMS_ProjectDBDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private HMS_ProjectDBDataSet1 hMS_ProjectDBDataSet1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HMS_ProjectDBDataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private HMS_ProjectDBDataSet2 hMS_ProjectDBDataSet2;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private HMS_ProjectDBDataSet2TableAdapters.UserInfoTableAdapter userInfoTableAdapter;
    }
}