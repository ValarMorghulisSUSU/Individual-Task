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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.iDDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iDDataSet.sotrfond". При необходимости она может быть перемещена или удалена.
            this.sotrfondTableAdapter.Fill(this.iDDataSet.sotrfond);

            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoResizeColumns();

        }

        //Refresh
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sotrfondBindingSource.ResetBindings(false);
            this.sotrfondTableAdapter.Update(this.iDDataSet.sotrfond);
            this.sotrfondTableAdapter.Fill(this.iDDataSet.sotrfond);

        }

        //Look
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (this.toolStripComboBox1.Text)
            {

                case "ФамилияИО": 
                    this.sotrfondBindingSource.Filter = "[" + toolStripComboBox1.Text + "] like '" + toolStripTextBox1 + "*'";
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
                            this.sotrfondBindingSource.Filter = "[" + toolStripComboBox1.Text + "] < '" + temp + "'";
                            break;
                        case ">":
                            this.sotrfondBindingSource.Filter = "[" + toolStripComboBox1.Text + "] > '" + temp + "'";
                            break;
                        case "=":
                            this.sotrfondBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
                            break;
                        default:
                            this.sotrfondBindingSource.Filter = "[" + toolStripComboBox1.Text + "] = '" + temp + "'";
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
            this.sotrfondBindingSource.Filter = "";
            this.toolStripComboBox1.Text = "";
            this.toolStripTextBox1.Text = "";
        }
    }
}
