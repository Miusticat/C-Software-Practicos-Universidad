using System.IO;

namespace PracticaFinalPunto1
{
    internal class Pedido
    {
        public string Plato { get; set; }
        public int ValorPlato { get; set; }
        public int ValorBebida { get; set; }
        public bool ConPropina { get; set; }

        public Pedido(string plato, int valorPlato, int valorBebida, bool conPropina)
        {
            Plato = plato;
            ValorPlato = valorPlato;
            ValorBebida = valorBebida;
            ConPropina = conPropina;
        }

        public double CalcularIVA()
        {
            return (ValorPlato + ValorBebida) * 0.19;
        }

        public double CalcularPropina()
        {
            if (ConPropina)
                return (ValorPlato + ValorBebida) * 0.10;
            else
                return 0;
        }

        public double CalcularTotal()
        {
            return ValorPlato + ValorBebida + CalcularIVA() + CalcularPropina();
        }

        public string GenerarResumen()
        {
            return $"{Plato} | Bebida: ${ValorBebida} | Total: ${CalcularTotal():0.00}";
        }

        public void GuardarEnArchivo(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta, true))
            {
                sw.WriteLine(GenerarResumen());
            }
        }
    }
}

