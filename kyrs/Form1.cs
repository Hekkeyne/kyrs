using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace kyrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//����� � ��������, ���� ��� ���� ���� ���� � form1 designer
            label2.Text = "������ ���������� ��������� � ���������� �������";
            button1.Text = "������� �������"; // ���. ����
            button2.Text = "������ ��������� ������";
            label3.Text = "���������� ���������";
            label4.Text = "���������� ������������";
            button3.Visible = false;
            button4.Visible = false;
            label1.Text = "����� ����������, ��� ������ ������� ������ '������� �������'";
            button5.Text = "����� exel ����� (wip)";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 101);
            int y = rnd.Next(1, 101);
            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();
            //����� ������ ��� 2� ������
        }
        private void button1_Click(object sender, EventArgs e) // ������-�� ���� ���� ������� ������ � try �� ������ 3 � 4 ��-����� ����������
        {
            try
            {
                button3.Text = "��������� ������";
                button3.Visible = true;
                label1.Text = "����� ����������, ������� ������ '��������� ������'";
                button4.Visible = true;
                button4.Text = "����������� �������";
                int experts = int.Parse(textBox1.Text);
                int tovar = int.Parse(textBox2.Text);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("", "/");
                for (int i = 0; i < tovar; i++)
                {
                    dataGridView1.Columns.Add("", $"����� {1 + i}"); // �������� ������ � �������� �� i-1 �������
                }
                for (int i = 0; i < experts; i++)
                {
                    dataGridView1.Rows.Add();
                    Random f = new Random();
                    dataGridView1.Rows[i].Cells[0].Value = $"������� {i + 1}";// ������ ������� � ����������
                    for (int j = 1; j < tovar + 1; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = f.Next(0, 101);//� ����� ��� �������� �������. ������ ��. 0 ������� � ���� ����� ����������, ���������� �������� ��������� � j=1 �������
                    }

                }
            }
            catch// <31> ����� catch ��� ���������� �� �������
            {
                label1.Text = @$"������ button1_Click
���������� ������ �� ������������ �����������";
                button3.Visible = false;
                button4.Visible = false;
            }
        }
        private void button3_Click(object sender, EventArgs e) // ���� ������ ������ 2, ����� 3 ��� ������ 1, �� ����� ������ �� 78 ������, ��� ���� ����������
        {
            try
            {
                double y = 0;
                int experts = int.Parse(textBox1.Text);
                int tovar = int.Parse(textBox2.Text);
                List<double> ans1 = new List<double>();// ������������ �������� �� ������
                for (int i = 1; i < tovar+1 ; i++)// �� 1 �� tovara �� 0 ������� - �����)))
                {
                    for (int j = 0; j < experts; j++)
                    {
                        y += double.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());//������� �� ��������
                    }
                    ans1.Add(y);
                    y = 0;
                }
                double min = ans1[0];
                double max = ans1[0];
                int maxi = 0;
                int mini = 0;
                for (int i = 1; i < ans1.Count; i++)// ��� ������������ ������ � ������ �����
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
��������� ����� {mini + 1} � ��������� ������� {min} 
��������� ����� {maxi + 1} � ��������� ������� {max} 
";
                double maxex = double.Parse(dataGridView1.Rows[0].Cells[maxi + 1].Value.ToString());
                double maxexi = 1;
                for (int j = 1; j < experts + 1; j++) // �������� j � 1 ���� ���� ����� ���������� ��������� �� ������, � ����� ���������� ����� � ��������� (((
                {
                    if (maxex < double.Parse(dataGridView1.Rows[j - 1].Cells[maxi + 1].Value.ToString()))
                    {
                        maxex = double.Parse(dataGridView1.Rows[j - 1].Cells[maxi + 1].Value.ToString());
                        maxexi = j;
                    }
                }
                label1.Text += @$"2)
��������� ���� {maxex} �������� ������� {maxexi} ������ {maxi + 1}
3)
";
                double x = 0;
                double[] anss = new double[ans1.Count];
                for (int i = 0; i < ans1.Count; i++)//�������� ������ � �������� ������� 
                {
                    anss[i] = i + 1;
                }
                for (int i = 0; i < ans1.Count - 1; i++)//����������� ����������, ������ � ���� ������
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
                            anss[j+1] = x;
                        }//������ �������� ����� ������ � ����� ������
                    }
                }
                for (int i = 0 ; i < ans1.Count; i++)
                {
                    label1.Text += $@"����� {anss[i]}, ����� ������ {ans1[i]}
";// ��� ����� ��� ������ ������� �� ������
                }
            }
            catch
            {
                label1.Text = @$"������ button3_Click
���������� ��������� ��� ������� ������� ��� ������ '������� �������'";
            }
        }
        private void button4_Click(object sender, EventArgs e)//����������� �������, ���� ����� �� ������ 2
        {
            int experts = int.Parse(textBox1.Text);
            int tovar = int.Parse(textBox2.Text);
            for (int i = 0; i < experts; i++)
            {

                Random f = new Random();
                var dd = new DataGridViewRow();
                dd.CreateCells(dataGridView1);
                for (int j = 1; j < tovar + 1; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = f.Next(1, 101);
                }
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
    }
}
