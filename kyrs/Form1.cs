using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;

namespace kyrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Resize += (s, e) => UpdateControlsPosition();
            dataGridView1.SizeChanged += (s, e) => UpdateLabelPosition();
            MinimumSize = new Size(button3.Right + 20, button3.Bottom + 20);
            button3.Visible = false;
            button4.Visible = false;
            зарандомитьТаблицуToolStripMenuItem.Visible = false;
            вычислитьДанныеToolStripMenuItem.Visible = false;
        }
        private void UpdateControlsPosition()
        {
            dataGridView1.Size = new Size(
                ClientSize.Width - dataGridView1.Left - 20-textBox3.Width,
                ClientSize.Height - dataGridView1.Top - 20
            );
            UpdateLabelPosition();
        }
        private void UpdateLabelPosition()
        {
            textBox3.Location = new Point(
                dataGridView1.Right + 10,  
                dataGridView1.Top
            );
            textBox3.Size = new Size(
                (ClientSize.Width-dataGridView1.Left-20)/3,
                ClientSize.Height-dataGridView1.Top-20
                );
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            Random rnd = new Random();
            int x = rnd.Next(1, 101);
            textBox1.Text = x.ToString();
            x = rnd.Next(1, 101);
            textBox2.Text = x.ToString();
            button1_Click(sender, e);
            button4_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                зарандомитьТаблицуToolStripMenuItem.Visible = true;
                вычислитьДанныеToolStripMenuItem.Visible = true;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                dataGridView1.Visible = true;
                button3.Visible = true;
                textBox3.Text = "Ответ недоступен, нажмите кнопку 'Вычислить данные'";
                button4.Visible = true;
                int experts = int.Parse(textBox1.Text);
                int tovar = int.Parse(textBox2.Text);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("Column0", "/");
                for (int i = 0; i < tovar; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.HeaderText = "Товар " + (i + 1); 
                    column.ValueType = typeof(decimal);
                    dataGridView1.Columns.Add(column);
                }
                for (int i = 0; i < experts; i++)
                {
                    dataGridView1.Rows.Add($"Эксперт {i + 1}", "");
                    dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                    for (int j = 1; j < tovar + 1; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "";
                        if (dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Red)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }
                }
            }
            catch
            {
                if (!int.TryParse(textBox1.Text, out _) && !int.TryParse(textBox2.Text, out _))
                {
                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                }
                else if (!int.TryParse(textBox1.Text, out _))
                {
                    textBox1.BackColor = Color.Red;
                }
                else if (!int.TryParse(textBox2.Text, out _))
                {
                    textBox2.BackColor = Color.Red;
                }
                button3.Visible = false;
                button4.Visible = false;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
     
                зарандомитьТаблицуToolStripMenuItem.Visible = false;
                вычислитьДанныеToolStripMenuItem.Visible = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int y = 0;
                int experts = int.Parse(textBox1.Text);
                int tovar = int.Parse(textBox2.Text);
                List<double> ans1 = new List<double>();
                for (int i = 1; i < tovar + 1; i++)
                {
                    for (int j = 0; j < experts; j++)
                    {
                        try
                        {
                            if (int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString()) > 100)
                            {
                                dataGridView1.Rows[j].Cells[i].Value = dataGridView1.Rows[j].Cells[i].Value + ">100";
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                y += int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                                if (dataGridView1.Rows[j].Cells[i].Style.BackColor == Color.Red)
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
                                }
                            }
                        }
                        catch
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Red;
                        }
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
                textBox3.Text = @$"1)
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
                textBox3.Text += @$"2)
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
                    textBox3.Text += $@"Товар {anss[i]}, Общая оценка {ans1[i]}
";
                }
            }
            catch
            {
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
                    if (dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Red)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }
        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                зарандомитьТаблицуToolStripMenuItem.Visible = true;
                вычислитьДанныеToolStripMenuItem.Visible = true;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Visible = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader h = new StreamReader(openFileDialog1.FileName))
                    {
                        List<string[]> fff = new List<string[]>();
                        int stolb = 0;
                        int strok = 0;
                        string z;
                        while ((z = h.ReadLine()) != null)
                        {
                            string[] g = z.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
                            fff.Add(g);
                            strok++;
                            if (g.Length > stolb)
                            {
                                stolb = g.Length;
                            }
                        }
                        dataGridView1.Columns.Clear();
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Add("", "/");
                        for (int i = 0; i < stolb; i++)
                        {
                            dataGridView1.Columns.Add("", $"Товар {1 + i}");
                        }
                        for (int i = 0; i < strok; i++)
                        {
                            dataGridView1.Rows.Add($"Эксперт {i + 1}", "");
                            dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                            for (int j = 0; j < (fff[i].Length); j++)
                            {
                                dataGridView1.Rows[i].Cells[j + 1].Value = fff[i][j];
                                if (dataGridView1.Rows[i].Cells[j + 1].Style.BackColor == Color.Red)
                                {
                                    dataGridView1.Rows[i].Cells[j + 1].Style.BackColor = Color.White;
                                }
                            }
                        }
                        textBox2.Text = stolb.ToString();
                        textBox1.Text = strok.ToString();
                        dataGridView1.Visible = true;
                        button3.Text = "Вычислить данные";
                        button3.Visible = true;
                        textBox3.Text = "Ответ недоступен, нажмите кнопку 'Вычислить данные'";
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
        private void экспортtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text files|*.txt";
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        string g = "";
                        string fn = saveFileDialog1.FileName;
                        int a = int.Parse(textBox1.Text);
                        int b = int.Parse(textBox2.Text);
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 1; j <= b; j++)
                            {
                                g = g + (dataGridView1.Rows[i].Cells[j].Value) + " ";
                            }
                            sw.WriteLine(g);
                            g = "";
                        }
                        MessageBox.Show($"Файл сохранён в {fn}");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла");
            }
        }

        private void очиститьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "Ответ недоступен, для начала нажмите кнопку 'Создать таблицу'";
            button3.Visible = false;
            button4.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            зарандомитьТаблицуToolStripMenuItem.Visible = false;
            вычислитьДанныеToolStripMenuItem.Visible = false;
        }

    }
}
