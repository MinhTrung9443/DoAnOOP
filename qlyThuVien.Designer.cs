namespace DoAnOOP
{
    partial class qlyThuVien
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
            this.btn_signIn = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_viewMember = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_search_librarian = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grBox_libra = new System.Windows.Forms.GroupBox();
            this.grBox_mem = new System.Windows.Forms.GroupBox();
            this.btn_search_member = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.do_an_oopDataSet = new DoAnOOP.Do_an_oopDataSet();
            this.bookTableAdapter = new DoAnOOP.Do_an_oopDataSetTableAdapters.BookTableAdapter();
            this.lbl_hienThi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grBox_libra.SuspendLayout();
            this.grBox_mem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(245, 49);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(117, 46);
            this.btn_signIn.TabIndex = 0;
            this.btn_signIn.Text = "Sign in";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Location = new System.Drawing.Point(81, 49);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(117, 46);
            this.btn_signUp.TabIndex = 1;
            this.btn_signUp.Text = "Sign up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(87, 40);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 46);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add Book";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_viewMember
            // 
            this.btn_viewMember.Location = new System.Drawing.Point(251, 40);
            this.btn_viewMember.Name = "btn_viewMember";
            this.btn_viewMember.Size = new System.Drawing.Size(117, 46);
            this.btn_viewMember.TabIndex = 3;
            this.btn_viewMember.Text = "View member";
            this.btn_viewMember.UseVisualStyleBackColor = true;
            this.btn_viewMember.Click += new System.EventHandler(this.btn_viewMember_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(171, 122);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(117, 46);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_search_librarian
            // 
            this.btn_search_librarian.Location = new System.Drawing.Point(171, 218);
            this.btn_search_librarian.Name = "btn_search_librarian";
            this.btn_search_librarian.Size = new System.Drawing.Size(117, 46);
            this.btn_search_librarian.TabIndex = 5;
            this.btn_search_librarian.Text = "Search";
            this.btn_search_librarian.UseVisualStyleBackColor = true;
            this.btn_search_librarian.Click += new System.EventHandler(this.btn_search_librarian_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_signUp);
            this.groupBox1.Controls.Add(this.btn_signIn);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(842, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // grBox_libra
            // 
            this.grBox_libra.Controls.Add(this.btn_search_librarian);
            this.grBox_libra.Controls.Add(this.btn_report);
            this.grBox_libra.Controls.Add(this.btn_viewMember);
            this.grBox_libra.Controls.Add(this.btn_add);
            this.grBox_libra.Location = new System.Drawing.Point(842, 201);
            this.grBox_libra.Name = "grBox_libra";
            this.grBox_libra.Size = new System.Drawing.Size(416, 318);
            this.grBox_libra.TabIndex = 7;
            this.grBox_libra.TabStop = false;
            this.grBox_libra.Visible = false;
            // 
            // grBox_mem
            // 
            this.grBox_mem.Controls.Add(this.btn_search_member);
            this.grBox_mem.Controls.Add(this.btn_return);
            this.grBox_mem.Controls.Add(this.btn_issue);
            this.grBox_mem.Location = new System.Drawing.Point(842, 232);
            this.grBox_mem.Name = "grBox_mem";
            this.grBox_mem.Size = new System.Drawing.Size(414, 317);
            this.grBox_mem.TabIndex = 10;
            this.grBox_mem.TabStop = false;
            this.grBox_mem.Visible = false;
            // 
            // btn_search_member
            // 
            this.btn_search_member.Location = new System.Drawing.Point(133, 180);
            this.btn_search_member.Name = "btn_search_member";
            this.btn_search_member.Size = new System.Drawing.Size(117, 46);
            this.btn_search_member.TabIndex = 9;
            this.btn_search_member.Text = "Search";
            this.btn_search_member.UseVisualStyleBackColor = true;
            this.btn_search_member.Click += new System.EventHandler(this.btn_search_member_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(214, 49);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(117, 46);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "Return Book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_issue
            // 
            this.btn_issue.Location = new System.Drawing.Point(50, 49);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(117, 46);
            this.btn_issue.TabIndex = 6;
            this.btn_issue.Text = "Issue Book";
            this.btn_issue.UseVisualStyleBackColor = true;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCodeDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 568);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            // 
            // bookCodeDataGridViewTextBoxColumn
            // 
            this.bookCodeDataGridViewTextBoxColumn.DataPropertyName = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.HeaderText = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookCodeDataGridViewTextBoxColumn.Name = "bookCodeDataGridViewTextBoxColumn";
            this.bookCodeDataGridViewTextBoxColumn.Width = 75;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 110;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.do_an_oopDataSet;
            // 
            // do_an_oopDataSet
            // 
            this.do_an_oopDataSet.DataSetName = "Do_an_oopDataSet";
            this.do_an_oopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_hienThi
            // 
            this.lbl_hienThi.AutoSize = true;
            this.lbl_hienThi.Location = new System.Drawing.Point(839, 582);
            this.lbl_hienThi.Name = "lbl_hienThi";
            this.lbl_hienThi.Size = new System.Drawing.Size(44, 16);
            this.lbl_hienThi.TabIndex = 11;
            this.lbl_hienThi.Text = "label1";
            this.lbl_hienThi.Visible = false;
            // 
            // qlyThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 629);
            this.Controls.Add(this.lbl_hienThi);
            this.Controls.Add(this.grBox_mem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grBox_libra);
            this.Controls.Add(this.groupBox1);
            this.Name = "qlyThuVien";
            this.Text = "Quan ly thu vien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.grBox_libra.ResumeLayout(false);
            this.grBox_mem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_an_oopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_viewMember;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_search_librarian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grBox_libra;
        private System.Windows.Forms.Button btn_search_member;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.GroupBox grBox_mem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Do_an_oopDataSet do_an_oopDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private Do_an_oopDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_hienThi;
    }
}

