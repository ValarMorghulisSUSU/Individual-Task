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
    public partial class Neiyavki : Form
    {
        public Neiyavki()
        {
            InitializeComponent();
        }

        private void Neiyavki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.iDDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.sotrneiyav". При необходимости она может быть перемещена или удалена.
            this.sotrneiyavTableAdapter.Fill(this.iDDataSet.sotrneiyav);

            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoResizeColumns();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sotrneiyavBindingSource.ResetBindings(false);
            this.sotrneiyavTableAdapter.Update(this.iDDataSet.sotrneiyav);
            this.sotrneiyavTableAdapter.Fill(this.iDDataSet.sotrneiyav);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "ФамилияИО")
                    this.sotrneiyavBindingSource.Filter = "[" + toolStripComboBox1.Text + "] like '" + toolStripTextBox1 + "*'";
            if (toolStripComboBox1.Text.Substring(0,1) == "Н")
            {
                string str = toolStripTextBox1.Text.Replace(" ", "");
                string znak = str.Substring(0, 1);
                str = str.Replace("<", "");
                str = str.Replace(">", "");
                str = str.Replace("=", "");
                int temp;
                int.TryParse(str, out temp);
                switch (znak)
                {
                    case "<":
                        this.sotrneiyavBindingSource.Filter = "[" + toolStripComboBox1.Text + "] < '" + temp + "'";
                        break;
                    case ">":
                        this.sotrneiyavBindingSource.Filter = "[" + toolStripComboBox1.Text + "] > '" + temp + "'";
                        break;
                    case "=":
                        this.sotrneiyavBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
                        break;
                    default:
                        this.sotrneiyavBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
                        break;
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.sotrneiyavBindingSource.Filter = "";
            this.toolStripComboBox1.Text = "";
            this.toolStripTextBox1.Text = "";
        }
    }
}
