using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public partial class frmGraph : Form
    {
        private List<TextBox> Edges = new List<TextBox>();
        private PointF Origin = new PointF(450F, 300F);
        private int SideLength = 200;
        private PointF[] Vertices = new PointF[0];

        public frmGraph()
        {
            InitializeComponent();
        }

        public frmGraph(List<TextBox> tbs)
        {
            InitializeComponent();
            Edges = tbs.Where(n => !string.IsNullOrEmpty(n.Text)).OrderBy(tb => tb.Name).ToList();
        }

        private void frmGraph_Paint(object sender, PaintEventArgs e)
        {
            var sideCount = ((int)Math.Sqrt(Edges.Count));

            //Validate

            GetVertices(sideCount, SideLength, Origin);

            //DrawPoly(e);
            foreach (var ver in Vertices)
            {
                DrawCricle(e, ver);
            }

            foreach (var edge in Edges)
            {
                if (edge.Text != "0")
                {
                    var col = Int32.Parse(edge.Name.Substring(5, 1));
                    var row = Int32.Parse(edge.Name.Substring(7, 1));

                    DrawEdge(e, Vertices[col - 1], Vertices[row - 1]);
                }
            }
        }

        private void DrawCricle(PaintEventArgs e, PointF ver)
        {

            Pen pen = new Pen(Color.Black, 4);
            e.Graphics.DrawEllipse(pen, ver.X - 3, ver.Y - 3, 5, 5);
        }

        private void DrawPoly(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 1);
            e.Graphics.DrawPolygon(pen, Vertices);
        }

        private void DrawEdge(PaintEventArgs e, PointF src, PointF dst)
        {
            Pen pen = new Pen(Color.Red, 5);

            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, src.X, src.Y, dst.X, dst.Y);
        }


        private void GetVertices(int sides, int length, PointF origin)
        {
            var vertices = new PointF[sides];
            var degree = (180 * (sides - 2)) / sides;
            var degreeOffset = 360 / sides;

            var radian = degree * (Math.PI / 180);

            //evalulate to double
            var SinDegree = Math.Sin(radian);
            var CosDegree = Math.Cos(radian);

            vertices[0] = origin;

            for (int i = 1; i < vertices.Length; i++)
            {

                double x = vertices[i - 1].X - CosDegree * length;
                double y = vertices[i - 1].Y - SinDegree * length;

                vertices[i] = new Point((int)x, (int)y);

                degree -= degreeOffset;
                radian = degree * (Math.PI / 180);
                SinDegree = Math.Sin(radian);
                CosDegree = Math.Cos(radian);
            }

            Vertices = vertices;
        }
    }
}
