using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFarmacia.Controls
{
    public partial class ucDateTimeText : UserControl
    {

        private bool lshow = false;
        private string m_sysUIFormat = CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern;

        public ucDateTimeText()
        {
            InitializeComponent();

            monthCalendar1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!lshow)
                monthCalendar1.Show();
            else
                monthCalendar1.Hide();
        }



    }
}
