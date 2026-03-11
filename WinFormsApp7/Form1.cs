using System;
using System.Windows.Forms;

namespace AbiturientApp
{
    public partial class Form1 : Form
    {
        private TAbiturient[] abits = new TAbiturient[100];
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateList()
        {
            listBoxAbits.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                listBoxAbits.Items.Add(abits[i]);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogForm dlg = new DialogForm();
            dlg.Text = "Добавление абитуриента";
            dlg.Familia_TB.Text = "";
            dlg.Shkola_TB.Text = "";
            dlg.Shifr_TB.Text = "";
            dlg.Balli_TB.Text = "";
            if (dlg.ShowDialog() == DialogResult.OK) 
            {
                TAbiturient t = new TAbiturient();
                t.Familia = dlg.Familia_TB.Text.Trim();
                t.Shkola = Convert.ToInt32(dlg.Shkola_TB.Text);
                t.Shifr = Convert.ToInt32(dlg.Shifr_TB.Text);
                t.Balli = Convert.ToInt32(dlg.Balli_TB.Text);
                abits[count] = t;
                count++;
                UpdateList();
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите абитуриента!", "Информация");
                return;
            }
            TAbiturient t = (TAbiturient)listBoxAbits.SelectedItem;
            DialogForm dlg = new DialogForm();
            dlg.Text = "Изменение данных";
            dlg.Familia_TB.Text = t.Familia;
            dlg.Shkola_TB.Text = t.Shkola.ToString();
            dlg.Shifr_TB.Text = t.Shifr.ToString();
            dlg.Balli_TB.Text = t.Balli.ToString();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
             
                t.Familia = dlg.Familia_TB.Text.Trim();
                t.Shkola = Convert.ToInt32(dlg.Shkola_TB.Text);
                t.Shifr = Convert.ToInt32(dlg.Shifr_TB.Text);
                t.Balli = Convert.ToInt32(dlg.Balli_TB.Text);
                listBoxAbits.Items[listBoxAbits.SelectedIndex] = t;
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите абитуриента!", "Информация");
                return;
            }
            int index = listBoxAbits.SelectedIndex;
            for (int i = index; i < count - 1; i++)
            {
                abits[i] = abits[i + 1];
            }
            count--;
            abits[count] = null;

            UpdateList();
        }
    }
}