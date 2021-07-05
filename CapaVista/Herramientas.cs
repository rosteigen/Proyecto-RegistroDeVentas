using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    class Herramientas
    {
        #region METODOS
        public static void Deshabilitar(GroupBox gbox)
        {
            foreach (Control C in gbox.Controls)
            {
                if (C is TextBox | C is ComboBox)
                {
                    C.Enabled = false;
                }
                if (C is Button)
                {
                    C.Enabled = false;
                    C.Visible = false;
                }
            }
        }

        public static void Habilitar(GroupBox gbox)
        {
            foreach (Control C in gbox.Controls)
            {
                if (C is TextBox | C is ComboBox)
                {
                    C.Enabled = true;
                }
                if (C is Button)
                {
                    C.Enabled = true;
                    C.Visible = true;
                }
            }
        }

        public static void Limpiar(GroupBox gbox)
        {
            foreach (Control C in gbox.Controls)
            {
                if (C is TextBox | C is ComboBox)
                {
                    C.Text = "";
                }
            }
        }

       
        #endregion
    }
}
