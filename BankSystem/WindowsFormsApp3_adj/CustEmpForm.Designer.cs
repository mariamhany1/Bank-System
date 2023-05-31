
namespace WindowsFormsApp3
{
    partial class CustEmpForm
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
            System.Windows.Forms.Label eMPIDLabel;
            System.Windows.Forms.Label cUST_SSNLabel;
            this.eMPIDTextBox = new System.Windows.Forms.TextBox();
            this.cUST_SSNTextBox = new System.Windows.Forms.TextBox();
            this.cUST_EMPDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            eMPIDLabel = new System.Windows.Forms.Label();
            cUST_SSNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cUST_EMPDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eMPIDLabel
            // 
            eMPIDLabel.AutoSize = true;
            eMPIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eMPIDLabel.Location = new System.Drawing.Point(30, 103);
            eMPIDLabel.Name = "eMPIDLabel";
            eMPIDLabel.Size = new System.Drawing.Size(52, 16);
            eMPIDLabel.TabIndex = 1;
            eMPIDLabel.Text = "EMPID:";
            eMPIDLabel.Click += new System.EventHandler(this.eMPIDLabel_Click);
            // 
            // cUST_SSNLabel
            // 
            cUST_SSNLabel.AutoSize = true;
            cUST_SSNLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cUST_SSNLabel.Location = new System.Drawing.Point(30, 148);
            cUST_SSNLabel.Name = "cUST_SSNLabel";
            cUST_SSNLabel.Size = new System.Drawing.Size(78, 16);
            cUST_SSNLabel.TabIndex = 3;
            cUST_SSNLabel.Text = "CUST SSN:";
            cUST_SSNLabel.Click += new System.EventHandler(this.cUST_SSNLabel_Click);
            // 
            // eMPIDTextBox
            // 
            this.eMPIDTextBox.Location = new System.Drawing.Point(117, 100);
            this.eMPIDTextBox.Name = "eMPIDTextBox";
            this.eMPIDTextBox.Size = new System.Drawing.Size(191, 22);
            this.eMPIDTextBox.TabIndex = 2;
            this.eMPIDTextBox.TextChanged += new System.EventHandler(this.eMPIDTextBox_TextChanged);
            // 
            // cUST_SSNTextBox
            // 
            this.cUST_SSNTextBox.Location = new System.Drawing.Point(117, 145);
            this.cUST_SSNTextBox.Name = "cUST_SSNTextBox";
            this.cUST_SSNTextBox.Size = new System.Drawing.Size(191, 22);
            this.cUST_SSNTextBox.TabIndex = 4;
            this.cUST_SSNTextBox.TextChanged += new System.EventHandler(this.cUST_SSNTextBox_TextChanged);
            // 
            // cUST_EMPDataGridView
            // 
            this.cUST_EMPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUST_EMPDataGridView.Location = new System.Drawing.Point(48, 21);
            this.cUST_EMPDataGridView.Name = "cUST_EMPDataGridView";
            this.cUST_EMPDataGridView.RowHeadersWidth = 51;
            this.cUST_EMPDataGridView.RowTemplate.Height = 24;
            this.cUST_EMPDataGridView.Size = new System.Drawing.Size(286, 142);
            this.cUST_EMPDataGridView.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 53;
            this.label1.Text = "Customer & Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cUST_SSNTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eMPIDTextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(eMPIDLabel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(cUST_SSNLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(323, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 297);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 58;
            this.button5.Text = "Main";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(7, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 3);
            this.panel2.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(6, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 3);
            this.panel1.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cUST_EMPDataGridView);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(772, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 243);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // CustEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustEmpForm";
            this.Text = "CustEmpForm";
            this.Load += new System.EventHandler(this.CustEmpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUST_EMPDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox eMPIDTextBox;
        private System.Windows.Forms.TextBox cUST_SSNTextBox;
        private System.Windows.Forms.DataGridView cUST_EMPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}