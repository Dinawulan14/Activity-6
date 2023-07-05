using System;
using System.Windows.Forms;

namespace Activity_6
{
    partial class FormDataMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataMaster));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataProdiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStatusmahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel1.Text = "Data Master";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataProdiiToolStripMenuItem,
            this.dataMahasiswaaToolStripMenuItem,
            this.dataStatusmahasiswaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(14, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // dataProdiiToolStripMenuItem
            // 
            this.dataProdiiToolStripMenuItem.Name = "dataProdiiToolStripMenuItem";
            this.dataProdiiToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.dataProdiiToolStripMenuItem.Text = "dataProdii";
            this.dataProdiiToolStripMenuItem.Click += new System.EventHandler(this.dataProdiiToolStripMenuItem_Click_1);
            // 
            // dataMahasiswaaToolStripMenuItem
            // 
            this.dataMahasiswaaToolStripMenuItem.Name = "dataMahasiswaaToolStripMenuItem";
            this.dataMahasiswaaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.dataMahasiswaaToolStripMenuItem.Text = "dataMahasiswaa";
            this.dataMahasiswaaToolStripMenuItem.Click += new System.EventHandler(this.dataMahasiswaaToolStripMenuItem_Click_1);
            // 
            // dataStatusmahasiswaToolStripMenuItem
            // 
            this.dataStatusmahasiswaToolStripMenuItem.Name = "dataStatusmahasiswaToolStripMenuItem";
            this.dataStatusmahasiswaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.dataStatusmahasiswaToolStripMenuItem.Text = "dataStatusmahasiswa";
            this.dataStatusmahasiswaToolStripMenuItem.Click += new System.EventHandler(this.dataStatusmahasiswaToolStripMenuItem_Click_1);
            // 
            // FormDataMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormDataMaster";
            this.Text = "Data Master";
            this.Load += new System.EventHandler(this.FormDataMaster_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormDataMaster_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataProdiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataStatusmahasiswaToolStripMenuItem;
        private EventHandler Form1_Load;
        private readonly ToolStripItemClickedEventHandler toolStrip1_ItemClicked;
        private readonly EventHandler dataProdiiToolStripMenuItem_Click;
        private readonly EventHandler dataMahasiswaaToolStripMenuItem_Click;
        private readonly EventHandler toolStripDropDownButton1_Click;
        private ToolStripLabel toolStripLabel1;
        private ToolStripItemClickedEventHandler toolStrip1_ItemClicked_1;
    }
}

