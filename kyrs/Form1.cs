﻿using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace kyrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Ведите количество экспертов и количество товаров";
            button1.Text = "Создать таблицу"; 
            button2.Text = "Ввести случайные данные";
            label3.Text = "Количество экспертов";
            label4.Text = "Количество инструментов";
            button3.Visible = false;
            button4.Visible = false;
            label1.Text = "Ответ недоступен, для начала нажмите кнопку 'Создать таблицу'";
            dataGridView1.Visible = false;
            label5.Text = "Ошибки отсутствуют";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 101);
            textBox1.Text = x.ToString();
            x = rnd.Next(1, 101);
            textBox2.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {
                dataGridView1.Visible = true;
                button3.Text = "Вычислить данные";
                button3.Visible = true;
                label1.Text = "Ответ недоступен, нажмите кнопку 'Вычислить данные'";
                button4.Visible = true;
                button4.Text = "Зарандомить таблицу";
                int experts = int.Parse(textBox1.Text);
                int tovar = int.Parse(textBox2.Text);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("", "/");
                for (int i = 0; i < tovar; i++)
                {
                    dataGridView1.Columns.Add("", $"Товар {1 + i}"); 
                }
                for (int i = 0; i < experts; i++)
                {
                    dataGridView1.Rows.Add($"Эксперт {i + 1}", "");
                    Random f = new Random();
                    for (int j = 1; j < tovar + 1; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = f.Next(0, 101);
                    }
                    label5.Text = "Ошибки отсутствуют";

                }
            }
            catch
            {
                if (!int.TryParse(textBox1.Text, out _) && !int.TryParse(textBox2.Text, out _))
                {
                    label5.Text = "Ошибка поля 'Эксперты' и поля 'Инструменты'. Введите допустимое значения экспертов и инструментов";
                }
                else if (!int.TryParse(textBox1.Text, out _))
                {
                    label5.Text = $@"Ошибка поля 'Эксперты'. Введите допустимое значение экспертов";
                }
                else if (!int.TryParse(textBox2.Text, out _))
                {
                    label5.Text = @$"Ошибка поля 'Инструменты'. Введите допустимое значение инструментов";
                }
                else { label5.Text = "Неизвестная ошибка"; }
                button3.Visible = false;
                button4.Visible = false;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Visible = false;

            }
        }
        private void button3_Click(object sender, EventArgs e) 
        {
            try
            {
                double y = 0;
                int experts = int.Parse(textBox1.Text);
                int tovar = int.Parse(textBox2.Text);
                List<double> ans1 = new List<double>();
                for (int i = 1; i < tovar + 1; i++)
                {
                    for (int j = 0; j < experts; j++)
                    {
                        y += double.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                    }
                    ans1.Add(y);
                    y = 0;
                }
                double min = ans1[0];
                double max = ans1[0];
                int maxi = 0;
                int mini = 0;
                for (int i = 1; i < ans1.Count; i++)
                {
                    if (ans1[i] < min)
                    {
                        min = ans1[i];
                        mini = i;
                    }
                    if (ans1[i] > max)
                    {
                        max = ans1[i];
                        maxi = i;
                    }
                }
                label1.Text = @$"1)
Наихудший товар {mini + 1} с суммарной оценкой {min} 
Наилучший товар {maxi + 1} с суммарной оценкой {max} 
";
                double maxex = double.Parse(dataGridView1.Rows[0].Cells[maxi + 1].Value.ToString());
                double maxexi = 1;
                for (int j = 1; j < experts + 1; j++) 
                {
                    if (maxex < double.Parse(dataGridView1.Rows[j - 1].Cells[maxi + 1].Value.ToString()))
                    {
                        maxex = double.Parse(dataGridView1.Rows[j - 1].Cells[maxi + 1].Value.ToString());
                        maxexi = j;
                    }
                }
                label1.Text += @$"2)
Наивысший балл {maxex} поставил эксперт {maxexi} товару {maxi + 1}
3)
";
                double x = 0;
                double[] anss = new double[ans1.Count];
                for (int i = 0; i < ans1.Count; i++)
                {
                    anss[i] = i + 1;
                }
                for (int i = 0; i < ans1.Count - 1; i++)
                {
                    for (int j = 0; j < ans1.Count - 1 - i; j++)
                    {
                        if (ans1[j] < ans1[j + 1])
                        {
                            x = ans1[j];
                            ans1[j] = ans1[j + 1];
                            ans1[j + 1] = x;
                            x = anss[j];
                            anss[j] = anss[j + 1];
                            anss[j + 1] = x;
                        }
                    }
                }
                for (int i = 0; i < ans1.Count; i++)
                {
                    label1.Text += $@"Товар {anss[i]}, Общая оценка {ans1[i]}
";
                }
            }
            catch
            {
                label5.Text = @$"Ошибка 'Вычислить данные'. Попробуйте заполнить все другими данными или нажать 'Создать таблицу'";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int experts = int.Parse(textBox1.Text);
            int tovar = int.Parse(textBox2.Text);
            for (int i = 0; i < experts; i++)
            {
                Random f = new Random();
                for (int j = 1; j < tovar + 1; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = f.Next(1, 101);
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void импортToolStripMenuItem_Click(object sender, EventArgs e)

        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Visible = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader h = new StreamReader(openFileDialog1.FileName))

                    {
                        List<string[]> fff = new List<string[]>();
                        dataGridView1.Columns.Clear();
                        dataGridView1.Rows.Clear();
                        int stolb = 0;
                        int strok = 0;
                        string z;
                        while ((z = h.ReadLine()) != null)
                        {
                            string[] g = z.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
                            fff.Add(g);
                            strok++;
                            stolb = g.Length;
                        }
                        dataGridView1.Columns.Add("", "/");
                        for (int i = 0; i < stolb; i++)
                        {
                            dataGridView1.Columns.Add("", $"Товар {1 + i}");
                        }
                        for (int i = 0; i < strok; i++)
                        {
                            dataGridView1.Rows.Add($"Эксперт {i + 1}");
                            for (int j = 0; j < fff[i].Length; j++)
                            {
                                dataGridView1.Rows[i].Cells[j + 1].Value = fff[i][j];
                            }
                        }
                        textBox1.Text = stolb.ToString();
                        textBox2.Text = strok.ToString();
                        dataGridView1.Visible = true;
                        button3.Text = "Вычислить данные";
                        button3.Visible = true;
                        label1.Text = "Ответ недоступен, нажмите кнопку 'Вычислить данные'";
                        button4.Visible = true;
                        button4.Text = "Зарандомить таблицу";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка открытия файла");
            }
        }

        private void импортДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
