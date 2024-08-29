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
    public class Pedido
    {
        public static void Migrar(CONF origen)
        {
            try
            {
                var ContentList = ServiceLayer.Find<OPOR>(origen, new Tuple<string, string, string>("U_EXX_INDO_ESTADO", Globals.Operador.Igual, "PE"),
                                                                  new Tuple<string, string, string>("DocType", Globals.Operador.Igual, "dDocument_Items"));

                foreach (OPOR obj in ContentList)
                {
                    try
                    {
                        OPOR oOCompra = ServiceLayer.FindById<OPOR>(origen, obj);
                        ORDR oVenta = new ORDR();

                        var destino = Globals.ListConfig.FirstOrDefault(x => x.CodigoProveedor == oOCompra.CardCode.ToString());

                        if (!(destino == null))
                        {
                            var existe = ServiceLayer.Find<ORDR>(destino, new Tuple<string, string, string>("U_EXX_INDO_BASE", Globals.Operador.Igual, origen.BaseDeDatos),
                                                                          new Tuple<string, string, string>("U_EXX_INDO_DEOR", Globals.Operador.Igual, oOCompra.DocEntry.ToString()));
                            if (existe.Count == 0)
                            {
                                //Realiza todas las modificaciones necesarias
                                oOCompra.DocDate = Globals.ParseDateString(oOCompra.DocDate).ToString("yyyy-MM-dd");
                                oOCompra.DocDueDate = Globals.ParseDateString(oOCompra.DocDueDate).ToString("yyyy-MM-dd");
                                oOCompra.TaxDate = Globals.ParseDateString(oOCompra.TaxDate).ToString("yyyy-MM-dd");

                                oVenta = new ORDR
                                {
                                    DocType = oOCompra.DocType,
                                    CardCode = destino.CodigoCliente,
                                    DocDate = oOCompra.DocDate,
                                    DocDueDate = oOCompra.DocDueDate,
                                    TaxDate = oOCompra.TaxDate,
                                    DocCurrency = oOCompra.DocCurrency,
                                    BPL_IDAssignedToInvoice = oOCompra.BPL_IDAssignedToInvoice,
                                    AdditionalData = oOCompra.AdditionalData,
                                    DocumentLines = new List<OrderDocumentLine>()
                                };
                                oVenta.AdditionalData["U_EXX_INDO_ESTADO"] = "NA";
                                oVenta.AdditionalData["U_EXX_INDO_BASE"] = origen.BaseDeDatos;
                                oVenta.AdditionalData["U_EXX_INDO_DEOR"] = oOCompra.DocEntry.ToString();


                                oOCompra.DocumentLines.ForEach(x =>
                                {
                                    OITM item = new OITM();
                                    item.ItemCode = x.ItemCode;
                                    item = ServiceLayer.FindById<OITM>(destino, item);

                                    oVenta.DocumentLines.Add(new OrderDocumentLine
                                    {
                                        ItemType = x.ItemType,
                                        ItemCode = x.ItemCode,
                                        Quantity = Convert.ToDouble(x.Quantity),
                                        Price = x.Price,
                                        CostingCode = x.CostingCode,
                                        CostingCode2 = x.CostingCode2,
                                        CostingCode3 = x.CostingCode3,
                                        CostingCode4 = x.CostingCode4,
                                        CostingCode5 = x.CostingCode5,
                                        ProjectCode = x.ProjectCode,
                                        TaxCode = x.TaxCode,
                                        Currency = x.Currency,
                                        DiscountPercent = x.DiscountPercent,
                                        LineTotal = x.LineTotal,
                                        WarehouseCode = item.DefaultWarehouse,
                                        AdditionalDataDetail = x.AdditionalDataDetail
                                    });
                                });

                                ServiceLayer.Add<ORDR>(destino, oVenta);
                            }
                        }
                        //Actualiza estado
                        if (oOCompra.AdditionalData.ContainsKey("U_EXX_INDO_ESTADO"))
                            oOCompra.AdditionalData["U_EXX_INDO_ESTADO"] = "MI";

                        ServiceLayer.Update<OPOR>(origen, oOCompra);
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
