﻿namespace projectakhir
{
    partial class data_mobil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_mobil));
            this.tbxplatnomor = new System.Windows.Forms.TextBox();
            this.tbxjenis = new System.Windows.Forms.TextBox();
            this.tbxwarna = new System.Windows.Forms.TextBox();
            this.tbxidAdmin = new System.Windows.Forms.TextBox();
            this.tbxidGudang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataGudangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSupriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPenyewaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxplatnomor
            // 
            this.tbxplatnomor.Location = new System.Drawing.Point(211, 75);
            this.tbxplatnomor.Name = "tbxplatnomor";
            this.tbxplatnomor.Size = new System.Drawing.Size(100, 22);
            this.tbxplatnomor.TabIndex = 0;
            // 
            // tbxjenis
            // 
            this.tbxjenis.Location = new System.Drawing.Point(211, 124);
            this.tbxjenis.Name = "tbxjenis";
            this.tbxjenis.Size = new System.Drawing.Size(100, 22);
            this.tbxjenis.TabIndex = 1;
            // 
            // tbxwarna
            // 
            this.tbxwarna.Location = new System.Drawing.Point(211, 179);
            this.tbxwarna.Name = "tbxwarna";
            this.tbxwarna.Size = new System.Drawing.Size(100, 22);
            this.tbxwarna.TabIndex = 2;
            // 
            // tbxidAdmin
            // 
            this.tbxidAdmin.Location = new System.Drawing.Point(211, 234);
            this.tbxidAdmin.Name = "tbxidAdmin";
            this.tbxidAdmin.Size = new System.Drawing.Size(100, 22);
            this.tbxidAdmin.TabIndex = 3;
            // 
            // tbxidGudang
            // 
            this.tbxidGudang.Location = new System.Drawing.Point(211, 298);
            this.tbxidGudang.Name = "tbxidGudang";
            this.tbxidGudang.Size = new System.Drawing.Size(100, 22);
            this.tbxidGudang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "plat_nomor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "warna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "id_admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "id_gudang";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "delete";
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
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataGudangToolStripMenuItem,
            this.dataSupriToolStripMenuItem,
            this.dataPenyewaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // dataGudangToolStripMenuItem
            // 
            this.dataGudangToolStripMenuItem.Name = "dataGudangToolStripMenuItem";
            this.dataGudangToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.dataGudangToolStripMenuItem.Text = "data gudang";
            this.dataGudangToolStripMenuItem.Click += new System.EventHandler(this.dataGudangToolStripMenuItem_Click);
            // 
            // dataSupriToolStripMenuItem
            // 
            this.dataSupriToolStripMenuItem.Name = "dataSupriToolStripMenuItem";
            this.dataSupriToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.dataSupriToolStripMenuItem.Text = "data supir";
            this.dataSupriToolStripMenuItem.Click += new System.EventHandler(this.dataSupriToolStripMenuItem_Click);
            // 
            // dataPenyewaToolStripMenuItem
            // 
            this.dataPenyewaToolStripMenuItem.Name = "dataPenyewaToolStripMenuItem";
            this.dataPenyewaToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.dataPenyewaToolStripMenuItem.Text = "data penyewa";
            this.dataPenyewaToolStripMenuItem.Click += new System.EventHandler(this.dataPenyewaToolStripMenuItem_Click);
            // 
            // data_mobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxidGudang);
            this.Controls.Add(this.tbxidAdmin);
            this.Controls.Add(this.tbxwarna);
            this.Controls.Add(this.tbxjenis);
            this.Controls.Add(this.tbxplatnomor);
            this.Name = "data_mobil";
            this.Text = "data_mobil";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxplatnomor;
        private System.Windows.Forms.TextBox tbxjenis;
        private System.Windows.Forms.TextBox tbxwarna;
        private System.Windows.Forms.TextBox tbxidAdmin;
        private System.Windows.Forms.TextBox tbxidGudang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataGudangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSupriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPenyewaToolStripMenuItem;
    }
}