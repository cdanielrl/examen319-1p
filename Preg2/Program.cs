namespace Preg2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
        public static decimal calcular(int operacion,decimal operando1,decimal operando2)
        {
            decimal resultado=0;
            switch (operacion)
            {
                case 1:
                    resultado = suma(operando1, operando2);
                    break;
                case 2:
                    resultado = resta(operando1, operando2);
                    break;
                case 3:
                    resultado = multiplicacion(operando1, operando2);
                    break;
                case 4:
                    if (operando2 != 0)
                    {
                        resultado = division(operando1, operando2);
                    }
                    break;
            }
            return resultado;
        }
        private static decimal suma(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        private static decimal resta(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        private static decimal multiplicacion(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        private static decimal division(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        internal static void actualizar(TextBox textBoxSalida,decimal salida)
        {
            textBoxSalida.Text = salida.ToString();
        }
    }
}