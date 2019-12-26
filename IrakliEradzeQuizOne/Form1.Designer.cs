namespace IrakliEradzeQuizOne
{
    partial class CrudForm
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
            this.BooksGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleCTxt = new System.Windows.Forms.TextBox();
            this.AuthorNameCTxt = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AuthorNameRTxt = new System.Windows.Forms.TextBox();
            this.TitleRTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.TransactionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdUpdate = new System.Windows.Forms.NumericUpDown();
            this.IdDelete = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ExecuteProcedureBtn = new System.Windows.Forms.Button();
            this.AuthorNameProcedure = new System.Windows.Forms.TextBox();
            this.TitleProcedure = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksGridView
            // 
            this.BooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGridView.Location = new System.Drawing.Point(261, 45);
            this.BooksGridView.Name = "BooksGridView";
            this.BooksGridView.Size = new System.Drawing.Size(249, 150);
            this.BooksGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Read";
            // 
            // TitleCTxt
            // 
            this.TitleCTxt.Location = new System.Drawing.Point(12, 45);
            this.TitleCTxt.Name = "TitleCTxt";
            this.TitleCTxt.Size = new System.Drawing.Size(169, 20);
            this.TitleCTxt.TabIndex = 2;
            this.TitleCTxt.Text = "Title";
            // 
            // AuthorNameCTxt
            // 
            this.AuthorNameCTxt.Location = new System.Drawing.Point(12, 99);
            this.AuthorNameCTxt.Name = "AuthorNameCTxt";
            this.AuthorNameCTxt.Size = new System.Drawing.Size(169, 20);
            this.AuthorNameCTxt.TabIndex = 3;
            this.AuthorNameCTxt.Text = "AuthorName";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(12, 164);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(169, 31);
            this.CreateBtn.TabIndex = 5;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create";
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.Location = new System.Drawing.Point(9, 239);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(42, 13);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(12, 382);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(169, 31);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AuthorNameRTxt
            // 
            this.AuthorNameRTxt.Location = new System.Drawing.Point(12, 304);
            this.AuthorNameRTxt.Name = "AuthorNameRTxt";
            this.AuthorNameRTxt.Size = new System.Drawing.Size(169, 20);
            this.AuthorNameRTxt.TabIndex = 8;
            this.AuthorNameRTxt.Text = "AuthorName";
            // 
            // TitleRTxt
            // 
            this.TitleRTxt.Location = new System.Drawing.Point(12, 342);
            this.TitleRTxt.Name = "TitleRTxt";
            this.TitleRTxt.Size = new System.Drawing.Size(169, 20);
            this.TitleRTxt.TabIndex = 7;
            this.TitleRTxt.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DeleteById";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(261, 298);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(116, 31);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // TransactionBtn
            // 
            this.TransactionBtn.Location = new System.Drawing.Point(397, 298);
            this.TransactionBtn.Name = "TransactionBtn";
            this.TransactionBtn.Size = new System.Drawing.Size(113, 31);
            this.TransactionBtn.TabIndex = 15;
            this.TransactionBtn.Text = "Transaction";
            this.TransactionBtn.UseVisualStyleBackColor = true;
            this.TransactionBtn.Click += new System.EventHandler(this.TransactionBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Transaction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "This button will run transaction";
            // 
            // IdUpdate
            // 
            this.IdUpdate.Location = new System.Drawing.Point(12, 262);
            this.IdUpdate.Name = "IdUpdate";
            this.IdUpdate.Size = new System.Drawing.Size(169, 20);
            this.IdUpdate.TabIndex = 18;
            // 
            // IdDelete
            // 
            this.IdDelete.Location = new System.Drawing.Point(261, 262);
            this.IdDelete.Name = "IdDelete";
            this.IdDelete.Size = new System.Drawing.Size(116, 20);
            this.IdDelete.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExecuteProcedureBtn
            // 
            this.ExecuteProcedureBtn.Location = new System.Drawing.Point(252, 382);
            this.ExecuteProcedureBtn.Name = "ExecuteProcedureBtn";
            this.ExecuteProcedureBtn.Size = new System.Drawing.Size(258, 31);
            this.ExecuteProcedureBtn.TabIndex = 21;
            this.ExecuteProcedureBtn.Text = "Execute Procedure";
            this.ExecuteProcedureBtn.UseVisualStyleBackColor = true;
            this.ExecuteProcedureBtn.Click += new System.EventHandler(this.ExecuteProcedureBtn_Click);
            // 
            // AuthorNameProcedure
            // 
            this.AuthorNameProcedure.Location = new System.Drawing.Point(379, 356);
            this.AuthorNameProcedure.Name = "AuthorNameProcedure";
            this.AuthorNameProcedure.Size = new System.Drawing.Size(131, 20);
            this.AuthorNameProcedure.TabIndex = 23;
            this.AuthorNameProcedure.Text = "AuthorName";
            // 
            // TitleProcedure
            // 
            this.TitleProcedure.Location = new System.Drawing.Point(252, 356);
            this.TitleProcedure.Name = "TitleProcedure";
            this.TitleProcedure.Size = new System.Drawing.Size(110, 20);
            this.TitleProcedure.TabIndex = 22;
            this.TitleProcedure.Text = "Title";
            // 
            // CrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.AuthorNameProcedure);
            this.Controls.Add(this.TitleProcedure);
            this.Controls.Add(this.ExecuteProcedureBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdDelete);
            this.Controls.Add(this.IdUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransactionBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AuthorNameRTxt);
            this.Controls.Add(this.TitleRTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.AuthorNameCTxt);
            this.Controls.Add(this.TitleCTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BooksGridView);
            this.Name = "CrudForm";
            this.Text = "CrudOperations";
            this.Load += new System.EventHandler(this.CrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleCTxt;
        private System.Windows.Forms.TextBox AuthorNameCTxt;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Update;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox AuthorNameRTxt;
        private System.Windows.Forms.TextBox TitleRTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button TransactionBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdUpdate;
        private System.Windows.Forms.NumericUpDown IdDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExecuteProcedureBtn;
        private System.Windows.Forms.TextBox AuthorNameProcedure;
        private System.Windows.Forms.TextBox TitleProcedure;
    }
}

