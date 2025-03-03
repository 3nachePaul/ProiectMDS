namespace ProiectMDS
{
    partial class AddUsrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTB = new TextBox();
            PrenumeTB = new TextBox();
            TelefonTB = new TextBox();
            MailTB = new TextBox();
            CarIDTB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 83);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Prenume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 167);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "NrTelefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 248);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 339);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "CarID";
            // 
            // NameTB
            // 
            NameTB.Location = new Point(69, 32);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(229, 27);
            NameTB.TabIndex = 5;
            // 
            // PrenumeTB
            // 
            PrenumeTB.Location = new Point(69, 106);
            PrenumeTB.Name = "PrenumeTB";
            PrenumeTB.Size = new Size(229, 27);
            PrenumeTB.TabIndex = 6;
            // 
            // TelefonTB
            // 
            TelefonTB.Location = new Point(69, 190);
            TelefonTB.Name = "TelefonTB";
            TelefonTB.Size = new Size(229, 27);
            TelefonTB.TabIndex = 7;
            // 
            // MailTB
            // 
            MailTB.Location = new Point(69, 271);
            MailTB.Name = "MailTB";
            MailTB.Size = new Size(229, 27);
            MailTB.TabIndex = 8;
            // 
            // CarIDTB
            // 
            CarIDTB.Location = new Point(69, 362);
            CarIDTB.Name = "CarIDTB";
            CarIDTB.Size = new Size(229, 27);
            CarIDTB.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(424, 190);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(587, 190);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddUsrForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CarIDTB);
            Controls.Add(MailTB);
            Controls.Add(TelefonTB);
            Controls.Add(PrenumeTB);
            Controls.Add(NameTB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUsrForm";
            Text = "AddUsrForm";
            Load += AddUsrForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTB;
        private TextBox PrenumeTB;
        private TextBox TelefonTB;
        private TextBox MailTB;
        private TextBox CarIDTB;
        private Button button1;
        private Button button2;
    }
}