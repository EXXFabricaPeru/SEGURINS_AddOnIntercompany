using AddOnIntercompany.Entities;
using AddOnIntercompany.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Core
{
    public class Setup
    {
        public static void ValidaVersion()
        {
            try
            {
                foreach (CONF conn in Globals.ListConfig)
                {
                    CreateQueries(conn);
                    var SetupList = ServiceLayer.Find<SETUP>(conn);
                    var setup = SetupList.FirstOrDefault(x => x.U_EXX_ADDN == Assembly.GetEntryAssembly().GetName().Name);
                    Version actual = new Version(Assembly.GetEntryAssembly().GetName().Version.ToString());

                    if (setup == null)
                    {
                        Globals.InformationMessage($"Iniciando creación de metadata en {conn.BaseDeDatos}.");

                        //Realizar la creación de campos 
                        CreateTables(conn);
                        CreateFields(conn);
                        CreateUDOs(conn);
                        AddData<BASE>(conn);

                        string Code = Convert.ToInt32(SetupList.Max(x => Convert.ToInt32(x.Code)) + 1).ToString().PadLeft(2, '0');
                        setup = new SETUP
                        {
                            Code = Code,
                            Name = Code,
                            U_EXX_ADDN = Assembly.GetEntryAssembly().GetName().Name,
                            U_EXX_VERS = Assembly.GetEntryAssembly().GetName().Version.ToString()
                        };

                        if (Globals.SuccessInstall)
                        {
                            Globals.OnlyURI = true;
                            ServiceLayer.Add<SETUP>(conn, setup);
                            Globals.InformationMessage($"Instalación finalizada en {conn.BaseDeDatos}.");

                        }
                    }
                    else
                    {
                        Version configurado = new Version(setup.U_EXX_VERS);
                        int comparison = actual.CompareTo(configurado);

                        if (comparison > 0)
                        {
                            Globals.InformationMessage($"Iniciando actualización de metadata en {conn.BaseDeDatos}.");

                            //Realizar la creación de campos 
                            CreateTables(conn);
                            CreateFields(conn);
                            CreateUDOs(conn);
                            AddData<BASE>(conn);

                            if (Globals.SuccessInstall)
                            {
                                setup.U_EXX_VERS = actual.ToString();
                                ServiceLayer.Update<SETUP>(conn, setup);
                                Globals.InformationMessage($"Actualización finalizada en {conn.BaseDeDatos}.");
                            }
                        }
                        else if (comparison < 0)
                        {
                            throw new Exception("La versión del servicio que se está ejecutando es inferior a la versión configurada en SAP.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateQueries(CONF conn)
        {
            try
            {
                var ContentList = Globals.ReadJson<OQRY>("Queries.json");
                foreach (OQRY query in ContentList)
                {
                    var existe = ServiceLayer.FindById<OQRY>(conn, query);
                    if (existe == null)
                    {
                        Globals.OnlyURI = true;
                        ServiceLayer.Add<OQRY>(conn, query);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateTables(CONF conn)
        {
            try
            {
                var ContentList = Globals.ReadJson<OUTB>("Tables.json");
                foreach (OUTB table in ContentList)
                {
                    var existe = ServiceLayer.FindById<OUTB>(conn, table);
                    if (existe == null)
                    {
                        Globals.OnlyURI = true;
                        ServiceLayer.Add<OUTB>(conn, table);
                        Globals.InformationMessage($"{table.TableName}: creado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateFields(CONF conn)
        {
            try
            {
                var ContentList = Globals.ReadJson<CUFD>("Fields.json");
                foreach (CUFD field in ContentList)
                {
                    var existe = ServiceLayer.FindById<CUFD>(conn, field);
                    if (existe == null)
                    {
                        Globals.OnlyURI = true;
                        ServiceLayer.Add<CUFD>(conn, field);
                        Globals.InformationMessage($"{field.Name}: creado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateUDOs(CONF conn)
        {
            try
            {
                var ContentList = Globals.ReadJson<OUDO>("UDOs.json");
                foreach (OUDO udo in ContentList)
                {
                    var existe = ServiceLayer.FindById<OUDO>(conn, udo);
                    if (existe == null)
                    {
                        Globals.OnlyURI = true;
                        ServiceLayer.Add<OUDO>(conn, udo);
                        Globals.InformationMessage($"{udo.Name}: creado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void AddData<T>(CONF conn, string FileName = null) where T : class, new()
        {
            try
            {
                var type = typeof(T);
                var entityAttribute = (SAPEntityNameAttribute)Attribute.GetCustomAttribute(type, typeof(SAPEntityNameAttribute));
                switch (entityAttribute.Uri)
                {
                    case "U_EXX_INDO_BASE":
                        //Agrega la lista de bases de datos que tiene el config
                        List<BASE> oBaseList = new List<BASE>();
                        Globals.ListConfig.ForEach(x =>
                        {
                            oBaseList.Add(new BASE
                            {
                                Code = x.BaseDeDatos,
                                Name = x.NombreSociedad,
                                EXX_INDO_PROV = x.CodigoProveedor,
                                EXX_INDO_CLIE = x.CodigoCliente
                            });
                        });

                        foreach (var item in oBaseList)
                        {
                            Globals.OnlyURI = true;
                            ServiceLayer.Add<BASE>(conn, item);
                        }
                        break;
                    default:
                        //Agregar lectura por json para las siguientes tablas
                        var ContentList = Globals.ReadJson<T>(FileName);
                        foreach (var item in ContentList)
                        {
                            Globals.OnlyURI = true;
                            ServiceLayer.Add<T>(conn, item);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
