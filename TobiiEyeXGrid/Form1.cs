﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    public partial class Form1 : Form
    {
        Model model;
        View view;
        Controller controller;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Model aModel, View aView, Controller aController)
        {
            InitializeComponent();
            model = aModel;
            view = aView;
            controller = aController;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            //add event handlers
            panel1.Paint += view.onDraw;
            panel1.MouseDown += controller.handleMouseDown;
            panel1.MouseUp += controller.handleMouseUp;
            panel1.MouseMove += controller.handleMouseMove;

            //draw grid
            model.generateGrid(panel1);
            panel1.Invalidate();
        }
    }
}
