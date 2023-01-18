using System.Windows.Forms;

namespace Calculadora
{
    public static class Memoria
    {
        public static double memoria;
    }
    public class Calcular
    {
        public Calcular Soma(TextBox txt)
        {
            double numero = double.Parse(txt.Text);
            Memoria.memoria += numero;
            txt.Text = $"{Memoria.memoria}";
            return this;
        }
        public Calcular Sub(TextBox txt)
        {
            double numero = double.Parse(txt.Text);
            Memoria.memoria -= numero;
            txt.Text = $"{Memoria.memoria}";
            return this;
        }
        public Calcular Mult(TextBox txt)
        {
            double numero = double.Parse(txt.Text);
            Memoria.memoria *= numero;
            txt.Text = $"{Memoria.memoria}";
            return this;
        }
        public Calcular Div(TextBox txt)
        {
            double numero = double.Parse(txt.Text);
            Memoria.memoria /= numero;
            txt.Text = $"{Memoria.memoria}";
            return this;
        }
    }
    public static class Comandos
    {
        public static void Numeros(TextBox txt, double numero)
        {
            if (txt.Text == "0")
            {
                txt.Text += $"{numero}";
            }
            else
            {
                txt.Text += numero;
            }
        }
        public static void Operacao(TextBox txt, Label lbl, string operacao)
        {
            Memoria.memoria = double.Parse(txt.Text);
            txt.Text = "";
            lbl.Text = $"{operacao}";
        }
    }
}
