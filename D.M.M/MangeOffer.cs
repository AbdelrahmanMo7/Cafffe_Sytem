﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafffe_Sytem.D.M.M
{
    public partial class MangeOffer : Form
    {
        public event EventHandler eva;
        Coffee_SystemEntities dbContext = new Coffee_SystemEntities();
        public MangeOffer()
        {
            InitializeComponent();
        }
      public void  InitializeForUpdate(int offerOff_ID,string offerOff_Name,string offerOff_Limit,string offerOff_Start,string offerOff_End)
        {
            ID_txt.Text = offerOff_ID.ToString();
            offname_txt.Text = offerOff_Name;
            offlimit_txt.Text =( offerOff_Limit).ToString();
            offstart_txt.Text = offerOff_Start.ToString();
            offend_txt.Text = offerOff_End.ToString();
        }
        private void update_btn_Click(object sender, EventArgs e)
        {

            int offerID = int.Parse(ID_txt.Text);
            string offerOff_Name = offname_txt.Text;
            string offerOff_Limit = offlimit_txt.Text;
            DateTime offerOff_Start = DateTime.Parse(offstart_txt.Text);
            TimeSpan offerOff_End = TimeSpan.Parse(offend_txt.Text);

            // Retrieve the Clint entity from the database
            Offer q3 = dbContext.Offers.FirstOrDefault(c => c.Off_ID == offerID);

            // Update the properties of the retrieved Clint entity
            if (q3 != null)
            {
                q3.Off_Name = offerOff_Name;
                q3.Off_Limit = int.Parse( offerOff_Limit);
                q3.Off_Start = offerOff_Start;
                q3.Off_End = offerOff_End;

                // Save changes to the database
                dbContext.Entry(q3).State = EntityState.Detached;
            }
            dbContext.Offers.Attach(q3);
            dbContext.Entry(q3).State = EntityState.Modified;
            dbContext.SaveChanges();
            MessageBox.Show("update Successfull");

            eva?.Invoke(this, e);
        }
        private void add_btn_Click(object sender, EventArgs e)
        {



            Offer offer = new Offer()
            {
                Off_Name = offname_txt.Text,
                Off_Limit = int.Parse(offlimit_txt.Text),
                Off_Start =DateTime.Parse( offstart_txt.Text),
                Off_End =TimeSpan.Parse( offend_txt.Text),
            };
            dbContext.Offers.Add(offer);
            dbContext.SaveChanges();
            MessageBox.Show("add Successfull");
            eva?.Invoke(this, e);
        }

    }
}