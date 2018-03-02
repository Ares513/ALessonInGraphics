﻿using System;
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
            g.DrawRectangle(Pens.Black, new Rectangle(10, 10, 10, 10));
        }
    }
}
