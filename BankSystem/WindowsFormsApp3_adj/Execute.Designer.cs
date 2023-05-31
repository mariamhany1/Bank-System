
namespace WindowsFormsApp3
{
    partial class Exceute_SQLQueryFromTextbox
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
            this.txtquery = new System.Windows.Forms.TextBox();
            this.btnquery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtquery
            // 
            this.txtquery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquery.Location = new System.Drawing.Point(2, 3);
            this.txtquery.Multiline = true;
            this.txtquery.Name = "txtquery";
            this.txtquery.Size = new System.Drawing.Size(882, 185);
            this.txtquery.TabIndex = 0;
            this.txtquery.TextChanged += new System.EventHandler(this.txtquery_TextChanged);
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(890, 3);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(216, 185);
            this.btnquery.TabIndex = 1;
            this.btnquery.Text = "Execute SQL Query";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 362);
            this.dataGridView1.TabIndex = 2;
            // 
            // Exceute_SQLQueryFromTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.txtquery);
            this.Name = "Exceute_SQLQueryFromTextbox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Exceute_SQLQueryFromTextbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtquery;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}