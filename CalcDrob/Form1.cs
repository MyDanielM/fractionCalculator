using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcDrob
{
    public partial class Form1 : Form
    {
        fullFraction a = new fullFraction();
        fullFraction b = new fullFraction();
        fullFraction resultFraction = new fullFraction();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox2.Text == "0" || textBox3.Text == "0" || textBox4.Text == "0" || textBox5.Text == "0" || textBox6.Text == "0")
            {
                MessageBox.Show("Введите валидное значение!");
                return;
            }
            else 
            try
            {
                //------------------первая-----------------------------------
                //Считали целое
                if (textBox1.Text != "")
                    a.FULLValue = int.Parse(textBox1.Text);
                else a.FULLValue = 0;

                //Считали числитель
                if (textBox2.Text != "")
                    a.TOP = int.Parse(textBox2.Text);
                else throw new Exception("У первой дроби нет числителя!");

                //Считали знаменатель
                if (textBox3.Text != "")
                    a.BOT = int.Parse(textBox3.Text);
                else throw new Exception("У первой дроби нет знаменателя!");
                //-----------------------------------------------------------

                //--------------------вторая---------------------------------
                //Считали целое
                if (textBox6.Text != "")
                    b.FULLValue = int.Parse(textBox6.Text);
                else b.FULLValue = 0;

                //Считали числитель
                if (textBox5.Text != "")
                    b.TOP = int.Parse(textBox5.Text);
                else throw new Exception("У второй дроби нет числителя!");

                //Считали знаменатель
                if (textBox4.Text != "")
                    b.BOT = int.Parse(textBox4.Text);
                else throw new Exception("У второй дроби нет знаменателя!");
                //-----------------------------------------------------------
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            string item = comboBox1.Text;

            try
            {
                switch (item)
                {
                    case "сложение":
                        {

                            resultFraction = a + b;

                            break;
                        }
                    case "вычитание":
                        {
                            resultFraction = a - b;

                            break;

                        }
                    case "умножение":
                        {
                            resultFraction = a * b;

                            break;
                        }
                    case "деление":
                        {
                            resultFraction = a / b;

                            break;
                        }
                    default:
                        { MessageBox.Show("Выберите действие!");break; }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            if (resultFraction.FULLValue != 0)
            {
                textBox9.Visible = true;
                textBox9.Text = resultFraction.FULLValue.ToString();
            }
            else textBox9.Visible = false;
            if (resultFraction.TOP != 0)
            {
                textBox7.Visible = true;
                pictureBox3.Visible = true;
                textBox8.Visible = true;
                textBox8.Text = resultFraction.TOP.ToString();
                textBox7.Text = resultFraction.BOT.ToString();
            }

        }

        /// <summary>
        /// Метод обрабатывает нажатия кнопок на клавиатуре
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                if (!(e.KeyChar == '-' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
                    e.Handled = true;
            }
            else if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }
    }
}
