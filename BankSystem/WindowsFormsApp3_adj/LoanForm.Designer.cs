
namespace WindowsFormsApp3
{
    partial class LoanForm
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
            System.Windows.Forms.Label lOANNUMLabel;
            System.Windows.Forms.Label lOANBRANCHNUMLabel;
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label eMPIDLabel;
            System.Windows.Forms.Label lOANTYPELabel;
            System.Windows.Forms.Label lOANAMOUNTLabel;
            this.lOANNUMTextBox = new System.Windows.Forms.TextBox();
            this.lOANBRANCHNUMTextBox = new System.Windows.Forms.TextBox();
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.eMPIDTextBox = new System.Windows.Forms.TextBox();
            this.lOANTYPETextBox = new System.Windows.Forms.TextBox();
            this.lOANAMOUNTTextBox = new System.Windows.Forms.TextBox();
            this.lOANDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            lOANNUMLabel = new System.Windows.Forms.Label();
            lOANBRANCHNUMLabel = new System.Windows.Forms.Label();
            sSNLabel = new System.Windows.Forms.Label();
            eMPIDLabel = new System.Windows.Forms.Label();
            lOANTYPELabel = new System.Windows.Forms.Label();
            lOANAMOUNTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOANDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOANNUMLabel
            // 
            lOANNUMLabel.AutoSize = true;
            lOANNUMLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lOANNUMLabel.Location = new System.Drawing.Point(25, 89);
            lOANNUMLabel.Name = "lOANNUMLabel";
            lOANNUMLabel.Size = new System.Drawing.Size(77, 16);
            lOANNUMLabel.TabIndex = 1;
            lOANNUMLabel.Text = "LOANNUM:";
            // 
            // lOANBRANCHNUMLabel
            // 
            lOANBRANCHNUMLabel.AutoSize = true;
            lOANBRANCHNUMLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lOANBRANCHNUMLabel.Location = new System.Drawing.Point(25, 135);
            lOANBRANCHNUMLabel.Name = "lOANBRANCHNUMLabel";
            lOANBRANCHNUMLabel.Size = new System.Drawing.Size(134, 16);
            lOANBRANCHNUMLabel.TabIndex = 3;
            lOANBRANCHNUMLabel.Text = "LOANBRANCHNUM:";
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            sSNLabel.Location = new System.Drawing.Point(25, 188);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(38, 16);
            sSNLabel.TabIndex = 5;
            sSNLabel.Text = "SSN:";
            // 
            // eMPIDLabel
            // 
            eMPIDLabel.AutoSize = true;
            eMPIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eMPIDLabel.Location = new System.Drawing.Point(25, 242);
            eMPIDLabel.Name = "eMPIDLabel";
            eMPIDLabel.Size = new System.Drawing.Size(52, 16);
            eMPIDLabel.TabIndex = 7;
            eMPIDLabel.Text = "EMPID:";
            // 
            // lOANTYPELabel
            // 
            lOANTYPELabel.AutoSize = true;
            lOANTYPELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lOANTYPELabel.Location = new System.Drawing.Point(25, 300);
            lOANTYPELabel.Name = "lOANTYPELabel";
            lOANTYPELabel.Size = new System.Drawing.Size(82, 16);
            lOANTYPELabel.TabIndex = 9;
            lOANTYPELabel.Text = "LOANTYPE:";
            // 
            // lOANAMOUNTLabel
            // 
            lOANAMOUNTLabel.AutoSize = true;
            lOANAMOUNTLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lOANAMOUNTLabel.Location = new System.Drawing.Point(25, 355);
            lOANAMOUNTLabel.Name = "lOANAMOUNTLabel";
            lOANAMOUNTLabel.Size = new System.Drawing.Size(105, 16);
            lOANAMOUNTLabel.TabIndex = 11;
            lOANAMOUNTLabel.Text = "LOANAMOUNT:";
            lOANAMOUNTLabel.Click += new System.EventHandler(this.lOANAMOUNTLabel_Click);
            // 
            // lOANNUMTextBox
            // 
            this.lOANNUMTextBox.Location = new System.Drawing.Point(169, 86);
            this.lOANNUMTextBox.Name = "lOANNUMTextBox";
            this.lOANNUMTextBox.Size = new System.Drawing.Size(131, 22);
            this.lOANNUMTextBox.TabIndex = 2;
            // 
            // lOANBRANCHNUMTextBox
            // 
            this.lOANBRANCHNUMTextBox.Location = new System.Drawing.Point(169, 135);
            this.lOANBRANCHNUMTextBox.Name = "lOANBRANCHNUMTextBox";
            this.lOANBRANCHNUMTextBox.Size = new System.Drawing.Size(131, 22);
            this.lOANBRANCHNUMTextBox.TabIndex = 4;
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.Location = new System.Drawing.Point(169, 185);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.Size = new System.Drawing.Size(131, 22);
            this.sSNTextBox.TabIndex = 6;
            // 
            // eMPIDTextBox
            // 
            this.eMPIDTextBox.Location = new System.Drawing.Point(169, 237);
            this.eMPIDTextBox.Name = "eMPIDTextBox";
            this.eMPIDTextBox.Size = new System.Drawing.Size(131, 22);
            this.eMPIDTextBox.TabIndex = 8;
            // 
            // lOANTYPETextBox
            // 
            this.lOANTYPETextBox.Location = new System.Drawing.Point(169, 295);
            this.lOANTYPETextBox.Name = "lOANTYPETextBox";
            this.lOANTYPETextBox.Size = new System.Drawing.Size(131, 22);
            this.lOANTYPETextBox.TabIndex = 10;
            this.lOANTYPETextBox.TextChanged += new System.EventHandler(this.lOANTYPETextBox_TextChanged);
            // 
            // lOANAMOUNTTextBox
            // 
            this.lOANAMOUNTTextBox.Location = new System.Drawing.Point(169, 350);
            this.lOANAMOUNTTextBox.Name = "lOANAMOUNTTextBox";
            this.lOANAMOUNTTextBox.Size = new System.Drawing.Size(131, 22);
            this.lOANAMOUNTTextBox.TabIndex = 12;
            // 
            // lOANDataGridView
            // 
            this.lOANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOANDataGridView.Location = new System.Drawing.Point(19, 25);
            this.lOANDataGridView.Name = "lOANDataGridView";
            this.lOANDataGridView.RowHeadersWidth = 51;
            this.lOANDataGridView.RowTemplate.Height = 24;
            this.lOANDataGridView.Size = new System.Drawing.Size(801, 168);
            this.lOANDataGridView.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(lOANAMOUNTLabel);
            this.groupBox1.Controls.Add(this.lOANAMOUNTTextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(lOANTYPELabel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lOANTYPETextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(eMPIDLabel);
            this.groupBox1.Controls.Add(this.eMPIDTextBox);
            this.groupBox1.Controls.Add(sSNLabel);
            this.groupBox1.Controls.Add(this.sSNTextBox);
            this.groupBox1.Controls.Add(lOANBRANCHNUMLabel);
            this.groupBox1.Controls.Add(this.lOANBRANCHNUMTextBox);
            this.groupBox1.Controls.Add(lOANNUMLabel);
            this.groupBox1.Controls.Add(this.lOANNUMTextBox);
            this.groupBox1.Location = new System.Drawing.Point(40, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 462);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 59;
            this.button5.Text = "Main";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 3);
            this.panel2.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 38);
            this.label1.TabIndex = 53;
            this.label1.Text = "Loan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 3);
            this.panel1.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lOANDataGridView);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(372, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 259);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOANDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox lOANNUMTextBox;
        private System.Windows.Forms.TextBox lOANBRANCHNUMTextBox;
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.TextBox eMPIDTextBox;
        private System.Windows.Forms.TextBox lOANTYPETextBox;
        private System.Windows.Forms.TextBox lOANAMOUNTTextBox;
        private System.Windows.Forms.DataGridView lOANDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}