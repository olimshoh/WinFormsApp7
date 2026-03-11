namespace AbiturientApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxAbits;
        private Button buttonAdd;
        private Button buttonChange;
        private Button buttonDel;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxAbits = new ListBox();
            this.buttonAdd = new Button();
            this.buttonChange = new Button();
            this.buttonDel = new Button();
            this.label1 = new Label();
            this.SuspendLayout();

            // label1
            this.label1.Text = "Список абитуриентов:";
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Size = new System.Drawing.Size(200, 20);

            // listBoxAbits
            this.listBoxAbits.Location = new System.Drawing.Point(20, 30);
            this.listBoxAbits.Size = new System.Drawing.Size(250, 200);
            this.listBoxAbits.TabIndex = 0;

            // buttonAdd
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Location = new System.Drawing.Point(290, 30);
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // buttonChange
            this.buttonChange.Text = "Изменить";
            this.buttonChange.Location = new System.Drawing.Point(290, 70);
            this.buttonChange.Size = new System.Drawing.Size(100, 30);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);

            // buttonDel
            this.buttonDel.Text = "Удалить";
            this.buttonDel.Location = new System.Drawing.Point(290, 110);
            this.buttonDel.Size = new System.Drawing.Size(100, 30);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAbits);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDel);
            this.Text = "Абитуриенты";
            this.ResumeLayout(false);
        }
    }
}