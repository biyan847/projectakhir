namespace projectakhir
{
    partial class data_penyewa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataMobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGudangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSupirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMobilToolStripMenuItem,
            this.dataGudangToolStripMenuItem,
            this.dataSupirToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // dataMobilToolStripMenuItem
            // 
            this.dataMobilToolStripMenuItem.Name = "dataMobilToolStripMenuItem";
            this.dataMobilToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.dataMobilToolStripMenuItem.Text = "data mobil";
            this.dataMobilToolStripMenuItem.Click += new System.EventHandler(this.dataMobilToolStripMenuItem_Click);
            // 
            // dataGudangToolStripMenuItem
            // 
            this.dataGudangToolStripMenuItem.Name = "dataGudangToolStripMenuItem";
            this.dataGudangToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.dataGudangToolStripMenuItem.Text = "data gudang";
            this.dataGudangToolStripMenuItem.Click += new System.EventHandler(this.dataGudangToolStripMenuItem_Click);
            // 
            // dataSupirToolStripMenuItem
            // 
            this.dataSupirToolStripMenuItem.Name = "dataSupirToolStripMenuItem";
            this.dataSupirToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.dataSupirToolStripMenuItem.Text = "data supir";
            this.dataSupirToolStripMenuItem.Click += new System.EventHandler(this.dataSupirToolStripMenuItem_Click);
            // 
            // data_penyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "data_penyewa";
            this.Text = "data_penyewa";
            this.Load += new System.EventHandler(this.data_penyewa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataMobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGudangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSupirToolStripMenuItem;
    }
}