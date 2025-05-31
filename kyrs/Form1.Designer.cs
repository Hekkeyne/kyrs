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
            textBox3 = new TextBox();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            импортДанныхToolStripMenuItem = new ToolStripMenuItem();
            испортToolStripMenuItem = new ToolStripMenuItem();
            экспортtxtToolStripMenuItem = new ToolStripMenuItem();
            создатьТаблицуToolStripMenuItem = new ToolStripMenuItem();
            зарандомитьТаблицуToolStripMenuItem = new ToolStripMenuItem();
            вычислитьДанныеToolStripMenuItem = new ToolStripMenuItem();
            очиститьДанныеToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(312, 68);
            button1.Name = "button1";
            button1.Size = new Size(108, 25);
            button1.TabIndex = 0;
            button1.Text = "Создать таблицу";
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
            label2.Size = new Size(296, 17);
            label2.TabIndex = 4;
            label2.Text = "Ведите количество экспертов и количество товаров";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(426, 68);
            button2.Name = "button2";
            button2.Size = new Size(162, 25);
            button2.TabIndex = 5;
            button2.Text = "Ввести случайные данные";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(22, 48);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 6;
            label3.Text = "Количество экспертов";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(22, 74);
            label4.Name = "label4";
            label4.Size = new Size(155, 17);
            label4.TabIndex = 7;
            label4.Text = "Количество инструментов";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 701);
            dataGridView1.TabIndex = 8;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(594, 68);
            button3.Name = "button3";
            button3.Size = new Size(122, 25);
            button3.TabIndex = 9;
            button3.Text = "Вычислить данные";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.AutoSize = true;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(1067, 97);
            textBox3.MaximumSize = new Size(788, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(367, 17);
            textBox3.TabIndex = 10;
            textBox3.Text = "Ответ недоступен, для начала нажмите кнопку 'Создать таблицу'";
            textBox3.ReadOnly = true;
            textBox3.Multiline = true;
            textBox3.ScrollBars = ScrollBars.Both;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(426, 40);
            button4.Name = "button4";
            button4.Size = new Size(245, 25);
            button4.TabIndex = 12;
            button4.Text = "Ввести случайные значения для таблицы";
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { импортДанныхToolStripMenuItem, создатьТаблицуToolStripMenuItem, зарандомитьТаблицуToolStripMenuItem, вычислитьДанныеToolStripMenuItem, очиститьДанныеToolStripMenuItem });
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
            испортToolStripMenuItem.Size = new Size(146, 22);
            испортToolStripMenuItem.Text = "Импорт";
            испортToolStripMenuItem.Click += импортToolStripMenuItem_Click;
            // 
            // экспортtxtToolStripMenuItem
            // 
            экспортtxtToolStripMenuItem.Name = "экспортtxtToolStripMenuItem";
            экспортtxtToolStripMenuItem.Size = new Size(146, 22);
            экспортtxtToolStripMenuItem.Text = "Экспорт (.txt)";
            экспортtxtToolStripMenuItem.Click += экспортtxtToolStripMenuItem_Click;
            // 
            // создатьТаблицуToolStripMenuItem
            // 
            создатьТаблицуToolStripMenuItem.Name = "создатьТаблицуToolStripMenuItem";
            создатьТаблицуToolStripMenuItem.Size = new Size(110, 20);
            создатьТаблицуToolStripMenuItem.Text = "Создать таблицу";
            создатьТаблицуToolStripMenuItem.Click += button1_Click;
            // 
            // зарандомитьТаблицуToolStripMenuItem
            // 
            зарандомитьТаблицуToolStripMenuItem.Name = "зарандомитьТаблицуToolStripMenuItem";
            зарандомитьТаблицуToolStripMenuItem.Size = new Size(140, 20);
            зарандомитьТаблицуToolStripMenuItem.Text = "Зарандомить таблицу";
            зарандомитьТаблицуToolStripMenuItem.Click += button4_Click;
            // 
            // вычислитьДанныеToolStripMenuItem
            // 
            вычислитьДанныеToolStripMenuItem.Name = "вычислитьДанныеToolStripMenuItem";
            вычислитьДанныеToolStripMenuItem.Size = new Size(124, 20);
            вычислитьДанныеToolStripMenuItem.Text = "Вычислить данные";
            вычислитьДанныеToolStripMenuItem.Click += button3_Click;
            // 
            // очиститьДанныеToolStripMenuItem
            // 
            очиститьДанныеToolStripMenuItem.Name = "очиститьДанныеToolStripMenuItem";
            очиститьДанныеToolStripMenuItem.Size = new Size(115, 20);
            очиститьДанныеToolStripMenuItem.Text = "Очистить данные";
            очиститьДанныеToolStripMenuItem.Click += очиститьДанныеToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1848, 814);
            Controls.Add(button4);
            Controls.Add(textBox3);
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
            Text = "Курсовая работа";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private TextBox textBox3;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem импортДанныхToolStripMenuItem;
        private ToolStripMenuItem испортToolStripMenuItem;
        private ToolStripMenuItem экспортtxtToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem создатьТаблицуToolStripMenuItem;
        private ToolStripMenuItem зарандомитьТаблицуToolStripMenuItem;
        private ToolStripMenuItem вычислитьДанныеToolStripMenuItem;
        private ToolStripMenuItem очиститьДанныеToolStripMenuItem;
    }
}
