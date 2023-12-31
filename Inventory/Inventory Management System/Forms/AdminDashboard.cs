﻿using Inventory_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            DisplayDashBoardUserControl();
        }
        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ForeColor = Color.White;

            btnProducts.BackColor = Color.White;
            btnProducts.ForeColor = Color.Black;
            int x = 0;
            int y = 86;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;
            
            //Display the product User Control
            ProductControl productControl = new ProductControl();
            DisplayUserControl(productControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnProducts.FillColor = Color.Transparent;
            btnProducts.BackColor = Color.Transparent;
            btnProducts.ForeColor = Color.White;

            btnDashboard.BackColor = Color.White;
            btnDashboard.ForeColor = Color.Black;
            int x = 0;
            int y = 43;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            DisplayDashBoardUserControl();
        }
        private void DisplayDashBoardUserControl()
        {
            Summary summary = new Summary();
            DisplayUserControl(summary);
        }
        //Display the User Controls
        private void DisplayUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
