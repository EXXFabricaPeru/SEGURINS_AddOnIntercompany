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
    public class OrdenVenta
    {
        public static void Migrar(CONF origen)
        {
            try
            {
                var ContentList = ServiceLayer.Find<ORDR>(origen, new Tuple<string, string, string>("U_EXX_INDO_ESTADO", Globals.Operador.Igual, "PE")
                                                                , new Tuple<string, string, string>("DocType", Globals.Operador.Igual, "dDocument_Items"));

                foreach (ORDR obj in ContentList)
                {
                    try
                    {
                        ORDR oVenta = ServiceLayer.FindById<ORDR>(origen, obj);
                        OPOR oCompra = new OPOR();
                        oVenta.DocDate = Globals.ParseDateString(oVenta.DocDate).ToString("yyyy-MM-dd");
                        oVenta.DocDueDate = Globals.ParseDateString(oVenta.DocDueDate).ToString("yyyy-MM-dd");
                        oVenta.TaxDate = Globals.ParseDateString(oVenta.TaxDate).ToString("yyyy-MM-dd");


                        oCompra = new OPOR
                        {
                            DocType = oVenta.DocType,
                            DocDate = oVenta.DocDate,
                            BPL_IDAssignedToInvoice = oVenta.BPL_IDAssignedToInvoice,
                            DocDueDate = oVenta.DocDueDate,
                            TaxDate = oVenta.TaxDate,
                            DocCurrency = oVenta.DocCurrency,
                            AdditionalData = oVenta.AdditionalData,
                            DocumentLines = new List<PurchaseOrderDocumentLine>()
                        };
                        oCompra.AdditionalData["U_EXX_INDO_ESTADO"] = "PE";
                        oCompra.AdditionalData["U_EXX_INDO_BASE"] = origen.BaseDeDatos;
                        oCompra.AdditionalData["U_EXX_INDO_DEOR"] = oVenta.DocEntry.ToString();


                        oVenta.DocumentLines.ForEach(x =>
                        {
                            OITM item = new OITM();
                            item.ItemCode = x.ItemCode;
                            item = ServiceLayer.FindById<OITM>(origen, item);

                            if (!string.IsNullOrEmpty(item.AdditionalData["U_EXX_INDO_BASE"].ToString()))
                            {
                                if (item.AdditionalData["U_EXX_INDO_BASE"].ToString() != origen.BaseDeDatos && x.Quantity > item.QuantityOnStock)
                                {
                                    oCompra.DocumentLines.Add(new PurchaseOrderDocumentLine
                                    {
                                        ItemType = x.ItemType,
                                        ItemCode = x.ItemCode,
                                        Quantity = x.Quantity,
                                        Price = x.Price, //Obtener el porcetaje
                                        CostingCode = x.CostingCode,
                                        CostingCode2 = x.CostingCode2,
                                        CostingCode3 = x.CostingCode3,
                                        CostingCode4 = x.CostingCode4,
                                        CostingCode5 = x.CostingCode5,
                                        ProjectCode = x.ProjectCode,
                                        TaxCode = x.TaxCode,
                                        Currency = x.Currency,
                                        BDDestino = item.AdditionalData["U_EXX_INDO_BASE"].ToString(),
                                        AdditionalDataDetail = x.AdditionalDataDetail
                                    });
                                }
                            }
                        });

                        if (oCompra.DocumentLines.Count > 0)
                        {
                            foreach (string basedato in oCompra.DocumentLines.Distinct().Select(x => x.BDDestino).ToList())
                            {
                                var Destino = Globals.ListConfig.FirstOrDefault(x => x.BaseDeDatos == basedato);

                                if (Destino != null)
                                {
                                    OPOR oCompraAux = oCompra;
                                    oCompraAux.CardCode = Destino.CodigoProveedor;
                                    oCompraAux.DocumentLines = oCompraAux.DocumentLines.Where(x => x.BDDestino == Destino.BaseDeDatos).ToList();
                                    oCompraAux.DocumentLines.ForEach(x => x.BDDestino = null);
                                    ServiceLayer.Add<OPOR>(origen, oCompraAux);
                                }
                            }
                        }

                        //Actualiza estado
                        if (oVenta.AdditionalData.ContainsKey("U_EXX_INDO_ESTADO"))
                            oVenta.AdditionalData["U_EXX_INDO_ESTADO"] = "MI";

                        ServiceLayer.Update<ORDR>(origen, oVenta);
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


