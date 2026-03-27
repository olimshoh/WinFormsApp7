using System;
using System.Windows.Forms;
namespace AbiturientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Abiturient_F dialog = new Abiturient_F();
            dialog.Text = "Добавление абитуриента";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TAbiturient abiturient = new TAbiturient
                {
                    Familia = dialog.Familia_TB.Text.Trim(),
                    Shkola = Convert.ToInt32(dialog.Shkola_TB.Text.Trim()),
                    Shifr = Convert.ToInt32(dialog.Shifr_TB.Text.Trim()),
                    Balli = Convert.ToInt32(dialog.Balli_TB.Text.Trim())
                };
                listBoxAbits.Items.Add(abiturient);
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.Items.Count == 0)
            {
                MessageBox.Show("Нет данных для изменения", "Информация");
                return;
            }
            // Проверка, что выделен элемент
            if (listBoxAbits.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
                return;
            }
            TAbiturient abiturient = listBoxAbits.SelectedItem as TAbiturient;
            if (abiturient == null) return;
            Abiturient_F dialog = new Abiturient_F();
            dialog.Text = "Изменение данных";
            dialog.Familia_TB.Text = abiturient.Familia;
            dialog.Shkola_TB.Text = abiturient.Shkola.ToString();
            dialog.Shifr_TB.Text = abiturient.Shifr.ToString();
            dialog.Balli_TB.Text = abiturient.Balli.ToString();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                abiturient.Familia = dialog.Familia_TB.Text.Trim();
                abiturient.Shkola = Convert.ToInt32(dialog.Shkola_TB.Text.Trim());
                abiturient.Shifr = Convert.ToInt32(dialog.Shifr_TB.Text.Trim());
                abiturient.Balli = Convert.ToInt32(dialog.Balli_TB.Text.Trim());
                listBoxAbits.Items[listBoxAbits.SelectedIndex] = abiturient;
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.SelectedIndex != -1)
            {
                listBoxAbits.Items.RemoveAt(listBoxAbits.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
            }
        }
    }
}
