using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID
{
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.iDDataSet.Сотрудники);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoResizeColumns();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.ResetBindings(false);
            this.сотрудникиTableAdapter.Update(this.iDDataSet.Сотрудники);
            this.сотрудникиTableAdapter.Fill(this.iDDataSet.Сотрудники);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.toolStripTextBox1.Text != "")
                this.сотрудникиBindingSource.Filter = "[ФамилияИО] like '" + toolStripTextBox1 + "*'";
            
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.Filter = "";
            this.toolStripTextBox1.Text = "";
        }
    }
}
