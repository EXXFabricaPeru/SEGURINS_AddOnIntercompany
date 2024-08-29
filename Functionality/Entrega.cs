using AddOnIntercompany.Core;
using AddOnIntercompany.Entities;
using AddOnIntercompany.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Functionality
{
    public class Entrega
    {
        public static void Migrar(CONF origen)
        {
            try
            {
                var ContentList = ServiceLayer.Find<ODLN>(origen, new Tuple<string, string, string>("U_EXX_INDO_ESTADO", Globals.Operador.Igual, "PE"),
                                                                  new Tuple<string, string, string>("DocType", Globals.Operador.Igual, "dDocument_Items"));

                foreach (ODLN obj in ContentList)
                {
                    try
                    {
                        ODLN oDelivery = ServiceLayer.FindById<ODLN>(origen, obj);
                        oDelivery.DocumentLines.ForEach(x =>
                        {
                            OITM item = new OITM();
                            item.ItemCode = x.ItemCode;
                            var oItem = ((OITM)ServiceLayer.FindById<OITM>(origen, item));
                            if (x.Quantity > oItem.QuantityOnStock)
                            {

                                string Destino = oItem.AdditionalData.Where(kvp => kvp.Key == "U_EXX_INDO_BASE")
                                                                    .Select(kvp => kvp.Value)
                                                                    .FirstOrDefault().ToString();
                                if (!string.IsNullOrEmpty(Destino))
                                {
                                    if (Destino != origen.BaseDeDatos)
                                        x.BDDestino = Destino;
                                }
                            }
                        });

                        List<string> destinos = oDelivery.DocumentLines.Select(x => x.BDDestino).Where(y => y != null).Distinct().ToList();
                        if (destinos.Count > 0)
                        {
                            foreach (var destino in Globals.ListConfig.Where(item => destinos.Contains(item.BaseDeDatos)).ToList())
                            {
                                var existe = ServiceLayer.Find<ODLN>(origen, new Tuple<string, string, string>("U_EXX_INDO_DEOR", Globals.Operador.Igual, oDelivery.DocEntry.ToString()));
                                if (existe.Count == 0)
                                {
                                    //Realiza todas las modificaciones necesarias

                                    Globals.OnlyURI = true;
                                    ServiceLayer.Add<ODLN>(destino, oDelivery);
                                }
                            }

                            //Actualiza estado
                            if (oDelivery.AdditionalData.ContainsKey("U_EXX_INDO_ESTADO"))
                                oDelivery.AdditionalData["U_EXX_INDO_ESTADO"] = "MI";

                            ServiceLayer.Update<ODLN>(origen, oDelivery);
                        }
                    }
                    catch (Exception ex)
                    {
                        Globals.ErrorMessage(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Globals.ErrorMessage(ex.Message);
            }
        }
    }
}
