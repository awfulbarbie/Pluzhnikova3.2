namespace lab3._3_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void f(double x, double a, double b, double c, out double y)
        {
            y = 0;
            if (x < 93)
            {
                y = a + b * x;
            }
            else if (x >= 93 && x <= 120)
            {
                y = b - a * c;
            }
            else if (x > 120)
            {
                y = a * b * x;
            }
            else
            {
                MessageBox.Show("Ошибка!", "Ошибка",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                y = 0;
            }
        }
        static double f(double x, double a, double b, double c)
        {
            double y;
            if (x < 93)
            {
                y = a + b * x;
            }
            else if (x >= 93 && x <= 120)
            {
                y = b - a * c;
            }
            else if (x > 120)
            {
                y = a * b * x;
            }
            else
            {
                MessageBox.Show("Ошибка!", "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                y = 0;
            }
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                double a, b, h, c;
                if (numericUpDown1.Value > numericUpDown2.Value)
                {
                    MessageBox.Show("Начало диапозона не может быть больше конца диапозона",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
                else if (numericUpDown4.Value <= 0)
                {
                    MessageBox.Show("Шаг не может быть отрицательным или равным 0. Повторите попытку.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                a = (double)numericUpDown1.Value;
                b = (double)numericUpDown2.Value;
                h = (double)numericUpDown4.Value;
                c = (double)numericUpDown3.Value;


                for (double i = a; i <= b; i += h)
                {
                    listBox1.Items.Add ($"f({i:f2}) = {f(i, a, b, c):f4}" + Environment.NewLine);
                }

                for (double i = a; i <= b; i += h)
                {
                    f(i, a, b, c, out double y);
                    listBox2.Items.Add ($"f({i:f2}) = {f(i, a, b, c):f4}" + Environment.NewLine);
                }
            }
            }
    }
}