﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafffe_Sytem.A.M.A
{
    public partial class Report_Page : Form

    {
        public Report_Page()
        {
            InitializeComponent();
        }

        private void Report_Page_Load(object sender, EventArgs e)
        {
            //Report_Page p = new Report_Page();
            int x = 2;

        }

        private void sPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sButton1_Click(object sender, EventArgs e)
        {

        }

        bool isexpend;

        private void SideBar_timer_Tick(object sender, EventArgs e)
        {
            if (isexpend)
            {
                sidebar_layout.Width -=10 ;
                if(sidebar_layout.Width== sidebar_layout.MinimumSize.Width)
                {
                    isexpend = false;
                    SideBar_timer.Stop();
                }
            }
            else
            {
                sidebar_layout.Width += 10;
                if (sidebar_layout.Width == sidebar_layout.MaximumSize.Width)
                {
                    isexpend = true;
                    SideBar_timer.Stop();
                }
            }
        }

        private void SideBar_btn_Click(object sender, EventArgs e)
        {
            SideBar_timer.Start();
             if (isexpend)
            {
                SideBar_btn.Image = Cafffe_Sytem.Properties.Resources.icons8_menu_36;
                SideBar_btn.Refresh();
            }
             else
            {
                SideBar_btn.Image = Cafffe_Sytem.Properties.Resources.icons8_activity_feed_33;
                SideBar_btn.Refresh();
            }
        }
    }
}
