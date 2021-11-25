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
    public partial class Ved_N : Form
    {
        public Ved_N()
        {
            InitializeComponent();
        }

        private void Ved_N_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Сумма_неявок". При необходимости она может быть перемещена или удалена.
            this.сумма_неявокTableAdapter.Fill(this.iDDataSet.Сумма_неявок);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoResizeColumns();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "ФамилияИО")
                this.суммаНеявокBindingSource.Filter = "[" + this.comboBox1.Text + "] like '" + this.textBox1.Text + "*'";
            if (this.comboBox1.Text.StartsWith("Все"))
            {
                string str = this.textBox1.Text.Replace(" ", "");
                string znak = str.Substring(0, 1);
                str = str.Replace("<", "");
                str = str.Replace(">", "");
                str = str.Replace("=", "");
                int temp;
                int.TryParse(str, out temp);
                switch (znak)
                {
                    case "<":
                        this.суммаНеявокBindingSource.Filter = "[" + this.comboBox1.Text + "] < '" + temp + "'";
                        break;
                    case ">":
                        this.суммаНеявокBindingSource.Filter = "[" + this.comboBox1.Text + "] > '" + temp + "'";
                        break;
                    case "=":
                        this.суммаНеявокBindingSource.Filter = "[" + this.comboBox1.Text + "] = '" + temp + "'";
                        break;
                    default:
                        this.суммаНеявокBindingSource.Filter = "[" + this.comboBox1.Text + "] = '" + temp + "'";
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.суммаНеявокBindingSource.Filter = "";
            this.comboBox1.Text = "";
            this.textBox1.Text = "";
        }
    }
}
