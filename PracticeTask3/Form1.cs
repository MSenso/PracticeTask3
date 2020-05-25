﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTask3
{
    public partial class Form1 : Form
    {
        double x, y, u, e = 0.01;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                YInput.Text = YInput.Text.Replace('.', ',');
                if (UOutput.Text == string.Empty)
                {
                    if (double.TryParse(YInput.Text, out y))
                    {
                        XInput.Text = XInput.Text.Replace('.', ',');
                        if (double.TryParse(XInput.Text, out x))
                        {
                            UOutput.Focus();
                            U_Calculation();
                        }
                        else XInput.Focus();
                    }
                    else MessageBox.Show("Введите вещественное число!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UOutput.Text = string.Empty;
                    XInput.Focus();
                }
            }
        }

        private void UOutput_Click(object sender, EventArgs e)
        {
        }

        void U_Calculation()
        {
            double approximate_value = Math.Pow(x, 2);
            if (Math.Abs(Math.Round(Math.Pow(x, 2), 2) - Math.Pow(x, 2)) <= e) approximate_value = Math.Round(Math.Pow(x, 2), 2);
            bool first_limit = y > approximate_value;
            approximate_value = Math.Pow(Math.E, x);
            if (Math.Abs(Math.Round(Math.Pow(x, 2), 2) - Math.Pow(x, 2)) <= e) approximate_value = Math.Round(Math.Pow(Math.E, x), 2);
            bool second_limit = y < approximate_value;
            approximate_value = Math.Pow(Math.E, -x);
            if (Math.Abs(Math.Round(Math.Pow(x, 2), 2) - Math.Pow(x, 2)) <= e) approximate_value = Math.Round(Math.Pow(Math.E, -x), 2);
            bool third_limit = y < approximate_value;
            if (first_limit && second_limit && third_limit)
                u = x + y;
            else u = x - y;
            UOutput.Text = u.ToString();
        }
        private void XInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UOutput.Text == string.Empty)
                {
                    XInput.Text = XInput.Text.Replace('.', ',');
                    if (double.TryParse(XInput.Text, out x))
                    {
                        YInput.Text = YInput.Text.Replace('.', ',');
                        if (double.TryParse(YInput.Text, out y))
                        {
                            UOutput.Focus();
                            U_Calculation();
                        }
                        else YInput.Focus();
                    }
                    else MessageBox.Show("Введите вещественное число!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UOutput.Text = string.Empty;
                    YInput.Focus();
                }
            }
        }
    }
}
