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
    public partial class Fond : Form
    {
        public Fond()
        {
            InitializeComponent();
        }

        private void Fond_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Фонд". При необходимости она может быть перемещена или удалена.
            this.фондTableAdapter.Fill(this.iDDataSet.Фонд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.iDDataSet.Сотрудники);



            string t;
            try
            {
                int i, k;
                DataRowView r, r1;
                this.фондBindingSource.MoveFirst();
                i = 0;
                while (i < this.фондBindingSource.Count)
                {
                    r = (DataRowView)this.фондBindingSource.Current;
                    k = (int)r["Сотрудник"];
                    this.сотрудникиBindingSource.Filter = "Код_С=" + Convert.ToString(k);
                    r1 = (DataRowView)this.сотрудникиBindingSource.Current;
                    t = (string)r1["ФамилияИО"];
                    r["ФамилияИО"] = t;
                    i = i + 1;
                    this.фондBindingSource.MoveNext();

                }
            }
            catch
            {

            }
            this.фондBindingSource.Filter = "";
            this.сотрудникиBindingSource.Filter = "";

            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoResizeColumns();

        }

        //Refresh
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фондBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.iDDataSet);

        }

        //Look
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (this.toolStripComboBox1.Text)
            {

                case "ФамилияИО": 
                    this.фондBindingSource.Filter = "[" + toolStripComboBox1.Text + "] like '" + toolStripTextBox1 + "*'";
                    break;
                case "ФондРабочегоВремени":
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
                            this.фондBindingSource.Filter = "[" + toolStripComboBox1.Text + "] < '" + temp + "'";
                            break;
                        case ">":
                            this.фондBindingSource.Filter = "[" + toolStripComboBox1.Text + "] > '" + temp + "'";
                            break;
                        case "=":
                            this.фондBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
                            break;
                        default:
                            this.фондBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        //Cancel
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.фондBindingSource.Filter = "";
            this.toolStripComboBox1.Text = "";
            this.toolStripTextBox1.Text = "";
        }
    }
}
