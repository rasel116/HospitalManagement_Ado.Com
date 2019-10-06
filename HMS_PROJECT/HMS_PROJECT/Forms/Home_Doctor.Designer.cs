namespace HMS_PROJECT.Forms
{
    partial class Home_Doctor
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
            this.mtabpatient = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbRefered = new MetroFramework.Controls.MetroTabPage();
            this.report_for_doctor1 = new HMS_PROJECT.Reports.CrystalReport1();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.hMS_ProjectDBDataSet5 = new HMS_PROJECT.HMS_ProjectDBDataSet5();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new HMS_PROJECT.HMS_ProjectDBDataSet5TableAdapters.DoctorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mtabpatient.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tbRefered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtabpatient
            // 
            this.mtabpatient.Controls.Add(this.metroTabPage1);
            this.mtabpatient.Controls.Add(this.tbRefered);
            this.mtabpatient.Location = new System.Drawing.Point(12, 12);
            this.mtabpatient.Name = "mtabpatient";
            this.mtabpatient.SelectedIndex = 1;
            this.mtabpatient.Size = new System.Drawing.Size(1025, 426);
            this.mtabpatient.TabIndex = 0;
            this.mtabpatient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtabpatient.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.crystalReportViewer1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1017, 384);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Patient";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 21);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1017, 423);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // tbRefered
            // 
            this.tbRefered.Controls.Add(this.metroButton1);
            this.tbRefered.Controls.Add(this.richTextBox1);
            this.tbRefered.Controls.Add(this.label4);
            this.tbRefered.Controls.Add(this.metroComboBox3);
            this.tbRefered.Controls.Add(this.metroComboBox2);
            this.tbRefered.Controls.Add(this.label3);
            this.tbRefered.Controls.Add(this.label2);
            this.tbRefered.Controls.Add(this.label1);
            this.tbRefered.Controls.Add(this.metroComboBox1);
            this.tbRefered.HorizontalScrollbarBarColor = true;
            this.tbRefered.HorizontalScrollbarHighlightOnWheel = false;
            this.tbRefered.HorizontalScrollbarSize = 10;
            this.tbRefered.Location = new System.Drawing.Point(4, 38);
            this.tbRefered.Name = "tbRefered";
            this.tbRefered.Size = new System.Drawing.Size(1017, 384);
            this.tbRefered.TabIndex = 1;
            this.tbRefered.Text = "Refered";
            this.tbRefered.VerticalScrollbarBarColor = true;
            this.tbRefered.VerticalScrollbarHighlightOnWheel = false;
            this.tbRefered.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.doctorBindingSource;
            this.metroComboBox1.DisplayMember = "DocName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(575, 49);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(234, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "DocSp";
            // 
            // hMS_ProjectDBDataSet5
            // 
            this.hMS_ProjectDBDataSet5.DataSetName = "HMS_ProjectDBDataSet5";
            this.hMS_ProjectDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hMS_ProjectDBDataSet5;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doctor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor Cell Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor Speciality";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataSource = this.doctorBindingSource;
            this.metroComboBox2.DisplayMember = "DocContactNo";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(575, 110);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(234, 29);
            this.metroComboBox2.TabIndex = 6;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.ValueMember = "DocSp";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.DataSource = this.doctorBindingSource;
            this.metroComboBox3.DisplayMember = "DocSp";
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(575, 173);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(234, 29);
            this.metroComboBox3.TabIndex = 7;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.ValueMember = "DocSp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Short Notes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(575, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Lime;
            this.metroButton1.Location = new System.Drawing.Point(854, 334);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(130, 35);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Send";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.ForeColorChanged += new System.EventHandler(this.metroButton1_ForeColorChanged);
            // 
            // Home_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 460);
            this.Controls.Add(this.mtabpatient);
            this.Name = "Home_Doctor";
            this.Text = "Home_Doctor";
            this.Load += new System.EventHandler(this.Home_Doctor_Load);
            this.mtabpatient.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tbRefered.ResumeLayout(false);
            this.tbRefered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_ProjectDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtabpatient;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage tbRefered;
        private Reports.CrystalReport1 report_for_doctor1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private HMS_ProjectDBDataSet5 hMS_ProjectDBDataSet5;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HMS_ProjectDBDataSet5TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}