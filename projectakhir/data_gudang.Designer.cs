﻿namespace projectakhir
{
    partial class data_gudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_gudang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxIdGudang = new System.Windows.Forms.TextBox();
            this.tbxAlamat = new System.Windows.Forms.TextBox();
            this.tbxKapasitas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataSupirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPenyewaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSupirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Gudang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kapasitas";
            // 
            // tbxIdGudang
            // 
            this.tbxIdGudang.Location = new System.Drawing.Point(87, 30);
            this.tbxIdGudang.Name = "tbxIdGudang";
            this.tbxIdGudang.Size = new System.Drawing.Size(177, 22);
            this.tbxIdGudang.TabIndex = 3;
            // 
            // tbxAlamat
            // 
            this.tbxAlamat.Location = new System.Drawing.Point(87, 77);
            this.tbxAlamat.Name = "tbxAlamat";
            this.tbxAlamat.Size = new System.Drawing.Size(177, 22);
            this.tbxAlamat.TabIndex = 4;
            // 
            // tbxKapasitas
            // 
            this.tbxKapasitas.Location = new System.Drawing.Point(87, 113);
            this.tbxKapasitas.Name = "tbxKapasitas";
            this.tbxKapasitas.Size = new System.Drawing.Size(177, 22);
            this.tbxKapasitas.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSupirToolStripMenuItem,
            this.dataMobilToolStripMenuItem,
            this.dataPenyewaToolStripMenuItem,
            this.dataSupirToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // dataSupirToolStripMenuItem
            // 
            this.dataSupirToolStripMenuItem.Name = "dataSupirToolStripMenuItem";
            this.dataSupirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataSupirToolStripMenuItem.Text = "data supir";
            this.dataSupirToolStripMenuItem.Click += new System.EventHandler(this.dataSupirToolStripMenuItem_Click);
            // 
            // dataMobilToolStripMenuItem
            // 
            this.dataMobilToolStripMenuItem.Name = "dataMobilToolStripMenuItem";
            this.dataMobilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataMobilToolStripMenuItem.Text = "data mobil";
            this.dataMobilToolStripMenuItem.Click += new System.EventHandler(this.dataMobilToolStripMenuItem_Click);
            // 
            // dataPenyewaToolStripMenuItem
            // 
            this.dataPenyewaToolStripMenuItem.Name = "dataPenyewaToolStripMenuItem";
            this.dataPenyewaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPenyewaToolStripMenuItem.Text = "data penyewa";
            this.dataPenyewaToolStripMenuItem.Click += new System.EventHandler(this.dataPenyewaToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Open";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 220);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataSupirToolStripMenuItem1
            // 
            this.dataSupirToolStripMenuItem1.Name = "dataSupirToolStripMenuItem1";
            this.dataSupirToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dataSupirToolStripMenuItem1.Text = "data admin";
            this.dataSupirToolStripMenuItem1.Click += new System.EventHandler(this.dataSupirToolStripMenuItem1_Click);
            // 
            // data_gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxKapasitas);
            this.Controls.Add(this.tbxAlamat);
            this.Controls.Add(this.tbxIdGudang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "data_gudang";
            this.Text = "data_gudang";
            this.Load += new System.EventHandler(this.data_gudang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxIdGudang;
        private System.Windows.Forms.TextBox tbxAlamat;
        private System.Windows.Forms.TextBox tbxKapasitas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataSupirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPenyewaToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem dataSupirToolStripMenuItem1;
    }
}