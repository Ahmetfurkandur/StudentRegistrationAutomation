namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.gbxStudentName = new System.Windows.Forms.GroupBox();
            this.tbxStudentNameSearch = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblTcIdentityNoSearch = new System.Windows.Forms.Label();
            this.tbxTcIdentityNoSearch = new System.Windows.Forms.TextBox();
            this.gbxTcIdentityNo = new System.Windows.Forms.GroupBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTcIdentityNo = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxParentsSurname = new System.Windows.Forms.TextBox();
            this.tbxBirthdayDate = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxTcIdentityNo = new System.Windows.Forms.TextBox();
            this.tbxParentsName = new System.Windows.Forms.TextBox();
            this.lblParentsPhoneNumber = new System.Windows.Forms.Label();
            this.lblParentsSurname = new System.Windows.Forms.Label();
            this.lblParentsName = new System.Windows.Forms.Label();
            this.lblBirthdayDate = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTcIdentityNoUpdate = new System.Windows.Forms.Label();
            this.tbxParentsPhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.tbxParentsSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxBirthdayDateUpdate = new System.Windows.Forms.TextBox();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxTcIdentityNoUpdate = new System.Windows.Forms.TextBox();
            this.tbxParentNameUpdate = new System.Windows.Forms.TextBox();
            this.lblParentPhoneNumberUpdate = new System.Windows.Forms.Label();
            this.lblParentSurname = new System.Windows.Forms.Label();
            this.lblParentNameUpdate = new System.Windows.Forms.Label();
            this.lblBirthdayDateUpdate = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.gbxStudentName.SuspendLayout();
            this.gbxTcIdentityNo.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStudents
            // 
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwStudents.Location = new System.Drawing.Point(12, 227);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.Size = new System.Drawing.Size(776, 178);
            this.dgwStudents.TabIndex = 0;
            this.dgwStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellClick);
            // 
            // gbxStudentName
            // 
            this.gbxStudentName.Controls.Add(this.tbxStudentNameSearch);
            this.gbxStudentName.Controls.Add(this.lblStudentName);
            this.gbxStudentName.Location = new System.Drawing.Point(12, 98);
            this.gbxStudentName.Name = "gbxStudentName";
            this.gbxStudentName.Size = new System.Drawing.Size(776, 92);
            this.gbxStudentName.TabIndex = 2;
            this.gbxStudentName.TabStop = false;
            this.gbxStudentName.Text = "Öğrenci İsmine Göre Ara";
            // 
            // tbxStudentNameSearch
            // 
            this.tbxStudentNameSearch.Location = new System.Drawing.Point(108, 43);
            this.tbxStudentNameSearch.Name = "tbxStudentNameSearch";
            this.tbxStudentNameSearch.Size = new System.Drawing.Size(183, 20);
            this.tbxStudentNameSearch.TabIndex = 1;
            this.tbxStudentNameSearch.TextChanged += new System.EventHandler(this.tbxStudentNameSearch_TextChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(37, 46);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(65, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Öğrenci İsmi";
            // 
            // lblTcIdentityNoSearch
            // 
            this.lblTcIdentityNoSearch.AutoSize = true;
            this.lblTcIdentityNoSearch.Location = new System.Drawing.Point(6, 43);
            this.lblTcIdentityNoSearch.Name = "lblTcIdentityNoSearch";
            this.lblTcIdentityNoSearch.Size = new System.Drawing.Size(97, 13);
            this.lblTcIdentityNoSearch.TabIndex = 0;
            this.lblTcIdentityNoSearch.Text = "Tc Kimlik Numarası";
            // 
            // tbxTcIdentityNoSearch
            // 
            this.tbxTcIdentityNoSearch.Location = new System.Drawing.Point(108, 36);
            this.tbxTcIdentityNoSearch.Name = "tbxTcIdentityNoSearch";
            this.tbxTcIdentityNoSearch.Size = new System.Drawing.Size(183, 20);
            this.tbxTcIdentityNoSearch.TabIndex = 1;
            this.tbxTcIdentityNoSearch.TextChanged += new System.EventHandler(this.tbxTcIdentityNoSearch_TextChanged);
            // 
            // gbxTcIdentityNo
            // 
            this.gbxTcIdentityNo.Controls.Add(this.tbxTcIdentityNoSearch);
            this.gbxTcIdentityNo.Controls.Add(this.lblTcIdentityNoSearch);
            this.gbxTcIdentityNo.Location = new System.Drawing.Point(12, 12);
            this.gbxTcIdentityNo.Name = "gbxTcIdentityNo";
            this.gbxTcIdentityNo.Size = new System.Drawing.Size(776, 80);
            this.gbxTcIdentityNo.TabIndex = 1;
            this.gbxTcIdentityNo.TabStop = false;
            this.gbxTcIdentityNo.Text = "Tc kimlik numarasına göre";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblTcIdentityNo);
            this.gbxAdd.Controls.Add(this.tbxPhoneNumber);
            this.gbxAdd.Controls.Add(this.tbxParentsSurname);
            this.gbxAdd.Controls.Add(this.tbxBirthdayDate);
            this.gbxAdd.Controls.Add(this.tbxSurname);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxTcIdentityNo);
            this.gbxAdd.Controls.Add(this.tbxParentsName);
            this.gbxAdd.Controls.Add(this.lblParentsPhoneNumber);
            this.gbxAdd.Controls.Add(this.lblParentsSurname);
            this.gbxAdd.Controls.Add(this.lblParentsName);
            this.gbxAdd.Controls.Add(this.lblBirthdayDate);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Location = new System.Drawing.Point(811, 12);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(346, 178);
            this.gbxAdd.TabIndex = 3;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Öğrenci Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 20);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTcIdentityNo
            // 
            this.lblTcIdentityNo.AutoSize = true;
            this.lblTcIdentityNo.Location = new System.Drawing.Point(6, 39);
            this.lblTcIdentityNo.Name = "lblTcIdentityNo";
            this.lblTcIdentityNo.Size = new System.Drawing.Size(67, 13);
            this.lblTcIdentityNo.TabIndex = 15;
            this.lblTcIdentityNo.Text = "Tc Kimlik No";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(240, 113);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxPhoneNumber.TabIndex = 14;
            // 
            // tbxParentsSurname
            // 
            this.tbxParentsSurname.Location = new System.Drawing.Point(240, 74);
            this.tbxParentsSurname.Name = "tbxParentsSurname";
            this.tbxParentsSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxParentsSurname.TabIndex = 13;
            // 
            // tbxBirthdayDate
            // 
            this.tbxBirthdayDate.Location = new System.Drawing.Point(79, 146);
            this.tbxBirthdayDate.Name = "tbxBirthdayDate";
            this.tbxBirthdayDate.Size = new System.Drawing.Size(100, 20);
            this.tbxBirthdayDate.TabIndex = 12;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(79, 113);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 11;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(79, 74);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 10;
            // 
            // tbxTcIdentityNo
            // 
            this.tbxTcIdentityNo.Location = new System.Drawing.Point(79, 32);
            this.tbxTcIdentityNo.Name = "tbxTcIdentityNo";
            this.tbxTcIdentityNo.Size = new System.Drawing.Size(100, 20);
            this.tbxTcIdentityNo.TabIndex = 9;
            // 
            // tbxParentsName
            // 
            this.tbxParentsName.Location = new System.Drawing.Point(240, 32);
            this.tbxParentsName.Name = "tbxParentsName";
            this.tbxParentsName.Size = new System.Drawing.Size(100, 20);
            this.tbxParentsName.TabIndex = 8;
            // 
            // lblParentsPhoneNumber
            // 
            this.lblParentsPhoneNumber.AutoSize = true;
            this.lblParentsPhoneNumber.Location = new System.Drawing.Point(181, 120);
            this.lblParentsPhoneNumber.Name = "lblParentsPhoneNumber";
            this.lblParentsPhoneNumber.Size = new System.Drawing.Size(59, 13);
            this.lblParentsPhoneNumber.TabIndex = 6;
            this.lblParentsPhoneNumber.Text = "Veli Tel No";
            // 
            // lblParentsSurname
            // 
            this.lblParentsSurname.AutoSize = true;
            this.lblParentsSurname.Location = new System.Drawing.Point(181, 81);
            this.lblParentsSurname.Name = "lblParentsSurname";
            this.lblParentsSurname.Size = new System.Drawing.Size(59, 13);
            this.lblParentsSurname.TabIndex = 5;
            this.lblParentsSurname.Text = "Veli Soyadı";
            // 
            // lblParentsName
            // 
            this.lblParentsName.AutoSize = true;
            this.lblParentsName.Location = new System.Drawing.Point(192, 39);
            this.lblParentsName.Name = "lblParentsName";
            this.lblParentsName.Size = new System.Drawing.Size(42, 13);
            this.lblParentsName.TabIndex = 4;
            this.lblParentsName.Text = "Veli Adı";
            // 
            // lblBirthdayDate
            // 
            this.lblBirthdayDate.AutoSize = true;
            this.lblBirthdayDate.Location = new System.Drawing.Point(3, 153);
            this.lblBirthdayDate.Name = "lblBirthdayDate";
            this.lblBirthdayDate.Size = new System.Drawing.Size(70, 13);
            this.lblBirthdayDate.TabIndex = 3;
            this.lblBirthdayDate.Text = "Doğum Tarihi";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(34, 120);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(39, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Soyadı";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(22, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Adı";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblTcIdentityNoUpdate);
            this.gbxUpdate.Controls.Add(this.tbxParentsPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.tbxParentsSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxBirthdayDateUpdate);
            this.gbxUpdate.Controls.Add(this.tbxSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxTcIdentityNoUpdate);
            this.gbxUpdate.Controls.Add(this.tbxParentNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblParentPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblParentSurname);
            this.gbxUpdate.Controls.Add(this.lblParentNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblBirthdayDateUpdate);
            this.gbxUpdate.Controls.Add(this.lblSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(817, 222);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(346, 183);
            this.gbxUpdate.TabIndex = 17;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Mevcut Öğrenciyi Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(240, 146);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 20);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTcIdentityNoUpdate
            // 
            this.lblTcIdentityNoUpdate.AutoSize = true;
            this.lblTcIdentityNoUpdate.Location = new System.Drawing.Point(6, 39);
            this.lblTcIdentityNoUpdate.Name = "lblTcIdentityNoUpdate";
            this.lblTcIdentityNoUpdate.Size = new System.Drawing.Size(67, 13);
            this.lblTcIdentityNoUpdate.TabIndex = 15;
            this.lblTcIdentityNoUpdate.Text = "Tc Kimlik No";
            // 
            // tbxParentsPhoneNumberUpdate
            // 
            this.tbxParentsPhoneNumberUpdate.Location = new System.Drawing.Point(240, 113);
            this.tbxParentsPhoneNumberUpdate.Name = "tbxParentsPhoneNumberUpdate";
            this.tbxParentsPhoneNumberUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxParentsPhoneNumberUpdate.TabIndex = 14;
            // 
            // tbxParentsSurnameUpdate
            // 
            this.tbxParentsSurnameUpdate.Location = new System.Drawing.Point(240, 74);
            this.tbxParentsSurnameUpdate.Name = "tbxParentsSurnameUpdate";
            this.tbxParentsSurnameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxParentsSurnameUpdate.TabIndex = 13;
            // 
            // tbxBirthdayDateUpdate
            // 
            this.tbxBirthdayDateUpdate.Location = new System.Drawing.Point(79, 146);
            this.tbxBirthdayDateUpdate.Name = "tbxBirthdayDateUpdate";
            this.tbxBirthdayDateUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxBirthdayDateUpdate.TabIndex = 12;
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(79, 113);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxSurnameUpdate.TabIndex = 11;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(79, 74);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxNameUpdate.TabIndex = 10;
            // 
            // tbxTcIdentityNoUpdate
            // 
            this.tbxTcIdentityNoUpdate.Location = new System.Drawing.Point(79, 32);
            this.tbxTcIdentityNoUpdate.Name = "tbxTcIdentityNoUpdate";
            this.tbxTcIdentityNoUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxTcIdentityNoUpdate.TabIndex = 9;
            // 
            // tbxParentNameUpdate
            // 
            this.tbxParentNameUpdate.Location = new System.Drawing.Point(240, 32);
            this.tbxParentNameUpdate.Name = "tbxParentNameUpdate";
            this.tbxParentNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxParentNameUpdate.TabIndex = 8;
            // 
            // lblParentPhoneNumberUpdate
            // 
            this.lblParentPhoneNumberUpdate.AutoSize = true;
            this.lblParentPhoneNumberUpdate.Location = new System.Drawing.Point(181, 120);
            this.lblParentPhoneNumberUpdate.Name = "lblParentPhoneNumberUpdate";
            this.lblParentPhoneNumberUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblParentPhoneNumberUpdate.TabIndex = 6;
            this.lblParentPhoneNumberUpdate.Text = "Veli Tel No";
            // 
            // lblParentSurname
            // 
            this.lblParentSurname.AutoSize = true;
            this.lblParentSurname.Location = new System.Drawing.Point(181, 81);
            this.lblParentSurname.Name = "lblParentSurname";
            this.lblParentSurname.Size = new System.Drawing.Size(59, 13);
            this.lblParentSurname.TabIndex = 5;
            this.lblParentSurname.Text = "Veli Soyadı";
            // 
            // lblParentNameUpdate
            // 
            this.lblParentNameUpdate.AutoSize = true;
            this.lblParentNameUpdate.Location = new System.Drawing.Point(192, 39);
            this.lblParentNameUpdate.Name = "lblParentNameUpdate";
            this.lblParentNameUpdate.Size = new System.Drawing.Size(42, 13);
            this.lblParentNameUpdate.TabIndex = 4;
            this.lblParentNameUpdate.Text = "Veli Adı";
            // 
            // lblBirthdayDateUpdate
            // 
            this.lblBirthdayDateUpdate.AutoSize = true;
            this.lblBirthdayDateUpdate.Location = new System.Drawing.Point(3, 153);
            this.lblBirthdayDateUpdate.Name = "lblBirthdayDateUpdate";
            this.lblBirthdayDateUpdate.Size = new System.Drawing.Size(70, 13);
            this.lblBirthdayDateUpdate.TabIndex = 3;
            this.lblBirthdayDateUpdate.Text = "Doğum Tarihi";
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(34, 120);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(39, 13);
            this.lblSurnameUpdate.TabIndex = 2;
            this.lblSurnameUpdate.Text = "Soyadı";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(51, 81);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(22, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(21, 198);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 419);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxStudentName);
            this.Controls.Add(this.gbxTcIdentityNo);
            this.Controls.Add(this.dgwStudents);
            this.Name = "Form1";
            this.Text = "Yönetim Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.gbxStudentName.ResumeLayout(false);
            this.gbxStudentName.PerformLayout();
            this.gbxTcIdentityNo.ResumeLayout(false);
            this.gbxTcIdentityNo.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.GroupBox gbxStudentName;
        private System.Windows.Forms.TextBox tbxStudentNameSearch;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblTcIdentityNoSearch;
        private System.Windows.Forms.TextBox tbxTcIdentityNoSearch;
        private System.Windows.Forms.GroupBox gbxTcIdentityNo;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblParentsName;
        private System.Windows.Forms.Label lblBirthdayDate;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxParentsSurname;
        private System.Windows.Forms.TextBox tbxBirthdayDate;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxTcIdentityNo;
        private System.Windows.Forms.TextBox tbxParentsName;
        private System.Windows.Forms.Label lblParentsPhoneNumber;
        private System.Windows.Forms.Label lblParentsSurname;
        private System.Windows.Forms.Label lblTcIdentityNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTcIdentityNoUpdate;
        private System.Windows.Forms.TextBox tbxParentsPhoneNumberUpdate;
        private System.Windows.Forms.TextBox tbxParentsSurnameUpdate;
        private System.Windows.Forms.TextBox tbxBirthdayDateUpdate;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxTcIdentityNoUpdate;
        private System.Windows.Forms.TextBox tbxParentNameUpdate;
        private System.Windows.Forms.Label lblParentPhoneNumberUpdate;
        private System.Windows.Forms.Label lblParentSurname;
        private System.Windows.Forms.Label lblParentNameUpdate;
        private System.Windows.Forms.Label lblBirthdayDateUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

