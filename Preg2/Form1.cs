using System.Windows.Forms;

namespace Preg2
{
    public partial class Form1 : Form
    {
        // 1 suma
        // 2 resta
        // 3 multiplicacion
        // 4 division
        private static int operacion = 0;
        
        private static decimal operando1;
        private static decimal operando2;
        private static decimal entrada;
        private decimal Entrada
        {
            get => entrada;
            set { entrada = value;
                Program.actualizar(textBoxSalida,entrada);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Entrada = 0;
            operacion = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Entrada = entrada * 10 + 9;
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            if (operacion==0)
            {
                operacion = 1;
                operando1 = entrada;
                Entrada = 0;
            } 
            else
            {
                operando2 = entrada;
                Entrada = Program.calcular(operacion, operando1, operando2);
                operando1 = entrada;
                operacion = 1;
            }
        }
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                operacion = 2;
                operando1 = entrada;
                Entrada = 0;
            }
            else
            {
                operando2 = entrada;
                Entrada = Program.calcular(operacion, operando1, operando2);
                operando1 = entrada;
                operacion = 2;
            }
        }
        private void buttonPor_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                operacion = 3;
                operando1 = entrada;
                Entrada = 0;
            }
            else
            {
                operando2 = entrada;
                Entrada = Program.calcular(operacion, operando1, operando2);
                operando1 = entrada;
                operacion = 3;
            }
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
            {
                operacion = 4;
                operando1 = entrada;
                Entrada = 0;
            }
            else
            {
                operando2 = entrada;
                Entrada = Program.calcular(operacion,operando1,operando2);
                operando1 = entrada;
                operacion = 4;
            }
        }
        private void buttonIgual_Click(object sender,EventArgs e)
        {
            operando2 = entrada;
            Entrada = Program.calcular(operacion, operando1, operando2);
            operacion = 0;
        }
        private void buttonClear_Click(object sender,EventArgs e)
        {
            Entrada = 0;
            operacion = 0;
        }
    }
}