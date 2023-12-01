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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.label1 = new System.Windows.Forms.Label();
            this.grid_muon = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.do_an_oopDataSet1 = new DoAnOOP.Do_an_oopDataSet1();
            this.memberTableAdapter = new DoAnOOP.Do_an_oopDataSet1TableAdapters.MemberTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_tra = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.do_an_oopDataSet2 = new DoAnOOP.Do_an_oopDataSet2();
            this.traSachTableAdapter = new DoAnOOP.Do_an_oopDataSet2TableAdapters.traSachTableAdapter();
            this.report1 = new System.Windows.Forms.Button();
            this.report2 = new System.Windows.Forms.Button();
            this.report3 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_muon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách người dùng đang mượn sách";
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
            this.grid_muon.Location = new System.Drawing.Point(-2, 143);
            this.grid_muon.Name = "grid_muon";
            this.grid_muon.RowHeadersWidth = 51;
            this.grid_muon.RowTemplate.Height = 24;
            this.grid_muon.Size = new System.Drawing.Size(661, 210);
            this.grid_muon.TabIndex = 1;
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
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.do_an_oopDataSet1;
            // 
            // do_an_oopDataSet1
            // 
            this.do_an_oopDataSet1.DataSetName = "Do_an_oopDataSet1";
            this.do_an_oopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách người dùng đã trả sách";
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
            this.grid_tra.Location = new System.Drawing.Point(675, 143);
            this.grid_tra.Name = "grid_tra";
            this.grid_tra.RowHeadersWidth = 51;
            this.grid_tra.RowTemplate.Height = 24;
            this.grid_tra.Size = new System.Drawing.Size(727, 210);
            this.grid_tra.TabIndex = 3;
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
            // traSachBindingSource
            // 
            this.traSachBindingSource.DataMember = "traSach";
            this.traSachBindingSource.DataSource = this.do_an_oopDataSet2;
            // 
            // do_an_oopDataSet2
            // 
            this.do_an_oopDataSet2.DataSetName = "Do_an_oopDataSet2";
            this.do_an_oopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traSachTableAdapter
            // 
            this.traSachTableAdapter.ClearBeforeFill = true;
            // 
            // report1
            // 
            this.report1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.report1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report1.Location = new System.Drawing.Point(164, 419);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(169, 68);
            this.report1.TabIndex = 4;
            this.report1.Text = "Report";
            this.report1.UseVisualStyleBackColor = false;
            this.report1.Click += new System.EventHandler(this.report1_Click);
            // 
            // report2
            // 
            this.report2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.report2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report2.Location = new System.Drawing.Point(1011, 408);
            this.report2.Name = "report2";
            this.report2.Size = new System.Drawing.Size(169, 65);
            this.report2.TabIndex = 5;
            this.report2.Text = "Report";
            this.report2.UseVisualStyleBackColor = false;
            this.report2.Click += new System.EventHandler(this.report2_Click);
            // 
            // report3
            // 
            this.report3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.report3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.report3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report3.Location = new System.Drawing.Point(608, 575);
            this.report3.Name = "report3";
            this.report3.Size = new System.Drawing.Size(186, 66);
            this.report3.TabIndex = 6;
            this.report3.Text = "XUẤT FILE";
            this.report3.UseVisualStyleBackColor = false;
            this.report3.Click += new System.EventHandler(this.report3_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1299, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 48);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 575);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1404, 397);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("STHupo", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(555, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "GENERATE REPORT";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1402, 683);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.report3);
            this.Controls.Add(this.report2);
            this.Controls.Add(this.report1);
            this.Controls.Add(this.grid_tra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_muon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report";
            this.Text = "GENERATE REPORT";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_muon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}