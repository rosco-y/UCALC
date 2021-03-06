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

        RPN _rpn;
        public frmMain()
        {
            _rpn = new RPN();
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

        private void cmdDot_Click(object sender, EventArgs e)
        {
            AppendInput(".");
        }
        #endregion




        #region KEYPRESS
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
                    HandleInput();
                    break;
                case Keys.Add:
                    TryOperate('+');
                    break;
                case Keys.Subtract:
                    TryOperate('-');
                    break;
                case Keys.Multiply:
                    TryOperate('*');
                    break;
                case Keys.Divide:
                    TryOperate('/');
                    break;
                case Keys.Delete:
                    if (txtInput.Text.Length > 0)
                        txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                    break;

            }


        }

        /// <summary>
        /// If there is an text in the txtInput area, check to see
        /// if it is a valid float (_rpn.Add(string)) return true if
        /// the string was converted to a float.--and if it is, then
        /// it adds it to the operands list in _rpn.
        /// </summary>
        private void HandleInput()
        {
            if (txtInput.Text.Length > 0)
            {
                if (_rpn.Add(txtInput.Text))
                {
                    txtHistory.Text += txtInput.Text + Environment.NewLine;
                    txtInput.Clear();
                }
            }
        }

        #endregion

        #region METHODS


        void TryOperate(char operation)
        {
            HandleInput();
            if (_rpn.Operands.Count == 2)
            {
                float answer = _rpn.Operate(operation);
                string problem = $"{_rpn.Operands[0]} {operation} {_rpn.Operands[1]} = {answer}";
                txtHistory.AppendText(problem + Environment.NewLine);
                _rpn.Operands.Clear();
                _rpn.Operands.Add(answer);
            }
        }




        #endregion

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowState = this.WindowState;
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.Save();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = Properties.Settings.Default.WindowState;
            this.Location = Properties.Settings.Default.WindowLocation;
            this.Size = Properties.Settings.Default.WindowSize;
        }
    }
}
