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
    public class Articulo
    {
        public static void Migrar(Entities.CONF origen)
        {
            try
            {
                var ContentList = ServiceLayer.Find<OITM>(origen, new Tuple<string, string, string>("CreateDate", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("yyyy-MM-dd"))
                                                                , new Tuple<string, string, string>("CreateTime", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("HHmmss"))
                                                                , new Tuple<string, string, string>("InventoryItem", Globals.Operador.Igual, "Y")
                                                                , new Tuple<string, string, string>("QuantityOnStock", Globals.Operador.Mayor, "0")
                                                                , new Tuple<string, string, string>("SalesItem", Globals.Operador.Igual, "Y"));

                ContentList.AddRange(ServiceLayer.Find<OITM>(origen, new Tuple<string, string, string>("UpdateDate", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("yyyy-MM-dd"))
                                                                    , new Tuple<string, string, string>("UpdateTime", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("HHmmss"))
                                                                    , new Tuple<string, string, string>("InventoryItem", Globals.Operador.Igual, "Y")
                                                                    , new Tuple<string, string, string>("QuantityOnStock", Globals.Operador.Mayor, "0")
                                                                    , new Tuple<string, string, string>("SalesItem", Globals.Operador.Igual, "Y")
                                                                            ));
                ContentList = ContentList.Distinct().ToList();

                if (ContentList.Count == 0) return;
                foreach (CONF destino in Globals.ListConfig.Where(x => x.BaseDeDatos != origen.BaseDeDatos && x.MigraArticulo))
                {
                    Globals.InformationMessage("Iniciando migración de artículos.");
                    foreach (OITM obj in ContentList)
                    {
                        try
                        {
                            OITM oItem = ServiceLayer.FindById<OITM>(origen, obj);
                            //Realiza todas las modificaciones necesarias

                            OITM existe = ServiceLayer.FindById<OITM>(destino, obj);
                            if (existe == null)
                            {
                                Globals.CleanJson<OITM>(ref oItem);
                                Globals.OnlyURI = true;
                                ServiceLayer.Add<OITM>(destino, oItem);
                                Globals.SuccessMessage("Artículo creado con código: " + obj.ItemCode);
                            }
                            else
                            {
                                bool bActualizar = false;
                                if (existe.UpdateDate == null || DateTime.Parse(existe.UpdateDate) <= DateTime.Parse(obj.UpdateDate))
                                    bActualizar = true;
                                else if (DateTime.Parse(existe.UpdateDate) == DateTime.Parse(obj.UpdateDate)
                                         && Int32.Parse(existe.UpdateTime) < Int32.Parse(obj.UpdateTime))
                                    bActualizar = true;

                                if (bActualizar)
                                {
                                    Globals.CleanJson<OITM>(ref oItem);
                                    ServiceLayer.Update<OITM>(destino, oItem);
                                    Globals.SuccessMessage("Artículo actualizado con código: " + obj.ItemCode);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Globals.ErrorMessage($"{destino.BaseDeDatos}:{ ex.Message}");
                        }
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
