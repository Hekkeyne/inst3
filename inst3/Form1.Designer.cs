namespace inst3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            dataGridView3 = new DataGridView();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += tb_kp;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.KeyDown += tb_kp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(83, 45);
            label1.TabIndex = 2;
            label1.Text = "Критерий\r\n\r\nАльтернатива";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(335, 164);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellValueChanged += cvchg;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView_CurrentCellDirtyStateChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(353, 102);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(335, 164);
            dataGridView2.TabIndex = 4;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(353, 69);
            button1.Name = "button1";
            button1.Size = new Size(37, 25);
            button1.TabIndex = 5;
            button1.Text = "тык";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 272);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.Size = new Size(335, 164);
            dataGridView3.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(386, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            textBox3.KeyDown += tb_kp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 274);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 8;
            label2.Text = "Z(1)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 303);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "U(1)";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(386, 300);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            textBox4.KeyDown += tb_kp;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(353, 329);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(335, 107);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 466);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(dataGridView3);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private DataGridView dataGridView3;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
