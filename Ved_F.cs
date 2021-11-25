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
    public partial class Ved_F : Form
    {
        public Ved_F()
        {
            InitializeComponent();
        }

        private void Ved_F_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Ведомость_ф_р_в". При необходимости она может быть перемещена или удалена.
            this.ведомость_ф_р_вTableAdapter.Fill(this.iDDataSet.Ведомость_ф_р_в);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoResizeColumns();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "ФамилияИО")
                this.ведомостьФрвBindingSource.Filter = "[" + this.comboBox1.Text + "] like '" + this.textBox1.Text + "*'";
            if (this.comboBox1.Text.StartsWith("Отр") || this.comboBox1.Text.StartsWith("Все") || this.comboBox1.Text.StartsWith("Яв"))
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
                        this.ведомостьФрвBindingSource.Filter = "[" + this.comboBox1.Text + "] < '" + temp + "'";
                        break;
                    case ">":
                        this.ведомостьФрвBindingSource.Filter = "[" + this.comboBox1.Text + "] > '" + temp + "'";
                        break;
                    case "=":
                        this.ведомостьФрвBindingSource.Filter = "[" + this.comboBox1.Text + "] = '" + temp + "'";
                        break;
                    default:
                        this.ведомостьФрвBindingSource.Filter = "[" + this.comboBox1.Text + "] = '" + temp + "'";
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ведомостьФрвBindingSource.Filter = "";
            this.comboBox1.Text = "";
            this.textBox1.Text = "";
        }
    }
}
