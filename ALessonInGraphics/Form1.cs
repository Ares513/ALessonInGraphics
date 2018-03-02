using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALessonInGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            testButton.Text = "I was clicked!";
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var myPen = new Pen(Color.FromArgb(100, 182, 76, 126));

            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, 50, 50));
            //we can make as any calls as we want here- they will be drawn in order
            g.DrawRectangle(myPen, new Rectangle(10, 10, 50, 50));
            
        }
    }
}
