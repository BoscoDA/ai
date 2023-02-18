using System.Drawing;

/* 
Base of the code was generated together in class

Added ability to increase and decrease the size of the matrix

Added function to generate row and  col labels
*/

namespace MatrixToGraph
{
    public partial class Form1 : Form
    {
        private int min = 4;
        private int max = 10;
        private int cur = 0;

        public Form1()
        {
            InitializeComponent();

            cur = min;

            AddTextBoxes(cur);
            AddLabels(cur);

        }

        public void AddTextBoxes(int size)
        {
            for(int i = 1; i < size; i++)
            {
                for(int j = 1; j <  size; j++)
                {
                    // node_row_col
                    tbLayout.Controls.Add(new TextBox() { Name = $"node_{i}_{j}" }, j, i);
                }
            }

            foreach(TextBox tb in tbLayout.Controls.OfType<TextBox>().ToList())
            {
                if(tb.Name.Substring(5,1) == tb.Name.Substring(7,1) )
                {
                    tb.Text = "0";
                    tb.Enabled = false;
                    tb.ReadOnly = true;
                }
            }
        }

        public void AddLabels(int size)
        {
            //Create row labels
            for(int i = 1; i < size; i++)
            {
                tbLayout.Controls.Add(new Label() { Text = $"V{i}", TextAlign = ContentAlignment.MiddleCenter}, 0, i);
            }

            //Create col labels
            for (int i = 1; i < size; i++)
            {
                tbLayout.Controls.Add(new Label() { Text = $"V{i}", TextAlign = ContentAlignment.BottomCenter }, i, 0);
            }
        }

        public void IncreaseSize()
        {
            var tbs = tbLayout.Controls.OfType<TextBox>().ToList();

            if(cur < max)
            {
                cur++;
                tbLayout.Controls.Clear();
                //AddTextBoxes(cur);
                AddLabels(cur);

                for (int i = 1; i < cur; i++)
                {
                    for (int j = 1; j < cur; j++)
                    {
                        // node_row_col
                        if (i < cur - 1 && j < cur - 1)
                        {
                            tbLayout.Controls.Add(tbs.Find(b => b.Name == $"node_{i}_{j}"), j, i);
                        }
                        else
                        {
                            tbLayout.Controls.Add(new TextBox() { Name = $"node_{i}_{j}" }, j, i);
                        }
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

            else
            {
                MessageBox.Show("Matrix already at max size!");
            }
        }

        public void DecreaseSize()
        {
            var tbs = tbLayout.Controls.OfType<TextBox>().ToList();

            if (cur - 1 >= min)
            {
                cur--;
                tbLayout.Controls.Clear();
                AddLabels(cur);

                for (int i = 1; i < cur; i++)
                {
                    for (int j = 1; j < cur; j++)
                    {
                        // node_row_col
                        if (i < cur && j < cur)
                        {
                            tbLayout.Controls.Add(tbs.Find(b => b.Name == $"node_{i}_{j}"), j, i);
                        }
                        else
                        {
                            tbLayout.Controls.Add(new TextBox() { Name = $"node_{i}_{j}" }, j, i);
                        }
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

            else
            {
                MessageBox.Show("Matrix already at min size!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tbs = tbLayout.Controls.OfType<TextBox>().ToList();
            frmGraph frmGraph = new frmGraph(tbs, cur-1);
            frmGraph.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IncreaseSize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DecreaseSize();
        }
    }
}