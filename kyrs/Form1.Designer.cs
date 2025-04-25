using System.Windows.Forms;

namespace kyrs
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            импортДанныхToolStripMenuItem = new ToolStripMenuItem();
            испортToolStripMenuItem = new ToolStripMenuItem();
            экспортtxtToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(312, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(22, 25);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(431, 68);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(22, 48);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(22, 74);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1136, 701);
            dataGridView1.TabIndex = 8;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(629, 68);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(1360, 97);
            label1.MaximumSize = new Size(788, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(774, 68);
            button4.Name = "button4";
            button4.Size = new Size(75, 25);
            button4.TabIndex = 12;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.RestoreDirectory = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(466, 49);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { импортДанныхToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1848, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // импортДанныхToolStripMenuItem
            // 
            импортДанныхToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { испортToolStripMenuItem, экспортtxtToolStripMenuItem });
            импортДанныхToolStripMenuItem.Name = "импортДанныхToolStripMenuItem";
            импортДанныхToolStripMenuItem.Size = new Size(120, 20);
            импортДанныхToolStripMenuItem.Text = "Работа с данными";
            // 
            // испортToolStripMenuItem
            // 
            испортToolStripMenuItem.Name = "испортToolStripMenuItem";
            испортToolStripMenuItem.Size = new Size(180, 22);
            испортToolStripMenuItem.Text = "Импорт";
            испортToolStripMenuItem.Click += импортToolStripMenuItem_Click;
            // 
            // экспортtxtToolStripMenuItem
            // 
            экспортtxtToolStripMenuItem.Name = "экспортtxtToolStripMenuItem";
            экспортtxtToolStripMenuItem.Size = new Size(180, 22);
            экспортtxtToolStripMenuItem.Text = "Экспорт (.txt)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1848, 814);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "d";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label1;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem импортДанныхToolStripMenuItem;
        private ToolStripMenuItem испортToolStripMenuItem;
        private ToolStripMenuItem экспортtxtToolStripMenuItem;
    }
}
