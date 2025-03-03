namespace ProiectMDS
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

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
            UsrNameBox = new TextBox();
            UsrPassBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UsrLogButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // UsrNameBox
            // 
            UsrNameBox.Location = new Point(251, 140);
            UsrNameBox.Name = "UsrNameBox";
            UsrNameBox.Size = new Size(371, 27);
            UsrNameBox.TabIndex = 0;
            // 
            // UsrPassBox
            // 
            UsrPassBox.Location = new Point(251, 234);
            UsrPassBox.Name = "UsrPassBox";
            UsrPassBox.Size = new Size(371, 27);
            UsrPassBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 143);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 2;
            label1.Text = "Nume utilizator:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 241);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Parola utilizator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 36);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 4;
            label3.Text = "BINE ATI VENIT!";
            label3.Click += label3_Click;
            // 
            // UsrLogButton
            // 
            UsrLogButton.Location = new Point(284, 355);
            UsrLogButton.Name = "UsrLogButton";
            UsrLogButton.Size = new Size(94, 29);
            UsrLogButton.TabIndex = 5;
            UsrLogButton.Text = "Login";
            UsrLogButton.UseVisualStyleBackColor = true;
            UsrLogButton.Click += UsrLogButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(455, 355);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(UsrLogButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsrPassBox);
            Controls.Add(UsrNameBox);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsrNameBox;
        private TextBox UsrPassBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button UsrLogButton;
        private Button button1;
    }
}