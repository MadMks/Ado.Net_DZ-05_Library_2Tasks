namespace Task_1
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
            this.groupBoxAllButtonQuery = new System.Windows.Forms.GroupBox();
            this.buttonFifthQuery = new System.Windows.Forms.Button();
            this.buttonFourthQuery = new System.Windows.Forms.Button();
            this.buttonThirdQuery = new System.Windows.Forms.Button();
            this.buttonSecondQuery = new System.Windows.Forms.Button();
            this.buttonFirstQuery = new System.Windows.Forms.Button();
            this.groupBoxTaskText = new System.Windows.Forms.GroupBox();
            this.textBoxTaskText = new System.Windows.Forms.TextBox();
            this.dataGridViewQueryResult = new System.Windows.Forms.DataGridView();
            this.groupBoxAllButtonQuery.SuspendLayout();
            this.groupBoxTaskText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAllButtonQuery
            // 
            this.groupBoxAllButtonQuery.Controls.Add(this.buttonFifthQuery);
            this.groupBoxAllButtonQuery.Controls.Add(this.buttonFourthQuery);
            this.groupBoxAllButtonQuery.Controls.Add(this.buttonThirdQuery);
            this.groupBoxAllButtonQuery.Controls.Add(this.buttonSecondQuery);
            this.groupBoxAllButtonQuery.Controls.Add(this.buttonFirstQuery);
            this.groupBoxAllButtonQuery.Location = new System.Drawing.Point(16, 14);
            this.groupBoxAllButtonQuery.Name = "groupBoxAllButtonQuery";
            this.groupBoxAllButtonQuery.Size = new System.Drawing.Size(545, 73);
            this.groupBoxAllButtonQuery.TabIndex = 0;
            this.groupBoxAllButtonQuery.TabStop = false;
            this.groupBoxAllButtonQuery.Text = "Запросы";
            // 
            // buttonFifthQuery
            // 
            this.buttonFifthQuery.Location = new System.Drawing.Point(335, 28);
            this.buttonFifthQuery.Name = "buttonFifthQuery";
            this.buttonFifthQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonFifthQuery.TabIndex = 4;
            this.buttonFifthQuery.Text = "5";
            this.buttonFifthQuery.UseVisualStyleBackColor = true;
            this.buttonFifthQuery.Click += new System.EventHandler(this.buttonFifthQuery_Click);
            // 
            // buttonFourthQuery
            // 
            this.buttonFourthQuery.Location = new System.Drawing.Point(254, 28);
            this.buttonFourthQuery.Name = "buttonFourthQuery";
            this.buttonFourthQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonFourthQuery.TabIndex = 3;
            this.buttonFourthQuery.Text = "4";
            this.buttonFourthQuery.UseVisualStyleBackColor = true;
            this.buttonFourthQuery.Click += new System.EventHandler(this.buttonFourthQuery_Click);
            // 
            // buttonThirdQuery
            // 
            this.buttonThirdQuery.Location = new System.Drawing.Point(173, 28);
            this.buttonThirdQuery.Name = "buttonThirdQuery";
            this.buttonThirdQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonThirdQuery.TabIndex = 2;
            this.buttonThirdQuery.Text = "3";
            this.buttonThirdQuery.UseVisualStyleBackColor = true;
            this.buttonThirdQuery.Click += new System.EventHandler(this.buttonThirdQuery_Click);
            // 
            // buttonSecondQuery
            // 
            this.buttonSecondQuery.Location = new System.Drawing.Point(92, 28);
            this.buttonSecondQuery.Name = "buttonSecondQuery";
            this.buttonSecondQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonSecondQuery.TabIndex = 1;
            this.buttonSecondQuery.Text = "2";
            this.buttonSecondQuery.UseVisualStyleBackColor = true;
            this.buttonSecondQuery.Click += new System.EventHandler(this.buttonSecondQuery_Click);
            // 
            // buttonFirstQuery
            // 
            this.buttonFirstQuery.Location = new System.Drawing.Point(11, 28);
            this.buttonFirstQuery.Name = "buttonFirstQuery";
            this.buttonFirstQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonFirstQuery.TabIndex = 0;
            this.buttonFirstQuery.Text = "1";
            this.buttonFirstQuery.UseVisualStyleBackColor = true;
            this.buttonFirstQuery.Click += new System.EventHandler(this.buttonFirstQuery_Click);
            // 
            // groupBoxTaskText
            // 
            this.groupBoxTaskText.Controls.Add(this.textBoxTaskText);
            this.groupBoxTaskText.Location = new System.Drawing.Point(16, 101);
            this.groupBoxTaskText.Name = "groupBoxTaskText";
            this.groupBoxTaskText.Size = new System.Drawing.Size(545, 58);
            this.groupBoxTaskText.TabIndex = 1;
            this.groupBoxTaskText.TabStop = false;
            this.groupBoxTaskText.Text = "Задача запроса";
            // 
            // textBoxTaskText
            // 
            this.textBoxTaskText.Location = new System.Drawing.Point(11, 22);
            this.textBoxTaskText.Name = "textBoxTaskText";
            this.textBoxTaskText.ReadOnly = true;
            this.textBoxTaskText.Size = new System.Drawing.Size(519, 21);
            this.textBoxTaskText.TabIndex = 0;
            // 
            // dataGridViewQueryResult
            // 
            this.dataGridViewQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryResult.Location = new System.Drawing.Point(16, 178);
            this.dataGridViewQueryResult.Name = "dataGridViewQueryResult";
            this.dataGridViewQueryResult.ReadOnly = true;
            this.dataGridViewQueryResult.RowTemplate.Height = 23;
            this.dataGridViewQueryResult.Size = new System.Drawing.Size(545, 252);
            this.dataGridViewQueryResult.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.dataGridViewQueryResult);
            this.Controls.Add(this.groupBoxTaskText);
            this.Controls.Add(this.groupBoxAllButtonQuery);
            this.Name = "MainForm";
            this.Text = "Task 1";
            this.groupBoxAllButtonQuery.ResumeLayout(false);
            this.groupBoxTaskText.ResumeLayout(false);
            this.groupBoxTaskText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAllButtonQuery;
        private System.Windows.Forms.Button buttonFifthQuery;
        private System.Windows.Forms.Button buttonFourthQuery;
        private System.Windows.Forms.Button buttonThirdQuery;
        private System.Windows.Forms.Button buttonSecondQuery;
        private System.Windows.Forms.Button buttonFirstQuery;
        private System.Windows.Forms.GroupBox groupBoxTaskText;
        private System.Windows.Forms.TextBox textBoxTaskText;
        private System.Windows.Forms.DataGridView dataGridViewQueryResult;
    }
}

