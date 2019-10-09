﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepositoryForm;
using CarObject;

namespace MainForm
{
    public partial class Form1 : Form
    {
        Repository Repo = new Repository();
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Add Car";
            button2.Text = "Rent Car";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            AddCarWindow Window1 = new AddCarWindow();
            Window1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentCar Window2 = new RentCar();
            Window2.Show();
        }
    }
}
