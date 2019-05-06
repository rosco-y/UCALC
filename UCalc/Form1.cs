﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCalc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Focus();
        }

        #region CMD NUMERALS CLICK
        void AppendInput(string input)
        {
            txtInput.Text += input;
        }


        private void cmd0_Click(object sender, EventArgs e)
        {
            string input = cmd0.Text;
            AppendInput(input);
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            string input = cmd1.Text;
            AppendInput(input);
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            string input = cmd2.Text;
            AppendInput(input);
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            string input = cmd3.Text;
            AppendInput(input);
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            string input = cmd4.Text;
            AppendInput(input);
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            string input = cmd5.Text;
            AppendInput(input);
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            string input = cmd6.Text;
            AppendInput(input);
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            string input = cmd7.Text;
            AppendInput(input);
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            string input = cmd8.Text;
            AppendInput(input);
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            string input = cmd9.Text;
            AppendInput(input);
        }
        #endregion

        private void cmdDot_Click(object sender, EventArgs e)
        {
            AppendInput(".");
        }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                
                case Keys.NumPad1:
                    cmd1_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad2:
                    cmd2_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad3:
                    cmd3_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad4:
                    cmd4_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad5:
                    cmd5_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad6:
                    cmd6_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad7:
                    cmd7_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad8:
                    cmd8_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad9:
                    cmd9_Click(sender, new EventArgs());
                    break;
                case Keys.NumPad0:
                    cmd0_Click(sender, new EventArgs());
                    break;
                case Keys.Decimal:
                    cmdDot_Click(sender, new EventArgs());
                    break;
                case Keys.Enter:
                    if (txtInput.Text.Length > 0)
                    {
                        txtHistory.Text += txtInput.Text + Environment.NewLine;
                        txtInput.Clear();
                    }
                    break;




            }
        }
    }
}