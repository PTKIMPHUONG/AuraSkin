﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelSaleControl
{
    public partial class PanelSale: UserControl
    {
        public PanelSale()
        {
            InitializeComponent();
            InitializeControlsDictionary();
        }
        public Dictionary<string, Control> ControlsDictionary { get; private set; }
        private void InitializeControlsDictionary()
        {
            ControlsDictionary = new Dictionary<string, Control>();
            foreach (Control control in this.Controls)
            {
                ControlsDictionary[control.Name] = control;
            }
        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
