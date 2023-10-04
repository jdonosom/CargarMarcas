using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarMarcas.Controls
{
    public class Ce_Label : Label
    {
        public Ce_Label()
        {
            this.Font = new Font("Consolas", 10f, FontStyle.Bold);
            this.ForeColor = Color.FromArgb(133, 62, 254);
            this.BackColor = Color.Transparent;
        }
    }
}
