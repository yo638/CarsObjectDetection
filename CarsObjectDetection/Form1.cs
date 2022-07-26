﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsObjectDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "PNG|*.png|JPEG|*.jpeg|JPG|*.jpg" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image=Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }
    }
}
