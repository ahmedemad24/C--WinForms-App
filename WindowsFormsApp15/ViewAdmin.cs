﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class ViewAdmin : Form
    {
        public ViewAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();

            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminClient client = new AdminClient();
            client.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.ShowDialog();
        }
    }
}
