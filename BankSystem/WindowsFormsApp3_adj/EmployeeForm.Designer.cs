
namespace WindowsFormsApp3
{
    partial class EmployeeForm
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
            System.Windows.Forms.Label bRANCHNUMLabel;
            System.Windows.Forms.Label eMPFNAMELabel;
            System.Windows.Forms.Label eMPNAMELabel;
            this.eMPIDTextBox = new System.Windows.Forms.TextBox();
            this.bRANCHNUMTextBox = new System.Windows.Forms.TextBox();
            this.eMPFNAMETextBox = new System.Windows.Forms.TextBox();
            this.eMPNAMETextBox = new System.Windows.Forms.TextBox();
            this.cUST_EMPDataGridView = new System.Windows.Forms.DataGridView();
            this.lOANDataGridView = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
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
            eMPIDLabel = new System.Windows.Forms.Label();
            bRANCHNUMLabel = new System.Windows.Forms.Label();
            eMPFNAMELabel = new System.Windows.Forms.Label();
            eMPNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cUST_EMPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eMPIDLabel
            // 
            eMPIDLabel.AutoSize = true;
            eMPIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eMPIDLabel.Location = new System.Drawing.Point(49, 78);
            eMPIDLabel.Name = "eMPIDLabel";
            eMPIDLabel.Size = new System.Drawing.Size(52, 16);
            eMPIDLabel.TabIndex = 1;
            eMPIDLabel.Text = "EMPID:";
            // 
            // bRANCHNUMLabel
            // 
            bRANCHNUMLabel.AutoSize = true;
            bRANCHNUMLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bRANCHNUMLabel.Location = new System.Drawing.Point(49, 130);
            bRANCHNUMLabel.Name = "bRANCHNUMLabel";
            bRANCHNUMLabel.Size = new System.Drawing.Size(98, 16);
            bRANCHNUMLabel.TabIndex = 3;
            bRANCHNUMLabel.Text = "BRANCHNUM:";
            // 
            // eMPFNAMELabel
            // 
            eMPFNAMELabel.AutoSize = true;
            eMPFNAMELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eMPFNAMELabel.Location = new System.Drawing.Point(49, 185);
            eMPFNAMELabel.Name = "eMPFNAMELabel";
            eMPFNAMELabel.Size = new System.Drawing.Size(86, 16);
            eMPFNAMELabel.TabIndex = 5;
            eMPFNAMELabel.Text = "EMPFNAME:";
            // 
            // eMPNAMELabel
            // 
            eMPNAMELabel.AutoSize = true;
            eMPNAMELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eMPNAMELabel.Location = new System.Drawing.Point(49, 239);
            eMPNAMELabel.Name = "eMPNAMELabel";
            eMPNAMELabel.Size = new System.Drawing.Size(78, 16);
            eMPNAMELabel.TabIndex = 7;
            eMPNAMELabel.Text = "EMPNAME:";
            // 
            // eMPIDTextBox
            // 
            this.eMPIDTextBox.Location = new System.Drawing.Point(172, 73);
            this.eMPIDTextBox.Name = "eMPIDTextBox";
            this.eMPIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.eMPIDTextBox.TabIndex = 2;
            // 
            // bRANCHNUMTextBox
            // 
            this.bRANCHNUMTextBox.Location = new System.Drawing.Point(172, 125);
            this.bRANCHNUMTextBox.Name = "bRANCHNUMTextBox";
            this.bRANCHNUMTextBox.Size = new System.Drawing.Size(100, 22);
            this.bRANCHNUMTextBox.TabIndex = 4;
            // 
            // eMPFNAMETextBox
            // 
            this.eMPFNAMETextBox.Location = new System.Drawing.Point(172, 180);
            this.eMPFNAMETextBox.Name = "eMPFNAMETextBox";
            this.eMPFNAMETextBox.Size = new System.Drawing.Size(100, 22);
            this.eMPFNAMETextBox.TabIndex = 6;
            // 
            // eMPNAMETextBox
            // 
            this.eMPNAMETextBox.Location = new System.Drawing.Point(172, 234);
            this.eMPNAMETextBox.Name = "eMPNAMETextBox";
            this.eMPNAMETextBox.Size = new System.Drawing.Size(100, 22);
            this.eMPNAMETextBox.TabIndex = 8;
            // 
            // cUST_EMPDataGridView
            // 
            this.cUST_EMPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUST_EMPDataGridView.Location = new System.Drawing.Point(51, 31);
            this.cUST_EMPDataGridView.Name = "cUST_EMPDataGridView";
            this.cUST_EMPDataGridView.RowHeadersWidth = 51;
            this.cUST_EMPDataGridView.RowTemplate.Height = 24;
            this.cUST_EMPDataGridView.Size = new System.Drawing.Size(299, 77);
            this.cUST_EMPDataGridView.TabIndex = 9;
            // 
            // lOANDataGridView
            // 
            this.lOANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOANDataGridView.Location = new System.Drawing.Point(51, 133);
            this.lOANDataGridView.Name = "lOANDataGridView";
            this.lOANDataGridView.RowHeadersWidth = 51;
            this.lOANDataGridView.RowTemplate.Height = 24;
            this.lOANDataGridView.Size = new System.Drawing.Size(299, 79);
            this.lOANDataGridView.TabIndex = 10;
            // 
            // eMPLOYEEDataGridView
            // 
            this.eMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEEDataGridView.Location = new System.Drawing.Point(51, 231);
            this.eMPLOYEEDataGridView.Name = "eMPLOYEEDataGridView";
            this.eMPLOYEEDataGridView.RowHeadersWidth = 51;
            this.eMPLOYEEDataGridView.RowTemplate.Height = 24;
            this.eMPLOYEEDataGridView.Size = new System.Drawing.Size(299, 108);
            this.eMPLOYEEDataGridView.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
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
            this.groupBox1.Controls.Add(bRANCHNUMLabel);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.eMPIDTextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(eMPIDLabel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bRANCHNUMTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.eMPFNAMETextBox);
            this.groupBox1.Controls.Add(eMPFNAMELabel);
            this.groupBox1.Controls.Add(this.eMPNAMETextBox);
            this.groupBox1.Controls.Add(eMPNAMELabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(346, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 372);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 332);
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
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 3);
            this.panel2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 3);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cUST_EMPDataGridView);
            this.groupBox2.Controls.Add(this.lOANDataGridView);
            this.groupBox2.Controls.Add(this.eMPLOYEEDataGridView);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(751, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 395);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUST_EMPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox eMPIDTextBox;
        private System.Windows.Forms.TextBox bRANCHNUMTextBox;
        private System.Windows.Forms.TextBox eMPFNAMETextBox;
        private System.Windows.Forms.TextBox eMPNAMETextBox;
        private System.Windows.Forms.DataGridView cUST_EMPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView lOANDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView eMPLOYEEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
    }
}