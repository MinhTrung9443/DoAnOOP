namespace DoAnOOP
{
    partial class report
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
            this.label1 = new System.Windows.Forms.Label();
            this.grid_muon = new System.Windows.Forms.DataGridView();
            this.do_an_oopDataSet1 = new DoAnOOP.Do_an_oopDataSet1();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new DoAnOOP.Do_an_oopDataSet1TableAdapters.MemberTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_tra = new System.Windows.Forms.DataGridView();
            this.do_an_oopDataSet2 = new DoAnOOP.Do_an_oopDataSet2();
            this.traSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traSachTableAdapter = new DoAnOOP.Do_an_oopDataSet2TableAdapters.traSachTableAdapter();
            this.report1 = new System.Windows.Forms.Button();
            this.report2 = new System.Windows.Forms.Button();
            this.report3 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_muon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traSachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sach nguoi dung dang muon sach";
            // 
            // grid_muon
            // 
            this.grid_muon.AutoGenerateColumns = false;
            this.grid_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_muon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.bookCodeDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookNumberDataGridViewTextBoxColumn});
            this.grid_muon.DataSource = this.memberBindingSource;
            this.grid_muon.Location = new System.Drawing.Point(60, 91);
            this.grid_muon.Name = "grid_muon";
            this.grid_muon.RowHeadersWidth = 51;
            this.grid_muon.RowTemplate.Height = 24;
            this.grid_muon.Size = new System.Drawing.Size(1209, 210);
            this.grid_muon.TabIndex = 1;
            // 
            // do_an_oopDataSet1
            // 
            this.do_an_oopDataSet1.DataSetName = "Do_an_oopDataSet1";
            this.do_an_oopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.do_an_oopDataSet1;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookCodeDataGridViewTextBoxColumn
            // 
            this.bookCodeDataGridViewTextBoxColumn.DataPropertyName = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.HeaderText = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookCodeDataGridViewTextBoxColumn.Name = "bookCodeDataGridViewTextBoxColumn";
            this.bookCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNumberDataGridViewTextBoxColumn
            // 
            this.bookNumberDataGridViewTextBoxColumn.DataPropertyName = "BookNumber";
            this.bookNumberDataGridViewTextBoxColumn.HeaderText = "BookNumber";
            this.bookNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNumberDataGridViewTextBoxColumn.Name = "bookNumberDataGridViewTextBoxColumn";
            this.bookNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sach nguoi dung da tra sach";
            // 
            // grid_tra
            // 
            this.grid_tra.AutoGenerateColumns = false;
            this.grid_tra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn1,
            this.bookCodeDataGridViewTextBoxColumn1,
            this.bookNameDataGridViewTextBoxColumn1,
            this.bookNumberDataGridViewTextBoxColumn1});
            this.grid_tra.DataSource = this.traSachBindingSource;
            this.grid_tra.Location = new System.Drawing.Point(62, 381);
            this.grid_tra.Name = "grid_tra";
            this.grid_tra.RowHeadersWidth = 51;
            this.grid_tra.RowTemplate.Height = 24;
            this.grid_tra.Size = new System.Drawing.Size(1207, 193);
            this.grid_tra.TabIndex = 3;
            // 
            // do_an_oopDataSet2
            // 
            this.do_an_oopDataSet2.DataSetName = "Do_an_oopDataSet2";
            this.do_an_oopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traSachBindingSource
            // 
            this.traSachBindingSource.DataMember = "traSach";
            this.traSachBindingSource.DataSource = this.do_an_oopDataSet2;
            // 
            // traSachTableAdapter
            // 
            this.traSachTableAdapter.ClearBeforeFill = true;
            // 
            // report1
            // 
            this.report1.Location = new System.Drawing.Point(706, 35);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(169, 45);
            this.report1.TabIndex = 4;
            this.report1.Text = "Report";
            this.report1.UseVisualStyleBackColor = true;
            this.report1.Click += new System.EventHandler(this.report1_Click);
            // 
            // report2
            // 
            this.report2.Location = new System.Drawing.Point(706, 319);
            this.report2.Name = "report2";
            this.report2.Size = new System.Drawing.Size(169, 43);
            this.report2.TabIndex = 5;
            this.report2.Text = "Report";
            this.report2.UseVisualStyleBackColor = true;
            this.report2.Click += new System.EventHandler(this.report2_Click);
            // 
            // report3
            // 
            this.report3.Location = new System.Drawing.Point(555, 605);
            this.report3.Name = "report3";
            this.report3.Size = new System.Drawing.Size(169, 43);
            this.report3.TabIndex = 6;
            this.report3.Text = "REPORT";
            this.report3.UseVisualStyleBackColor = true;
            this.report3.Click += new System.EventHandler(this.report3_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            this.numberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookCodeDataGridViewTextBoxColumn1
            // 
            this.bookCodeDataGridViewTextBoxColumn1.DataPropertyName = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn1.HeaderText = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookCodeDataGridViewTextBoxColumn1.Name = "bookCodeDataGridViewTextBoxColumn1";
            this.bookCodeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn1
            // 
            this.bookNameDataGridViewTextBoxColumn1.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn1.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn1.Name = "bookNameDataGridViewTextBoxColumn1";
            this.bookNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookNumberDataGridViewTextBoxColumn1
            // 
            this.bookNumberDataGridViewTextBoxColumn1.DataPropertyName = "BookNumber";
            this.bookNumberDataGridViewTextBoxColumn1.HeaderText = "BookNumber";
            this.bookNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookNumberDataGridViewTextBoxColumn1.Name = "bookNumberDataGridViewTextBoxColumn1";
            this.bookNumberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 683);
            this.Controls.Add(this.report3);
            this.Controls.Add(this.report2);
            this.Controls.Add(this.report1);
            this.Controls.Add(this.grid_tra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_muon);
            this.Controls.Add(this.label1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_muon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traSachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_muon;
        private Do_an_oopDataSet1 do_an_oopDataSet1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private Do_an_oopDataSet1TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_tra;
        private Do_an_oopDataSet2 do_an_oopDataSet2;
        private System.Windows.Forms.BindingSource traSachBindingSource;
        private Do_an_oopDataSet2TableAdapters.traSachTableAdapter traSachTableAdapter;
        private System.Windows.Forms.Button report1;
        private System.Windows.Forms.Button report2;
        private System.Windows.Forms.Button report3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNumberDataGridViewTextBoxColumn1;
    }
}