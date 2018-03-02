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
        //for now, we can refactor this later into some kind of manager
        List<Entity> entities;
        public Form1()
        {
            InitializeComponent();
            //set these to reduce flicker
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
        }
        //init
        private void Form1_Load(object sender, EventArgs e)
        {
            //actual init logic; don't put stuff in the constructor, as UI elements haven't loaded
            entities = new List<Entity>();
            //add a test entity 
            entities.Add(new Entity(new Point(0, 0), new Point(1, 1)));
            
            //game is ready!
            gameTimer.Enabled = true;
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
            
            foreach(var ent in entities)
            {
                //our draw function; other things could implement this differently: recommend classes inherit from enttiy and impl their own draw
                g.DrawRectangle(Pens.Black, new Rectangle(ent.Position.X, ent.Position.Y, 10, 10));
                g.DrawImage(Properties.Resources.alphatest, new Rectangle(ent.Position.X, ent.Position.Y, 100, 100));
            }
        }



        private void gameTimer_Tick(object sender, EventArgs e)
        {
            drawPanel.Invalidate(); //technically a refresh is an invalidate
            foreach(var ent in entities)
            {
                ent.Update();
            }
        }
    }
}
