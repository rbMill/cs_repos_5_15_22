using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {

            Graphics Gclass = e.Graphics;
            Brush Gbrsh = new SolidBrush(Color.Black);
            Pen Gpen = new Pen(Color.DarkGray);
            Gclass.FillRectangle(Gbrsh,50,50,100,50);
            Gclass.DrawRectangle(Gpen, 50, 100, 200, 25);
        }
    }
}
