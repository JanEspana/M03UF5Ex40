using System.Text.RegularExpressions;

namespace M03UF5Ex40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calc_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Introduce un nombre y todas las notas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                average.Text = ((double.Parse(textBox2.Text) + double.Parse(textBox3.Text) + double.Parse(textBox4.Text) + double.Parse(textBox5.Text)) / 4).ToString();

                double[] notas = { double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text) };
                lowestGrade.Text = notas.Min().ToString();
                if (double.Parse(average.Text) >= 5)
                {
                    condition.Text = "Aprobado";
                }
                else
                {
                    condition.Text = "Suspendido";
                }
            }
        }

        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void clean_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            average.Text = "";
            lowestGrade.Text = "";
            condition.Text = "";
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex num = new Regex(@"^[0-9]+(\,[0-9]+)?$");

            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Introduce una nota");
                e.Cancel = true;
            }
            else if (!num.IsMatch(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Introduce un número");
                e.Cancel = true;
            }
            else if (double.Parse(textBox2.Text) < 0 || double.Parse(textBox2.Text) > 10)
            {
                errorProvider1.SetError(textBox2, "Introduce un número entre 0 y 10");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
                e.Cancel = false;
            }
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex num = new Regex(@"^[0-9]+(\,[0-9]+)?$");

            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Introduce una nota");
                e.Cancel = true;
            }
            else if (!num.IsMatch(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Introduce un número");
                e.Cancel = true;
            }
            else if (double.Parse(textBox3.Text) < 0 || double.Parse(textBox3.Text) > 10)
            {
                errorProvider1.SetError(textBox3, "Introduce un número entre 0 y 10");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
                e.Cancel = false;
            }
        }

        private void textBox4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex num = new Regex(@"^[0-9]+(\,[0-9]+)?$");

            if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Introduce una nota");
                e.Cancel = true;
            }
            else if (!num.IsMatch(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Introduce un número");
                e.Cancel = true;
            }
            else if (double.Parse(textBox4.Text) < 0 || double.Parse(textBox4.Text) > 10)
            {
                errorProvider1.SetError(textBox4, "Introduce un número entre 0 y 10");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
                e.Cancel = false;
            }
        }

        private void textBox5_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex num = new Regex(@"^[0-9]+(\,[0-9]+)?$");

            if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Introduce una nota");
                e.Cancel = true;
            }
            else if (!num.IsMatch(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Introduce un número");
                e.Cancel = true;
            }
            else if (double.Parse(textBox5.Text) < 0 || double.Parse(textBox5.Text) > 10)
            {
                errorProvider1.SetError(textBox5, "Introduce un número entre 0 y 10");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
                e.Cancel = false;
            }
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Introduce un nombre");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                e.Cancel = false;
            }
        }
    }
}
