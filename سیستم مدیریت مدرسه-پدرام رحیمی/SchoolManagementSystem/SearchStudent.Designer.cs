namespace SchoolManagementSystem
{
    partial class SearchStudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priviousschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new SchoolManagementSystem.schoolDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new SchoolManagementSystem.schoolDataSetTableAdapters.studentTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.motherDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.castDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.standardDataGridViewTextBoxColumn,
            this.mediumDataGridViewTextBoxColumn,
            this.priviousschoolDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // stdidDataGridViewTextBoxColumn
            // 
            this.stdidDataGridViewTextBoxColumn.DataPropertyName = "std_id";
            this.stdidDataGridViewTextBoxColumn.HeaderText = "std_id";
            this.stdidDataGridViewTextBoxColumn.Name = "stdidDataGridViewTextBoxColumn";
            this.stdidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // motherDataGridViewTextBoxColumn
            // 
            this.motherDataGridViewTextBoxColumn.DataPropertyName = "mother";
            this.motherDataGridViewTextBoxColumn.HeaderText = "mother";
            this.motherDataGridViewTextBoxColumn.Name = "motherDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // castDataGridViewTextBoxColumn
            // 
            this.castDataGridViewTextBoxColumn.DataPropertyName = "cast";
            this.castDataGridViewTextBoxColumn.HeaderText = "cast";
            this.castDataGridViewTextBoxColumn.Name = "castDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // standardDataGridViewTextBoxColumn
            // 
            this.standardDataGridViewTextBoxColumn.DataPropertyName = "standard";
            this.standardDataGridViewTextBoxColumn.HeaderText = "standard";
            this.standardDataGridViewTextBoxColumn.Name = "standardDataGridViewTextBoxColumn";
            // 
            // mediumDataGridViewTextBoxColumn
            // 
            this.mediumDataGridViewTextBoxColumn.DataPropertyName = "medium";
            this.mediumDataGridViewTextBoxColumn.HeaderText = "medium";
            this.mediumDataGridViewTextBoxColumn.Name = "mediumDataGridViewTextBoxColumn";
            // 
            // priviousschoolDataGridViewTextBoxColumn
            // 
            this.priviousschoolDataGridViewTextBoxColumn.DataPropertyName = "privious_school";
            this.priviousschoolDataGridViewTextBoxColumn.HeaderText = "privious_school";
            this.priviousschoolDataGridViewTextBoxColumn.Name = "priviousschoolDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.schoolDataSet;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "جستجو ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(290, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 24);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "شناسه ثبت نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(237, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "جستجوی دانش آموزان";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.ee9b705677466e520fdbd5892bba8a19;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchStudent";
            this.Load += new System.EventHandler(this.SearchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private schoolDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priviousschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}