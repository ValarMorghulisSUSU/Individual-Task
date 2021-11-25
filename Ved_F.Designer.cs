
namespace ID
{
    partial class Ved_F
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.фамилияИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отработаноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегоНеявокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.явочныйКоэффициентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ведомостьФрвBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataSet = new ID.IDDataSet();
            this.ведомость_ф_р_вTableAdapter = new ID.IDDataSetTableAdapters.Ведомость_ф_р_вTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьФрвBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ID.Properties.Resources.Close_red_16x;
            this.button2.Location = new System.Drawing.Point(557, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 30);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ID.Properties.Resources.LookupChoiceFieldIndex_16x;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(518, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ФамилияИО",
            "Отработано",
            "Всего неявок",
            "Явочный коэффициент"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияИОDataGridViewTextBoxColumn,
            this.отработаноDataGridViewTextBoxColumn,
            this.всегоНеявокDataGridViewTextBoxColumn,
            this.явочныйКоэффициентDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ведомостьФрвBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(578, 399);
            this.dataGridView1.TabIndex = 9;
            // 
            // фамилияИОDataGridViewTextBoxColumn
            // 
            this.фамилияИОDataGridViewTextBoxColumn.DataPropertyName = "ФамилияИО";
            this.фамилияИОDataGridViewTextBoxColumn.HeaderText = "ФамилияИО";
            this.фамилияИОDataGridViewTextBoxColumn.Name = "фамилияИОDataGridViewTextBoxColumn";
            // 
            // отработаноDataGridViewTextBoxColumn
            // 
            this.отработаноDataGridViewTextBoxColumn.DataPropertyName = "Отработано";
            this.отработаноDataGridViewTextBoxColumn.HeaderText = "Отработано";
            this.отработаноDataGridViewTextBoxColumn.Name = "отработаноDataGridViewTextBoxColumn";
            this.отработаноDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // всегоНеявокDataGridViewTextBoxColumn
            // 
            this.всегоНеявокDataGridViewTextBoxColumn.DataPropertyName = "Всего неявок";
            this.всегоНеявокDataGridViewTextBoxColumn.HeaderText = "Всего неявок";
            this.всегоНеявокDataGridViewTextBoxColumn.Name = "всегоНеявокDataGridViewTextBoxColumn";
            this.всегоНеявокDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // явочныйКоэффициентDataGridViewTextBoxColumn
            // 
            this.явочныйКоэффициентDataGridViewTextBoxColumn.DataPropertyName = "Явочный коэффициент";
            this.явочныйКоэффициентDataGridViewTextBoxColumn.HeaderText = "Явочный коэффициент";
            this.явочныйКоэффициентDataGridViewTextBoxColumn.Name = "явочныйКоэффициентDataGridViewTextBoxColumn";
            this.явочныйКоэффициентDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ведомостьФрвBindingSource
            // 
            this.ведомостьФрвBindingSource.DataMember = "Ведомость ф_р_в";
            this.ведомостьФрвBindingSource.DataSource = this.iDDataSet;
            // 
            // iDDataSet
            // 
            this.iDDataSet.DataSetName = "IDDataSet";
            this.iDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ведомость_ф_р_вTableAdapter
            // 
            this.ведомость_ф_р_вTableAdapter.ClearBeforeFill = true;
            // 
            // Ved_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Ved_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Использование фонда рабочего времени";
            this.Load += new System.EventHandler(this.Ved_F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьФрвBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IDDataSet iDDataSet;
        private System.Windows.Forms.BindingSource ведомостьФрвBindingSource;
        private IDDataSetTableAdapters.Ведомость_ф_р_вTableAdapter ведомость_ф_р_вTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отработаноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегоНеявокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn явочныйКоэффициентDataGridViewTextBoxColumn;
    }
}