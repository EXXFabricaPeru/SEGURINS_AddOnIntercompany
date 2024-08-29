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
    public class SocioNegocio
    {
        public static void Migrar(Entities.CONF origen)
        {
            try
            {
                var ContentList = ServiceLayer.Find<OCRD>(origen, new Tuple<string, string, string>("CreateDate", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("yyyy-MM-dd"))
                                                                , new Tuple<string, string, string>("CreateTime", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("HHmmss")));

                ContentList.AddRange(ServiceLayer.Find<OCRD>(origen, new Tuple<string, string, string>("UpdateDate", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("yyyy-MM-dd"))
                                                                    , new Tuple<string, string, string>("UpdateTime", Globals.Operador.MayorIgual, Globals.StartSincro.ToString("HHmmss"))));

                ContentList = ContentList.Distinct().ToList();
                if (ContentList.Count == 0) return;

                foreach (CONF destino in Globals.ListConfig.Where(x => x.BaseDeDatos != origen.BaseDeDatos && x.MigraSocio))
                {
                    Globals.InformationMessage("Iniciando migración de socios de negocio.");
                    foreach (OCRD obj in ContentList)
                    {
                        try
                        {
                            OCRD oSocioORI = ServiceLayer.FindById<OCRD>(origen, obj);
                            //Realiza todas las modificaciones necesarias


                            OCRD existe = ServiceLayer.FindById<OCRD>(destino, obj);
                            if (existe == null)
                            {
                                Globals.CleanJson<OCRD>(ref oSocioORI);
                                Globals.OnlyURI = true;
                                ServiceLayer.Add<OCRD>(destino, oSocioORI);
                                Globals.SuccessMessage($"{destino.BaseDeDatos}: Socio de negocio creado con código: " + obj.CardCode);
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
                                    Globals.CleanJson<OCRD>(ref oSocioORI);
                                    ServiceLayer.Update<OCRD>(destino, oSocioORI);
                                    Globals.SuccessMessage($"{destino.BaseDeDatos}: Socio de negocio actualizado con código: " + obj.CardCode);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Globals.ErrorMessage($"{ destino.BaseDeDatos }: {ex.Message}");
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
