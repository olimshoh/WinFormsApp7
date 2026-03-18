using System;
using System.Windows.Forms;
namespace AbiturientApp
{
    public partial class Abiturient_F : Form
    {
        public Abiturient_F()
        {
            InitializeComponent();
        }
                private void DialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                try
                {
                    if (Familia_TB.Text.Trim() == "")
                    {
                        Familia_TB.Focus();
                        throw new Exception("Вы не ввели фамилию абитуриента!");
                    }
                    if (Shkola_TB.Text.Trim() == "")
                    {
                        Shkola_TB.Focus();
                        throw new Exception("Вы не ввели номер школы!");
                    }
                    int shkola = Convert.ToInt32(Shkola_TB.Text);
                    if (shkola < 1 || shkola > 200)
                    {
                        Shkola_TB.Focus();
                        throw new Exception("Номер школы должен быть от 1 до 200!");
                    }
                    if (Shifr_TB.Text.Trim() == "")
                    {
                        Shifr_TB.Focus();
                        throw new Exception("Вы не ввели шифр специальности!");
                    }
                    int shifr = Convert.ToInt32(Shifr_TB.Text);
                    if (shifr < 1 || shifr > 300)
                    {
                        Shifr_TB.Focus();
                        throw new Exception("Шифр должен быть от 1 до 300!");
                    }
                    if (Balli_TB.Text.Trim() == "")
                    {
                        Balli_TB.Focus();
                        throw new Exception("Вы не ввели количество баллов!");
                    }
                    int ball = Convert.ToInt32(Balli_TB.Text);
                    if (ball < 0 || ball > 200)
                    {
                        Balli_TB.Focus();
                        throw new Exception("Баллы должны быть от 0 до 200!");
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    MessageBox.Show("Введите целое число!", "Ошибка");
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
    }
}