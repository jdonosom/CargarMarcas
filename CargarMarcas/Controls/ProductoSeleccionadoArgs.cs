using System;

namespace iFarmacia.Controls
{
    public class ProductoSeleccionadoArgs : EventArgs
    {
        public string IdProducto;
        public string Descripcion;
        public double StockTotal;
        public bool Afecto;
        public double Impuesto;

        public ProductoSeleccionadoArgs(string codigo, string descripcion, double stockTotal, bool afecto, double impuesto)
        {
            IdProducto = codigo;
            Descripcion = descripcion;
            StockTotal = stockTotal;
            Afecto = afecto;
            Impuesto = impuesto;


        }
    }

}