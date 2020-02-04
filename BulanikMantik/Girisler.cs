using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulanikMantik
{
    public partial class Girisler : Form
    {
        public Girisler()
        {
            InitializeComponent();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point point = pictureBox1.PointToClient(Cursor.Position);
            MessageBox.Show(point.ToString());
        }

        private void Girisler_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            //if( (Convert.ToDouble(frm.txtSıcaklık.Text)) == 20)
            //{
            //    Graphics g = pictureBox1.CreateGraphics();
            //    var p = new Pen(Color.Black, 3);
            //    var point1 = new Point(120, 309);
            //    var point2 = new Point(69, 24);
            //    g.DrawLine(p, point1, point2);


            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Point point = pictureBox1.PointToClient(Cursor.Position);
            MessageBox.Show(point.ToString());

        }
    }
}
