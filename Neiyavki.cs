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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Неявки". При необходимости она может быть перемещена или удалена.
            this.неявкиTableAdapter.Fill(this.iDDataSet.Неявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.iDDataSet.Сотрудники);

            string t;

            int i, k;
            DataRowView r, r1;
            this.неявкиBindingSource.MoveFirst();
            i = 0;
            while (i < this.неявкиBindingSource.Count)
            {
                r = (DataRowView)this.неявкиBindingSource.Current;
                k = (int)r["Сотрудник"];
                this.сотрудникиBindingSource.Filter = "Код_С=" + Convert.ToString(k);
                r1 = (DataRowView)this.сотрудникиBindingSource.Current;
                t = (string)r1["ФамилияИО"];
                r["ФамилияИО"] = t;
                i = i + 1;
                this.неявкиBindingSource.MoveNext();
            }
            this.неявкиBindingSource.Filter = "";
            this.сотрудникиBindingSource.Filter = "";

            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoResizeColumns();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.неявкиBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.iDDataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "ФамилияИО")
                    this.неявкиBindingSource.Filter = "[" + toolStripComboBox1.Text + "] like '" + toolStripTextBox1 + "*'";
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
                        this.неявкиBindingSource.Filter = "[" + toolStripComboBox1.Text + "] < '" + temp + "'";
                        break;
                    case ">":
                        this.неявкиBindingSource.Filter = "[" + toolStripComboBox1.Text + "] > '" + temp + "'";
                        break;
                    case "=":
                        this.неявкиBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
                        break;
                    default:
                        this.неявкиBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
                        break;
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.неявкиBindingSource.Filter = "";
            this.toolStripComboBox1.Text = "";
            this.toolStripTextBox1.Text = "";
        }
    }
}
