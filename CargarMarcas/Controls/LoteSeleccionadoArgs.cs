using System;

namespace iFarmacia.Controls
{
    public class LoteSeleccionadoArgs : EventArgs
    {
        public string serie;
        public double stockLote;
        public double precio;
        public DateTime vencimiento;

        public LoteSeleccionadoArgs(string serie, double stockLote, double precio, DateTime vencimiento)
        {
            this.serie = serie;
            this.stockLote = stockLote;
            this.precio = precio;
            this.vencimiento = vencimiento;
        }
    }
}