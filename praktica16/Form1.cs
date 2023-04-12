using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktica16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0;
            for(int x=-360;x<=360;x++)
            {
                y = Math.Sin(Math.PI / 180 * x);
                chart1.Series["синус"].Points.AddXY(x, y);
                y = Math.Cos(Math.PI / 180 * x);
                chart1.Series["косинус"].Points.AddXY(x, y);
            }
        }
    }
}
