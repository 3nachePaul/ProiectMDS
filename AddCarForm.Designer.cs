namespace ProiectMDS
{
    partial class AddCarForm
    {

        private TextBox AddCarNumberTB;
        private Button SaveCarButton;
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AddCarNumberTB = new TextBox();
            AddCarBrandTB = new TextBox();
            AddCarModelTB = new TextBox();
            AddCarColorTB = new TextBox();
            AddCarYearTB = new TextBox();
            SaveCarButton = new Button();
            CancelCarButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "CarNumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 99);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "CarBrand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 202);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "CarModel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 301);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "CarColor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 397);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 5;
            label6.Text = "CarYear";
            // 
            // AddCarNumberTB
            // 
            AddCarNumberTB.Location = new Point(36, 32);
            AddCarNumberTB.Name = "AddCarNumberTB";
            AddCarNumberTB.Size = new Size(249, 27);
            AddCarNumberTB.TabIndex = 7;
            // 
            // AddCarBrandTB
            // 
            AddCarBrandTB.Location = new Point(36, 122);
            AddCarBrandTB.Name = "AddCarBrandTB";
            AddCarBrandTB.Size = new Size(249, 27);
            AddCarBrandTB.TabIndex = 8;
            // 
            // AddCarModelTB
            // 
            AddCarModelTB.Location = new Point(36, 225);
            AddCarModelTB.Name = "AddCarModelTB";
            AddCarModelTB.Size = new Size(249, 27);
            AddCarModelTB.TabIndex = 9;
            // 
            // AddCarColorTB
            // 
            AddCarColorTB.Location = new Point(39, 324);
            AddCarColorTB.Name = "AddCarColorTB";
            AddCarColorTB.Size = new Size(246, 27);
            AddCarColorTB.TabIndex = 10;
            // 
            // AddCarYearTB
            // 
            AddCarYearTB.Location = new Point(36, 420);
            AddCarYearTB.Name = "AddCarYearTB";
            AddCarYearTB.Size = new Size(249, 27);
            AddCarYearTB.TabIndex = 11;
            // 
            // SaveCarButton
            // 
            SaveCarButton.Location = new Point(418, 211);
            SaveCarButton.Name = "SaveCarButton";
            SaveCarButton.Size = new Size(103, 55);
            SaveCarButton.TabIndex = 12;
            SaveCarButton.Text = "Save";
            SaveCarButton.UseVisualStyleBackColor = true;
            // 
            // CancelCarButton
            // 
            CancelCarButton.Location = new Point(604, 211);
            CancelCarButton.Name = "CancelCarButton";
            CancelCarButton.Size = new Size(103, 55);
            CancelCarButton.TabIndex = 13;
            CancelCarButton.Text = "Cancel";
            CancelCarButton.UseVisualStyleBackColor = true;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 459);
            Controls.Add(CancelCarButton);
            Controls.Add(SaveCarButton);
            Controls.Add(AddCarYearTB);
            Controls.Add(AddCarColorTB);
            Controls.Add(AddCarModelTB);
            Controls.Add(AddCarBrandTB);
            Controls.Add(AddCarNumberTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddCarForm";
            Text = "AddCarFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox AddCarBrandTB;
        private TextBox AddCarModelTB;
        private TextBox AddCarColorTB;
        private TextBox AddCarYearTB;
        private Button button1;
        private Button CancelCarButton;
    }
}