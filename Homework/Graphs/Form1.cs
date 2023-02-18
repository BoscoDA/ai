using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddTextBoxes();
            AddLabels();

        }

        public void AddTextBoxes()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    // node_row_col
                    tbLayout.Controls.Add(new TextBox() { Name = $"node_{i}_{j}" }, j, i);
                }
            }

            foreach (TextBox tb in tbLayout.Controls.OfType<TextBox>().ToList())
            {
                if (tb.Name.Substring(5, 1) == tb.Name.Substring(7, 1))
                {
                    tb.Text = "0";
                    tb.Enabled = false;
                    tb.ReadOnly = true;
                }
            }
        }

        public void AddLabels()
        {
            //Create row labels
            for (int i = 1; i < 10; i++)
            {
                tbLayout.Controls.Add(new Label() { Text = $"V{i}", TextAlign = ContentAlignment.MiddleCenter }, 0, i);
            }

            //Create col labels
            for (int i = 1; i < 10; i++)
            {
                tbLayout.Controls.Add(new Label() { Text = $"V{i}", TextAlign = ContentAlignment.BottomCenter }, i, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tbs = tbLayout.Controls.OfType<TextBox>().ToList();
            frmGraph frmGraph = new frmGraph(tbs);
            frmGraph.ShowDialog();
        }
    }
}
