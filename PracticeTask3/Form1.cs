using System;
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
        public double x, y, u, e = 0.01;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                YInput.Text = YInput.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                if (double.TryParse(YInput.Text, out y) && Math.Abs(y) <= 10000000000000 && (Math.Abs(y) >= 0.00000000000001 || y == 0)) // Ограничение на у
                {
                    XInput.Text = XInput.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                    if (double.TryParse(XInput.Text, out x) && Math.Abs(x) <= 10000000000000 && (Math.Abs(x) >= 0.00000000000001 || x == 0)) // Ограничение на х
                    {
                        UOutput.Focus();
                        U_Calculation(); // Подсчет
                    }
                    else XInput.Focus();
                }
                else MessageBox.Show("Введите вещественное число!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UOutput_Click(object sender, EventArgs e)
        {
        }

        public void U_Calculation() // Подсчет u
        {
            double result = Math.Pow(x, 2); // Нахождение значения х в квадрате
            if (Math.Abs(Math.Round(result, 4) - result) <= e)
                result = Math.Round(result, 4); // Округление
            bool first_limit = y > result; // Определение, лежит ли точка выше параболы
            result = Math.Pow(Math.E, x); // Нахождение е в х
            if (Math.Abs(Math.Round(result, 4) - result) <= e)
                result = Math.Round(result, 4); // Округление
            bool second_limit = y < result; // Опредление, лежит ли точка ниже экспоненты
            result = Math.Pow(Math.E, -x); // Нахождение е в -х
            if (Math.Abs(Math.Round(result, 4) - result) <= e)
                result = Math.Round(result, 4); // Округление
            bool third_limit = y < result; // Определение, лежит ли точка ниже экспоненты
            if (first_limit && second_limit && third_limit) // Условия выполнены, точка лежит в D
                u = x + y;
            else u = x - y; // Точка не лежит в D
            UOutput.Text = u.ToString();
        }
        private void XInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                XInput.Text = XInput.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                if (double.TryParse(XInput.Text, out x) && Math.Abs(x) <= 10000000000000 && (Math.Abs(x) >= 0.00000000000001 || x == 0)) // Ограничение на х
                {
                    YInput.Text = YInput.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                    if (double.TryParse(YInput.Text, out y) && Math.Abs(y) <= 10000000000000 && (Math.Abs(y) >= 0.00000000000001 || y == 0)) // Ограничение на у
                    {
                        UOutput.Focus();
                        U_Calculation(); // Подсчет
                    }
                    else YInput.Focus();
                }
                else MessageBox.Show("Некорректный ввод числа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}