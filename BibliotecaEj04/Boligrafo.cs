using System;
using System.Text;

namespace BibliotecaEj04
{
    public class Boligrafo
    {
        const short cantidadMaximaTinta = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor colorElegido, short tintaInicial)
        {
            this.color = colorElegido;
            this.tinta = tintaInicial;       
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta (short tinta)
        {
            short resultante;
            resultante = this.tinta -= tinta;
            if (resultante <= cantidadMaximaTinta && resultante >= 0)
            {
                this.tinta= resultante;
            }
        }
        public void Recargar()
        {
            this.tinta = cantidadMaximaTinta;
        }
        public void Pintar(short gasto, out string dibujo)
        {
            Console.ForegroundColor = this.color;
            StringBuilder texto = new StringBuilder("");
            for (int i = 0; i < gasto; i++)
            {
                if (this.tinta > 0)
                {
                    SetTinta(1);
                    texto.Append("*");
                }
                else
                {
                    break;
                }
             
            }
            dibujo = texto.ToString();
        }
         
    }
}
