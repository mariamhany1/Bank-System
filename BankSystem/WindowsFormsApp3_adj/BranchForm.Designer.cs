
namespace WindowsFormsApp3
{
    partial class BranchForm
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
            System.Windows.Forms.Label bRANCHNUMLabel;
            System.Windows.Forms.Label cODELabel;
            System.Windows.Forms.Label bRANCHSTREETLabel;
            System.Windows.Forms.Label bRANCHZIPCODELabel;
            System.Windows.Forms.Label bRANCHCOUNTRYLabel;
            this.bRANCHNUMTextBox = new System.Windows.Forms.TextBox();
            this.cODETextBox = new System.Windows.Forms.TextBox();
            this.bRANCHSTREETTextBox = new System.Windows.Forms.TextBox();
            this.bRANCHZIPCODETextBox = new System.Windows.Forms.TextBox();
            this.cUSTOMERDataGridView = new System.Windows.Forms.DataGridView();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOANDataGridView = new System.Windows.Forms.DataGridView();
            this.lOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bRANCHDataGridView = new System.Windows.Forms.DataGridView();
            this.bRANCHCOUNTRYTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            bRANCHNUMLabel = new System.Windows.Forms.Label();
            cODELabel = new System.Windows.Forms.Label();
            bRANCHSTREETLabel = new System.Windows.Forms.Label();
            bRANCHZIPCODELabel = new System.Windows.Forms.Label();
            bRANCHCOUNTRYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bRANCHNUMLabel
            // 
            bRANCHNUMLabel.AutoSize = true;
            bRANCHNUMLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bRANCHNUMLabel.Location = new System.Drawing.Point(29, 90);
            bRANCHNUMLabel.Name = "bRANCHNUMLabel";
            bRANCHNUMLabel.Size = new System.Drawing.Size(98, 16);
            bRANCHNUMLabel.TabIndex = 1;
            bRANCHNUMLabel.Text = "BRANCHNUM:";
            // 
            // cODELabel
            // 
            cODELabel.AutoSize = true;
            cODELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cODELabel.Location = new System.Drawing.Point(29, 132);
            cODELabel.Name = "cODELabel";
            cODELabel.Size = new System.Drawing.Size(48, 16);
            cODELabel.TabIndex = 3;
            cODELabel.Text = "CODE:";
            // 
            // bRANCHSTREETLabel
            // 
            bRANCHSTREETLabel.AutoSize = true;
            bRANCHSTREETLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bRANCHSTREETLabel.Location = new System.Drawing.Point(29, 234);
            bRANCHSTREETLabel.Name = "bRANCHSTREETLabel";
            bRANCHSTREETLabel.Size = new System.Drawing.Size(122, 16);
            bRANCHSTREETLabel.TabIndex = 5;
            bRANCHSTREETLabel.Text = "BRANCHSTREET:";
            // 
            // bRANCHZIPCODELabel
            // 
            bRANCHZIPCODELabel.AutoSize = true;
            bRANCHZIPCODELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bRANCHZIPCODELabel.Location = new System.Drawing.Point(29, 283);
            bRANCHZIPCODELabel.Name = "bRANCHZIPCODELabel";
            bRANCHZIPCODELabel.Size = new System.Drawing.Size(125, 16);
            bRANCHZIPCODELabel.TabIndex = 7;
            bRANCHZIPCODELabel.Text = "BRANCHZIPCODE:";
            // 
            // bRANCHCOUNTRYLabel
            // 
            bRANCHCOUNTRYLabel.AutoSize = true;
            bRANCHCOUNTRYLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bRANCHCOUNTRYLabel.Location = new System.Drawing.Point(29, 185);
            bRANCHCOUNTRYLabel.Name = "bRANCHCOUNTRYLabel";
            bRANCHCOUNTRYLabel.Size = new System.Drawing.Size(134, 16);
            bRANCHCOUNTRYLabel.TabIndex = 35;
            bRANCHCOUNTRYLabel.Text = "BRANCHCOUNTRY:";
            // 
            // bRANCHNUMTextBox
            // 
            this.bRANCHNUMTextBox.Location = new System.Drawing.Point(172, 85);
            this.bRANCHNUMTextBox.Name = "bRANCHNUMTextBox";
            this.bRANCHNUMTextBox.Size = new System.Drawing.Size(126, 22);
            this.bRANCHNUMTextBox.TabIndex = 2;
            // 
            // cODETextBox
            // 
            this.cODETextBox.Location = new System.Drawing.Point(172, 127);
            this.cODETextBox.Name = "cODETextBox";
            this.cODETextBox.Size = new System.Drawing.Size(126, 22);
            this.cODETextBox.TabIndex = 4;
            // 
            // bRANCHSTREETTextBox
            // 
            this.bRANCHSTREETTextBox.Location = new System.Drawing.Point(172, 229);
            this.bRANCHSTREETTextBox.Name = "bRANCHSTREETTextBox";
            this.bRANCHSTREETTextBox.Size = new System.Drawing.Size(126, 22);
            this.bRANCHSTREETTextBox.TabIndex = 6;
            // 
            // bRANCHZIPCODETextBox
            // 
            this.bRANCHZIPCODETextBox.Location = new System.Drawing.Point(172, 280);
            this.bRANCHZIPCODETextBox.Name = "bRANCHZIPCODETextBox";
            this.bRANCHZIPCODETextBox.Size = new System.Drawing.Size(126, 22);
            this.bRANCHZIPCODETextBox.TabIndex = 8;
            this.bRANCHZIPCODETextBox.TextChanged += new System.EventHandler(this.bRANCHZIPCODETextBox_TextChanged);
            // 
            // cUSTOMERDataGridView
            // 
            this.cUSTOMERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERDataGridView.Location = new System.Drawing.Point(56, 25);
            this.cUSTOMERDataGridView.Name = "cUSTOMERDataGridView";
            this.cUSTOMERDataGridView.RowHeadersWidth = 51;
            this.cUSTOMERDataGridView.RowTemplate.Height = 24;
            this.cUSTOMERDataGridView.Size = new System.Drawing.Size(243, 79);
            this.cUSTOMERDataGridView.TabIndex = 9;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "FK_CUSTOMER_2_BRANCH";
            // 
            // eMPLOYEEDataGridView
            // 
            this.eMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEEDataGridView.Location = new System.Drawing.Point(56, 308);
            this.eMPLOYEEDataGridView.Name = "eMPLOYEEDataGridView";
            this.eMPLOYEEDataGridView.RowHeadersWidth = 51;
            this.eMPLOYEEDataGridView.RowTemplate.Height = 24;
            this.eMPLOYEEDataGridView.Size = new System.Drawing.Size(243, 77);
            this.eMPLOYEEDataGridView.TabIndex = 10;
            // 
            // lOANDataGridView
            // 
            this.lOANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOANDataGridView.Location = new System.Drawing.Point(56, 222);
            this.lOANDataGridView.Name = "lOANDataGridView";
            this.lOANDataGridView.RowHeadersWidth = 51;
            this.lOANDataGridView.RowTemplate.Height = 24;
            this.lOANDataGridView.Size = new System.Drawing.Size(243, 80);
            this.lOANDataGridView.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bRANCHDataGridView
            // 
            this.bRANCHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bRANCHDataGridView.Location = new System.Drawing.Point(56, 115);
            this.bRANCHDataGridView.Name = "bRANCHDataGridView";
            this.bRANCHDataGridView.RowHeadersWidth = 51;
            this.bRANCHDataGridView.RowTemplate.Height = 24;
            this.bRANCHDataGridView.Size = new System.Drawing.Size(243, 100);
            this.bRANCHDataGridView.TabIndex = 35;
            // 
            // bRANCHCOUNTRYTextBox
            // 
            this.bRANCHCOUNTRYTextBox.Location = new System.Drawing.Point(172, 180);
            this.bRANCHCOUNTRYTextBox.Name = "bRANCHCOUNTRYTextBox";
            this.bRANCHCOUNTRYTextBox.Size = new System.Drawing.Size(126, 22);
            this.bRANCHCOUNTRYTextBox.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRANCHDataGridView);
            this.groupBox1.Controls.Add(this.cUSTOMERDataGridView);
            this.groupBox1.Controls.Add(this.eMPLOYEEDataGridView);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.lOANDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(731, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 437);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.cODETextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bRANCHNUMTextBox);
            this.groupBox2.Controls.Add(bRANCHCOUNTRYLabel);
            this.groupBox2.Controls.Add(bRANCHNUMLabel);
            this.groupBox2.Controls.Add(this.bRANCHCOUNTRYTextBox);
            this.groupBox2.Controls.Add(cODELabel);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.bRANCHSTREETTextBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(bRANCHSTREETLabel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bRANCHZIPCODETextBox);
            this.groupBox2.Controls.Add(bRANCHZIPCODELabel);
            this.groupBox2.Location = new System.Drawing.Point(323, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 412);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 58;
            this.button5.Text = "Main";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 53;
            this.label1.Text = "Branch";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(323, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 3);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(323, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 3);
            this.panel2.TabIndex = 41;
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BranchForm";
            this.Text = "BranchForm";
            this.Load += new System.EventHandler(this.BranchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bRANCHBindingSource;
        private System.Windows.Forms.TextBox bRANCHNUMTextBox;
        private System.Windows.Forms.TextBox cODETextBox;
        private System.Windows.Forms.TextBox bRANCHSTREETTextBox;
        private System.Windows.Forms.TextBox bRANCHZIPCODETextBox;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private System.Windows.Forms.DataGridView cUSTOMERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private System.Windows.Forms.DataGridView eMPLOYEEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource lOANBindingSource;
        private System.Windows.Forms.DataGridView lOANDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView bRANCHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.TextBox bRANCHCOUNTRYTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}