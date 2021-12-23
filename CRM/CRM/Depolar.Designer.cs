
namespace CRM
{
    partial class Depolar
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
            this.dbCRMDataSet8 = new CRM.dbCRMDataSet8();
            this.tBLDEPOLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDEPOLARTableAdapter = new CRM.dbCRMDataSet8TableAdapters.TBLDEPOLARTableAdapter();
            this.depoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepoAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPOLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depoIDDataGridViewTextBoxColumn,
            this.depoAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLDEPOLARBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(315, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbCRMDataSet8
            // 
            this.dbCRMDataSet8.DataSetName = "dbCRMDataSet8";
            this.dbCRMDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDEPOLARBindingSource
            // 
            this.tBLDEPOLARBindingSource.DataMember = "TBLDEPOLAR";
            this.tBLDEPOLARBindingSource.DataSource = this.dbCRMDataSet8;
            // 
            // tBLDEPOLARTableAdapter
            // 
            this.tBLDEPOLARTableAdapter.ClearBeforeFill = true;
            // 
            // depoIDDataGridViewTextBoxColumn
            // 
            this.depoIDDataGridViewTextBoxColumn.DataPropertyName = "DepoID";
            this.depoIDDataGridViewTextBoxColumn.HeaderText = "DepoID";
            this.depoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depoIDDataGridViewTextBoxColumn.Name = "depoIDDataGridViewTextBoxColumn";
            this.depoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.depoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // depoAdDataGridViewTextBoxColumn
            // 
            this.depoAdDataGridViewTextBoxColumn.DataPropertyName = "DepoAd";
            this.depoAdDataGridViewTextBoxColumn.HeaderText = "DepoAd";
            this.depoAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depoAdDataGridViewTextBoxColumn.Name = "depoAdDataGridViewTextBoxColumn";
            this.depoAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depo Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDepoAd
            // 
            this.txtDepoAd.Location = new System.Drawing.Point(582, 49);
            this.txtDepoAd.Name = "txtDepoAd";
            this.txtDepoAd.Size = new System.Drawing.Size(126, 22);
            this.txtDepoAd.TabIndex = 4;
            // 
            // Depolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDepoAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Depolar";
            this.Text = "Depolar";
            this.Load += new System.EventHandler(this.Depolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPOLARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbCRMDataSet8 dbCRMDataSet8;
        private System.Windows.Forms.BindingSource tBLDEPOLARBindingSource;
        private dbCRMDataSet8TableAdapters.TBLDEPOLARTableAdapter tBLDEPOLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepoAd;
    }
}