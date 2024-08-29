using AddOnIntercompany.Entities;
using AddOnIntercompany.Framework;
using AddOnIntercompany.Functionality;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Core
{
    public class Main
    {
        public Main()
        {
            DateTime StartSincro = new DateTime();
            try
            {
                Globals.RegistrarSource();
                Globals.InformationMessage("Obteniendo configuración de bases de datos.");
                Globals.GetConfig();
                Globals.ValidaConexiones();

                Setup.ValidaVersion();

                if (Globals.StartSincro.Year == 1)
                    Globals.StartSincro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00");

                StartSincro = DateTime.Now;

                //SocioNegocio.Migrar(Globals.MainConfig);
                //Articulo.Migrar(Globals.MainConfig);
                foreach (CONF conn in Globals.ListConfig)
                {
                    //OrdenVenta.Migrar(conn);
                    Pedido.Migrar(conn);
                    //Entrega.Migrar(conn);
                }
            }
            catch (Exception ex)
            {
                Globals.ErrorMessage(ex.Message);
            }
            finally
            {
                foreach (CONF item in Globals.ListConfig)
                    ServiceLayer.Logout(item);

                Globals.StartSincro = StartSincro;
            }
        }
    }
}
