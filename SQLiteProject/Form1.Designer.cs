namespace SQLiteProject
{
    partial class SQLiteSampleProjects
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropTable_btn = new System.Windows.Forms.Button();
            this.createTable_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.jn7_lbl = new System.Windows.Forms.LinkLabel();
            this.dg_fill_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dropTable_btn);
            this.groupBox1.Controls.Add(this.createTable_btn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TABLE";
            // 
            // dropTable_btn
            // 
            this.dropTable_btn.Location = new System.Drawing.Point(17, 72);
            this.dropTable_btn.Name = "dropTable_btn";
            this.dropTable_btn.Size = new System.Drawing.Size(153, 42);
            this.dropTable_btn.TabIndex = 1;
            this.dropTable_btn.Text = "Drop Table";
            this.dropTable_btn.UseVisualStyleBackColor = true;
            this.dropTable_btn.Click += new System.EventHandler(this.dropTable_btn_Click);
            // 
            // createTable_btn
            // 
            this.createTable_btn.Location = new System.Drawing.Point(17, 24);
            this.createTable_btn.Name = "createTable_btn";
            this.createTable_btn.Size = new System.Drawing.Size(153, 42);
            this.createTable_btn.TabIndex = 0;
            this.createTable_btn.Text = "Create Table";
            this.createTable_btn.UseVisualStyleBackColor = true;
            this.createTable_btn.Click += new System.EventHandler(this.createTable_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.dg_fill_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(876, 154);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dGrid
            // 
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGrid.Location = new System.Drawing.Point(0, 154);
            this.dGrid.Name = "dGrid";
            this.dGrid.Size = new System.Drawing.Size(876, 385);
            this.dGrid.TabIndex = 0;
            // 
            // jn7_lbl
            // 
            this.jn7_lbl.AutoSize = true;
            this.jn7_lbl.Location = new System.Drawing.Point(0, 542);
            this.jn7_lbl.Name = "jn7_lbl";
            this.jn7_lbl.Size = new System.Drawing.Size(212, 13);
            this.jn7_lbl.TabIndex = 5;
            this.jn7_lbl.TabStop = true;
            this.jn7_lbl.Text = "http://www.jn7.net - SQLite Sample Project";
            this.jn7_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jn7_lbl_LinkClicked);
            // 
            // dg_fill_btn
            // 
            this.dg_fill_btn.Location = new System.Drawing.Point(199, 3);
            this.dg_fill_btn.Name = "dg_fill_btn";
            this.dg_fill_btn.Size = new System.Drawing.Size(120, 39);
            this.dg_fill_btn.TabIndex = 1;
            this.dg_fill_btn.Text = "Listele";
            this.dg_fill_btn.UseVisualStyleBackColor = true;
            this.dg_fill_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SQLiteSampleProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 561);
            this.Controls.Add(this.jn7_lbl);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SQLiteSampleProjects";
            this.Text = "SQLite Project -www.jn7.net";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createTable_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button dropTable_btn;
        private System.Windows.Forms.LinkLabel jn7_lbl;
        private System.Windows.Forms.Button dg_fill_btn;
    }
}

