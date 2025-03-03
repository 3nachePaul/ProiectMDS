namespace ProiectMDS
{
    partial class EditCarForm
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
            CarNumberTextBox = new TextBox();
            BrandTextBox = new TextBox();
            ModelTextBox = new TextBox();
            ColorTextBox = new TextBox();
            YearTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SaveButton = new Button();
            CancelEdit = new Button();
            SuspendLayout();
            // 
            // CarNumberTextBox
            // 
            CarNumberTextBox.Location = new Point(60, 53);
            CarNumberTextBox.Name = "CarNumberTextBox";
            CarNumberTextBox.Size = new Size(219, 27);
            CarNumberTextBox.TabIndex = 0;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(60, 134);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(219, 27);
            BrandTextBox.TabIndex = 1;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(60, 216);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(219, 27);
            ModelTextBox.TabIndex = 2;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(60, 301);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(219, 27);
            ColorTextBox.TabIndex = 3;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(60, 386);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(219, 27);
            YearTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "CarNumber";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 111);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "CarBrand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 193);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "CarModel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 278);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "CarColor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 363);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 9;
            label5.Text = "CarYear";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(412, 214);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelEdit
            // 
            CancelEdit.Location = new Point(600, 216);
            CancelEdit.Name = "CancelEdit";
            CancelEdit.Size = new Size(94, 29);
            CancelEdit.TabIndex = 11;
            CancelEdit.Text = "Cancel";
            CancelEdit.UseVisualStyleBackColor = true;
            // 
            // EditCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelEdit);
            Controls.Add(SaveButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(YearTextBox);
            Controls.Add(ColorTextBox);
            Controls.Add(ModelTextBox);
            Controls.Add(BrandTextBox);
            Controls.Add(CarNumberTextBox);
            Name = "EditCarForm";
            Text = "EditCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CarNumberTextBox;
        private TextBox BrandTextBox;
        private TextBox ModelTextBox;
        private TextBox ColorTextBox;
        private TextBox YearTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button SaveButton;
        private Button CancelEdit;
    }
}