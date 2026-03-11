namespace AbiturientApp
{
    partial class DialogForm
    {
        private System.ComponentModel.IContainer components = null;

        // Поля ввода - делаем public, чтобы были доступны из Form1
        public System.Windows.Forms.TextBox Familia_TB;
        public System.Windows.Forms.TextBox Shkola_TB;
        public System.Windows.Forms.TextBox Shifr_TB;
        public System.Windows.Forms.TextBox Balli_TB;

        private System.Windows.Forms.Button Ok_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogForm));
            Familia_TB = new TextBox();
            Shkola_TB = new TextBox();
            Shifr_TB = new TextBox();
            Balli_TB = new TextBox();
            Ok_B = new Button();
            Cancel_B = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Familia_TB
            // 
            Familia_TB.Location = new Point(169, 134);
            Familia_TB.Multiline = true;
            Familia_TB.Name = "Familia_TB";
            Familia_TB.Size = new Size(200, 45);
            Familia_TB.TabIndex = 1;
            Familia_TB.TextAlign = HorizontalAlignment.Center;
            // 
            // Shkola_TB
            // 
            Shkola_TB.Location = new Point(169, 185);
            Shkola_TB.Multiline = true;
            Shkola_TB.Name = "Shkola_TB";
            Shkola_TB.Size = new Size(200, 45);
            Shkola_TB.TabIndex = 3;
            Shkola_TB.TextAlign = HorizontalAlignment.Center;
            // 
            // Shifr_TB
            // 
            Shifr_TB.Location = new Point(169, 236);
            Shifr_TB.Multiline = true;
            Shifr_TB.Name = "Shifr_TB";
            Shifr_TB.Size = new Size(200, 45);
            Shifr_TB.TabIndex = 5;
            Shifr_TB.TextAlign = HorizontalAlignment.Center;
            // 
            // Balli_TB
            // 
            Balli_TB.Location = new Point(169, 287);
            Balli_TB.Multiline = true;
            Balli_TB.Name = "Balli_TB";
            Balli_TB.Size = new Size(200, 45);
            Balli_TB.TabIndex = 7;
            Balli_TB.TextAlign = HorizontalAlignment.Center;
            // 
            // Ok_B
            // 
            Ok_B.DialogResult = DialogResult.OK;
            Ok_B.Location = new Point(33, 346);
            Ok_B.Name = "Ok_B";
            Ok_B.Size = new Size(130, 53);
            Ok_B.TabIndex = 8;
            Ok_B.Text = "OK";
            // 
            // Cancel_B
            // 
            Cancel_B.DialogResult = DialogResult.Cancel;
            Cancel_B.Location = new Point(169, 338);
            Cancel_B.Name = "Cancel_B";
            Cancel_B.Size = new Size(200, 61);
            Cancel_B.TabIndex = 9;
            Cancel_B.Text = "Отмена";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(33, 134);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(130, 45);
            label1.TabIndex = 0;
            label1.Text = "Фамилия:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(33, 185);
            label2.Name = "label2";
            label2.Size = new Size(130, 45);
            label2.TabIndex = 2;
            label2.Text = "Школа (1-200):";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(33, 236);
            label3.Name = "label3";
            label3.Size = new Size(130, 45);
            label3.TabIndex = 4;
            label3.Text = "Шифр (1-300):";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(33, 287);
            label4.Name = "label4";
            label4.Size = new Size(130, 45);
            label4.TabIndex = 6;
            label4.Text = "Баллы (0-20):";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DialogForm
            // 
            AcceptButton = Ok_B;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = Cancel_B;
            ClientSize = new Size(423, 516);
            Controls.Add(label1);
            Controls.Add(Familia_TB);
            Controls.Add(label2);
            Controls.Add(Shkola_TB);
            Controls.Add(label3);
            Controls.Add(Shifr_TB);
            Controls.Add(label4);
            Controls.Add(Balli_TB);
            Controls.Add(Ok_B);
            Controls.Add(Cancel_B);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogForm";
            Text = "Ввод данных";
            FormClosing += DialogForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}