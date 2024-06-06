namespace ProiectMDS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            SearchBox = new TextBox();
            SearchButton = new Button();
            AddButton = new Button();
            CarsPanel = new Panel();
            button6 = new Button();
            button5 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            EditButton = new Button();
            label3 = new Label();
            DeleteCarButton = new Button();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CarsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 599);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(209, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(961, 503);
            panel3.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.FlatAppearance.BorderColor = Color.Turquoise;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16.2F);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(0, 150);
            button2.Name = "button2";
            button2.Size = new Size(209, 62);
            button2.TabIndex = 1;
            button2.Text = "Users";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatAppearance.BorderColor = Color.Turquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 93);
            button1.Name = "button1";
            button1.Size = new Size(209, 61);
            button1.TabIndex = 0;
            button1.Text = "Cars";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(209, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 96);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(416, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 38);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 433);
            dataGridView1.TabIndex = 2;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(21, 36);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(346, 27);
            SearchBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(383, 35);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += button2_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(560, 37);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // CarsPanel
            // 
            CarsPanel.Controls.Add(label2);
            CarsPanel.Controls.Add(button5);
            CarsPanel.Controls.Add(button6);
            CarsPanel.Controls.Add(SearchBox);
            CarsPanel.Controls.Add(SearchButton);
            CarsPanel.Controls.Add(AddButton);
            CarsPanel.Controls.Add(dataGridView1);
            CarsPanel.Location = new Point(209, 96);
            CarsPanel.Name = "CarsPanel";
            CarsPanel.Size = new Size(967, 503);
            CarsPanel.TabIndex = 1;
            CarsPanel.Paint += panel4_Paint;
            // 
            // button6
            // 
            button6.Location = new Point(817, 35);
            button6.Name = "button6";
            button6.Size = new Size(94, 30);
            button6.TabIndex = 3;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(688, 34);
            button5.Name = "button5";
            button5.Size = new Size(94, 31);
            button5.TabIndex = 2;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 8);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 3;
            label2.Text = "Search cars:";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(383, 31);
            button3.Name = "button3";
            button3.Size = new Size(94, 31);
            button3.TabIndex = 0;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(501, 31);
            button4.Name = "button4";
            button4.Size = new Size(104, 31);
            button4.TabIndex = 1;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(688, 34);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 8;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(23, 8);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 4;
            label3.Text = "Search users:";
            label3.Click += label3_Click;
            // 
            // DeleteCarButton
            // 
            DeleteCarButton.Location = new Point(817, 33);
            DeleteCarButton.Name = "DeleteCarButton";
            DeleteCarButton.Size = new Size(94, 29);
            DeleteCarButton.TabIndex = 7;
            DeleteCarButton.Text = "Delete";
            DeleteCarButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 72);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(914, 431);
            dataGridView2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(DeleteCarButton);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(EditButton);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(917, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(961, 503);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1170, 599);
            Controls.Add(CarsPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CarsPanel.ResumeLayout(false);
            CarsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox SearchBox;
        private Button SearchButton;
        private Button AddButton;
        private Button button2;
        private Panel panel3;
        private Panel CarsPanel;
        private Button button6;
        private Panel panel4;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Button DeleteCarButton;
        private Label label3;
        private Button EditButton;
        private Button button4;
        private Button button3;
        private Label label2;
        private Button button5;
    }
}
