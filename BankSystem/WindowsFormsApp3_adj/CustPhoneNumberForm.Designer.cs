
namespace WindowsFormsApp3
{
    partial class CustPhoneNumberForm
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
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label pHONENUMBERLabel;
            System.Windows.Forms.Label cUST_SSNLabel;
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.pHONENUMBERTextBox = new System.Windows.Forms.TextBox();
            this.cUST_SSNTextBox = new System.Windows.Forms.TextBox();
            this.cUSTOMER_PHONENUMDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            sSNLabel = new System.Windows.Forms.Label();
            pHONENUMBERLabel = new System.Windows.Forms.Label();
            cUST_SSNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_PHONENUMDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            sSNLabel.Location = new System.Drawing.Point(71, 100);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(38, 16);
            sSNLabel.TabIndex = 1;
            sSNLabel.Text = "SSN:";
            // 
            // pHONENUMBERLabel
            // 
            pHONENUMBERLabel.AutoSize = true;
            pHONENUMBERLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            pHONENUMBERLabel.Location = new System.Drawing.Point(71, 151);
            pHONENUMBERLabel.Name = "pHONENUMBERLabel";
            pHONENUMBERLabel.Size = new System.Drawing.Size(117, 16);
            pHONENUMBERLabel.TabIndex = 3;
            pHONENUMBERLabel.Text = "PHONENUMBER:";
            // 
            // cUST_SSNLabel
            // 
            cUST_SSNLabel.AutoSize = true;
            cUST_SSNLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cUST_SSNLabel.Location = new System.Drawing.Point(71, 200);
            cUST_SSNLabel.Name = "cUST_SSNLabel";
            cUST_SSNLabel.Size = new System.Drawing.Size(78, 16);
            cUST_SSNLabel.TabIndex = 5;
            cUST_SSNLabel.Text = "CUST SSN:";
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.Location = new System.Drawing.Point(212, 95);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.Size = new System.Drawing.Size(129, 22);
            this.sSNTextBox.TabIndex = 2;
            // 
            // pHONENUMBERTextBox
            // 
            this.pHONENUMBERTextBox.Location = new System.Drawing.Point(212, 146);
            this.pHONENUMBERTextBox.Name = "pHONENUMBERTextBox";
            this.pHONENUMBERTextBox.Size = new System.Drawing.Size(129, 22);
            this.pHONENUMBERTextBox.TabIndex = 4;
            // 
            // cUST_SSNTextBox
            // 
            this.cUST_SSNTextBox.Location = new System.Drawing.Point(212, 195);
            this.cUST_SSNTextBox.Name = "cUST_SSNTextBox";
            this.cUST_SSNTextBox.Size = new System.Drawing.Size(129, 22);
            this.cUST_SSNTextBox.TabIndex = 6;
            // 
            // cUSTOMER_PHONENUMDataGridView
            // 
            this.cUSTOMER_PHONENUMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMER_PHONENUMDataGridView.Location = new System.Drawing.Point(17, 26);
            this.cUSTOMER_PHONENUMDataGridView.Name = "cUSTOMER_PHONENUMDataGridView";
            this.cUSTOMER_PHONENUMDataGridView.RowHeadersWidth = 51;
            this.cUSTOMER_PHONENUMDataGridView.RowTemplate.Height = 24;
            this.cUSTOMER_PHONENUMDataGridView.Size = new System.Drawing.Size(273, 94);
            this.cUSTOMER_PHONENUMDataGridView.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(pHONENUMBERLabel);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.sSNTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(sSNLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pHONENUMBERTextBox);
            this.groupBox1.Controls.Add(this.cUST_SSNTextBox);
            this.groupBox1.Controls.Add(cUST_SSNLabel);
            this.groupBox1.Location = new System.Drawing.Point(296, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 331);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 298);
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
            this.panel2.Location = new System.Drawing.Point(43, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 3);
            this.panel2.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 38);
            this.label1.TabIndex = 51;
            this.label1.Text = "Customer Phone Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(43, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 3);
            this.panel1.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cUSTOMER_PHONENUMDataGridView);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(774, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 201);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // CustPhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustPhoneNumberForm";
            this.Text = "CustPhoneNumberForm";
            this.Load += new System.EventHandler(this.CustPhoneNumberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMER_PHONENUMDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.TextBox pHONENUMBERTextBox;
        private System.Windows.Forms.TextBox cUST_SSNTextBox;
        private System.Windows.Forms.DataGridView cUSTOMER_PHONENUMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}