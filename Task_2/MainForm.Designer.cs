﻿namespace Task_2
{
    partial class MainForm
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
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridViewQueryResult = new System.Windows.Forms.DataGridView();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.groupBoxAuthors = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).BeginInit();
            this.groupBoxAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(13, 23);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(416, 21);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(451, 21);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridViewQueryResult
            // 
            this.dataGridViewQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryResult.Location = new System.Drawing.Point(13, 62);
            this.dataGridViewQueryResult.Name = "dataGridViewQueryResult";
            this.dataGridViewQueryResult.ReadOnly = true;
            this.dataGridViewQueryResult.RowTemplate.Height = 23;
            this.dataGridViewQueryResult.Size = new System.Drawing.Size(317, 290);
            this.dataGridViewQueryResult.TabIndex = 2;
            this.dataGridViewQueryResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQueryResult_CellClick);
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.Location = new System.Drawing.Point(15, 23);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(151, 251);
            this.listBoxAuthors.TabIndex = 3;
            // 
            // groupBoxAuthors
            // 
            this.groupBoxAuthors.Controls.Add(this.listBoxAuthors);
            this.groupBoxAuthors.Location = new System.Drawing.Point(347, 62);
            this.groupBoxAuthors.Name = "groupBoxAuthors";
            this.groupBoxAuthors.Size = new System.Drawing.Size(183, 290);
            this.groupBoxAuthors.TabIndex = 4;
            this.groupBoxAuthors.TabStop = false;
            this.groupBoxAuthors.Text = "Фамилии авторов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 367);
            this.Controls.Add(this.groupBoxAuthors);
            this.Controls.Add(this.dataGridViewQueryResult);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Task 2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).EndInit();
            this.groupBoxAuthors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridViewQueryResult;
        private System.Windows.Forms.ListBox listBoxAuthors;
        private System.Windows.Forms.GroupBox groupBoxAuthors;
    }
}

