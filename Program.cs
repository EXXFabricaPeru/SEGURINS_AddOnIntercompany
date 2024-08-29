using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        //static void Main()
        //{
        //    ServiceBase[] ServicesToRun;
        //    ServicesToRun = new ServiceBase[]
        //    {
        //        new ServiceSincro()
        //    };
        //    ServiceBase.Run(ServicesToRun);
        //}

        static void Main(string[] args)
        {
            Core.Main oApp;
            try
            {
                oApp = new Core.Main();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
