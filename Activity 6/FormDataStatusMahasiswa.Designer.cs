﻿using System;

namespace Activity_6
{
    partial class FormDataStatusMahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusmahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunmasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusmahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kULIAHDataSet2 = new Activity_6.KULIAHDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.statusmahasiswaTableAdapter = new Activity_6.KULIAHDataSetTableAdapters.statusmahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kULIAHDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstatusDataGridViewTextBoxColumn,
            this.nimDataGridViewTextBoxColumn,
            this.statusmahasiswaDataGridViewTextBoxColumn,
            this.tahunmasukDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statusmahasiswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(135, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // idstatusDataGridViewTextBoxColumn
            // 
            this.idstatusDataGridViewTextBoxColumn.DataPropertyName = "id_status";
            this.idstatusDataGridViewTextBoxColumn.HeaderText = "id_status";
            this.idstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstatusDataGridViewTextBoxColumn.Name = "idstatusDataGridViewTextBoxColumn";
            this.idstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "nim";
            this.nimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            this.nimDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusmahasiswaDataGridViewTextBoxColumn
            // 
            this.statusmahasiswaDataGridViewTextBoxColumn.DataPropertyName = "status_mahasiswa";
            this.statusmahasiswaDataGridViewTextBoxColumn.HeaderText = "status_mahasiswa";
            this.statusmahasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusmahasiswaDataGridViewTextBoxColumn.Name = "statusmahasiswaDataGridViewTextBoxColumn";
            this.statusmahasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tahunmasukDataGridViewTextBoxColumn
            // 
            this.tahunmasukDataGridViewTextBoxColumn.DataPropertyName = "tahun_masuk";
            this.tahunmasukDataGridViewTextBoxColumn.HeaderText = "tahun_masuk";
            this.tahunmasukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahunmasukDataGridViewTextBoxColumn.Name = "tahunmasukDataGridViewTextBoxColumn";
            this.tahunmasukDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusmahasiswaBindingSource
            // 
            this.statusmahasiswaBindingSource.DataMember = "statusmahasiswa";
            this.statusmahasiswaBindingSource.DataSource = this.kULIAHDataSet2;
            // 
            // kULIAHDataSet2
            // 
            this.kULIAHDataSet2.DataSetName = "KULIAHDataSet2";
            this.kULIAHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomer Induk Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tahun Masuk";
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(357, 232);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(121, 24);
            this.cbxNama.TabIndex = 5;
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(357, 310);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(121, 24);
            this.cbxStatusMahasiswa.TabIndex = 6;
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(357, 341);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(121, 24);
            this.cbxTahunMasuk.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(484, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(484, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(484, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(696, 51);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(357, 267);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(121, 22);
            this.txtNIM.TabIndex = 12;
            // 
            // statusmahasiswaTableAdapter
            // 
            this.statusmahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // FormDataStatusMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataStatusMahasiswa";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormDataStatusMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kULIAHDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormDataStatusMahasiswa_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtNIM;
        private KULIAHDataSet kULIAHDataSet2;
        private System.Windows.Forms.BindingSource statusmahasiswaBindingSource;
        private KULIAHDataSetTableAdapters.statusmahasiswaTableAdapter statusmahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusmahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunmasukDataGridViewTextBoxColumn;
    }
}