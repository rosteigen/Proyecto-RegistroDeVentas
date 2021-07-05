using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    class Botones
    {
        public static void Buttons(Panel pnl, Button btn)
        {
            string name = btn.Name;
            
            switch (name)
            {
                case "btnNuevo":

                    foreach (Button c in pnl.Controls)
                    {
                        if (((Button)c).Name == "btnNuevo")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnGuardar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnCancelar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnEliminar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnModificar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnGuardarCambios")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnBuscar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                    }
                    break;



                case "btnModificar":

                    foreach (Button c in pnl.Controls)
                    {
                        if (((Button)c).Name == "btnModificar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnGuardar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnCancelar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnEliminar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnNuevo")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnGuardarCambios")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnBuscar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                    }
                    break;

                case "btnGuardar":

                    foreach (Button c in pnl.Controls)
                    {

                        if (((Button)c).Name == "btnGuardar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnNuevo")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnModificar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnEliminar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnCancelar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnGuardarCambios")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnBuscar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                    }
                    break;

                case "btnCancelar":

                    foreach (Button c in pnl.Controls)
                    {
                        if (((Button)c).Name == "btnCancelar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnGuardar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnNuevo")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnEliminar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnModificar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnGuardarCambios")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnBuscar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                    }
                    break;

                case "btnGuardarCambios":

                    foreach (Button c in pnl.Controls)
                    {
                        if (((Button)c).Name == "btnCancelar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnGuardar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnNuevo")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnEliminar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnModificar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnGuardarCambios")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnBuscar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                    }
                    break;

                case "btnBuscar":

                    foreach (Button c in pnl.Controls)
                    {
                        if (((Button)c).Name == "btnNuevo")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnGuardar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnCancelar")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnEliminar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnModificar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                        if (((Button)c).Name == "btnGuardarCambios")
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).Visible = false;
                        }
                        if (((Button)c).Name == "btnBuscar")
                        {
                            ((Button)c).Enabled = true;
                            ((Button)c).Visible = true;
                        }
                    }
                    break;

                case "btnEliminar":

                    foreach (Button c in pnl.Controls)
                    {

                    }
                    break;

                
            }
        }
    }
}
