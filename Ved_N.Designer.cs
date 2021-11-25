
namespace ID
{
    partial class Ved_N
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
            this.фамилияИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегоНеявокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаНеявокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataSet = new ID.IDDataSet();
            this.сумма_неявокTableAdapter = new ID.IDDataSetTableAdapters.Сумма_неявокTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.суммаНеявокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияИОDataGridViewTextBoxColumn,
            this.всегоНеявокDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.суммаНеявокBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(450, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // фамилияИОDataGridViewTextBoxColumn
            // 
            this.фамилияИОDataGridViewTextBoxColumn.DataPropertyName = "ФамилияИО";
            this.фамилияИОDataGridViewTextBoxColumn.HeaderText = "ФамилияИО";
            this.фамилияИОDataGridViewTextBoxColumn.Name = "фамилияИОDataGridViewTextBoxColumn";
            // 
            // всегоНеявокDataGridViewTextBoxColumn
            // 
            this.всегоНеявокDataGridViewTextBoxColumn.DataPropertyName = "Всего неявок";
            this.всегоНеявокDataGridViewTextBoxColumn.HeaderText = "Всего неявок";
            this.всегоНеявокDataGridViewTextBoxColumn.Name = "всегоНеявокDataGridViewTextBoxColumn";
            this.всегоНеявокDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаНеявокBindingSource
            // 
            this.суммаНеявокBindingSource.DataMember = "Сумма неявок";
            this.суммаНеявокBindingSource.DataSource = this.iDDataSet;
            // 
            // iDDataSet
            // 
            this.iDDataSet.DataSetName = "IDDataSet";
            this.iDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сумма_неявокTableAdapter
            // 
            this.сумма_неявокTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ID.Properties.Resources.Close_red_16x;
            this.button2.Location = new System.Drawing.Point(430, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 30);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ID.Properties.Resources.LookupChoiceFieldIndex_16x;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(391, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ved_N
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ved_N";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Суммарные неявки на работу";
            this.Load += new System.EventHandler(this.Ved_N_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.суммаНеявокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IDDataSet iDDataSet;
        private System.Windows.Forms.BindingSource суммаНеявокBindingSource;
        private IDDataSetTableAdapters.Сумма_неявокTableAdapter сумма_неявокTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегоНеявокDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}