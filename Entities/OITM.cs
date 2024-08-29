using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Entities
{
    [SAPEntityName("Items")]
    public class OITM
    {
        [JsonProperty("ItemCode"), SAPKey] public string ItemCode { get; set; }

        [JsonProperty("ItemName")] public string ItemName { get; set; }

        [JsonProperty("ForeignName")] public string ForeignName { get; set; }

        [JsonProperty("ItemsGroupCode")] public int ItemsGroupCode { get; set; }

        [JsonProperty("CustomsGroupCode")] public int CustomsGroupCode { get; set; }

        [JsonProperty("SalesVATGroup")] public string SalesVATGroup { get; set; }

        [JsonProperty("BarCode")] public string BarCode { get; set; }

        [JsonProperty("VatLiable")] public string VatLiable { get; set; }

        [JsonProperty("PurchaseItem")] public string PurchaseItem { get; set; }

        [JsonProperty("SalesItem")] public string SalesItem { get; set; }

        [JsonProperty("InventoryItem")] public string InventoryItem { get; set; }

        [JsonProperty("IncomeAccount")] public string IncomeAccount { get; set; }

        [JsonProperty("ExemptIncomeAccount")] public string ExemptIncomeAccount { get; set; }

        [JsonProperty("ExpanseAccount")] public string ExpanseAccount { get; set; }

        [JsonProperty("Mainsupplier")] public string Mainsupplier { get; set; }

        [JsonProperty("SupplierCatalogNo")] public string SupplierCatalogNo { get; set; }

        [JsonProperty("DesiredInventory")] public double DesiredInventory { get; set; }

        [JsonProperty("MinInventory")] public double MinInventory { get; set; }

        [JsonProperty("Picture")] public string Picture { get; set; }

        [JsonProperty("User_Text")] public string UserText { get; set; }

        [JsonProperty("SerialNum")] public string SerialNum { get; set; }

        [JsonProperty("CommissionPercent")] public double CommissionPercent { get; set; }

        [JsonProperty("CommissionSum")] public double CommissionSum { get; set; }

        [JsonProperty("CommissionGroup")] public int CommissionGroup { get; set; }

        [JsonProperty("TreeType")] public string TreeType { get; set; }

        [JsonProperty("AssetItem")] public string AssetItem { get; set; }

        [JsonProperty("DataExportCode")] public string DataExportCode { get; set; }

        [JsonProperty("Manufacturer")] public int Manufacturer { get; set; }

        [JsonProperty("QuantityOnStock")] public double QuantityOnStock { get; set; }

        [JsonProperty("QuantityOrderedFromVendors")] public double QuantityOrderedFromVendors { get; set; }

        [JsonProperty("QuantityOrderedByCustomers")] public double QuantityOrderedByCustomers { get; set; }

        [JsonProperty("ManageSerialNumbers")] public string ManageSerialNumbers { get; set; }

        [JsonProperty("ManageBatchNumbers")] public string ManageBatchNumbers { get; set; }

        [JsonProperty("Valid")] public string Valid { get; set; }

        [JsonProperty("ValidFrom")] public string ValidFrom { get; set; }

        [JsonProperty("ValidTo")] public string ValidTo { get; set; }

        [JsonProperty("ValidRemarks")] public string ValidRemarks { get; set; }

        [JsonProperty("Frozen")] public string Frozen { get; set; }

        [JsonProperty("FrozenFrom")] public string FrozenFrom { get; set; }

        [JsonProperty("FrozenTo")] public string FrozenTo { get; set; }

        [JsonProperty("FrozenRemarks")] public string FrozenRemarks { get; set; }

        [JsonProperty("SalesUnit")] public string SalesUnit { get; set; }

        [JsonProperty("SalesItemsPerUnit")] public double SalesItemsPerUnit { get; set; }

        [JsonProperty("SalesPackagingUnit")] public string SalesPackagingUnit { get; set; }

        [JsonProperty("SalesQtyPerPackUnit")] public double SalesQtyPerPackUnit { get; set; }

        [JsonProperty("SalesUnitLength")] public double? SalesUnitLength { get; set; }

        [JsonProperty("SalesLengthUnit")] public double? SalesLengthUnit { get; set; }

        [JsonProperty("SalesUnitWidth")] public double? SalesUnitWidth { get; set; }

        [JsonProperty("SalesWidthUnit")] public double? SalesWidthUnit { get; set; }

        [JsonProperty("SalesUnitHeight")] public double? SalesUnitHeight { get; set; }

        [JsonProperty("SalesHeightUnit")] public double? SalesHeightUnit { get; set; }

        [JsonProperty("SalesUnitVolume")] public double? SalesUnitVolume { get; set; }

        [JsonProperty("SalesVolumeUnit")] private double? SalesVolumeUnit { get; set; }

        [JsonProperty("SalesUnitWeight")] public double? SalesUnitWeight { get; set; }

        [JsonProperty("SalesWeightUnit")] public double? SalesWeightUnit { get; set; }

        [JsonProperty("PurchaseUnit")] public string PurchaseUnit { get; set; }

        [JsonProperty("PurchaseItemsPerUnit")] public double PurchaseItemsPerUnit { get; set; }

        [JsonProperty("PurchasePackagingUnit")] public string PurchasePackagingUnit { get; set; }

        [JsonProperty("PurchaseQtyPerPackUnit")] public double PurchaseQtyPerPackUnit { get; set; }

        [JsonProperty("PurchaseUnitLength")] public double? PurchaseUnitLength { get; set; }

        [JsonProperty("PurchaseLengthUnit")] public double? PurchaseLengthUnit { get; set; }

        [JsonProperty("PurchaseUnitWidth")] public double? PurchaseUnitWidth { get; set; }

        [JsonProperty("PurchaseWidthUnit")] public double? PurchaseWidthUnit { get; set; }

        [JsonProperty("PurchaseUnitHeight")] public double? PurchaseUnitHeight { get; set; }

        [JsonProperty("PurchaseHeightUnit")] public double? PurchaseHeightUnit { get; set; }

        [JsonProperty("PurchaseUnitVolume")] public double? PurchaseUnitVolume { get; set; }

        [JsonProperty("PurchaseVolumeUnit")] private double? PurchaseVolumeUnit { get; set; }

        [JsonProperty("PurchaseUnitWeight")] public double? PurchaseUnitWeight { get; set; }

        [JsonProperty("PurchaseWeightUnit")] public double? PurchaseWeightUnit { get; set; }

        [JsonProperty("PurchaseVATGroup")] public string PurchaseVATGroup { get; set; }

        [JsonProperty("SalesFactor1")] public double SalesFactor1 { get; set; }

        [JsonProperty("SalesFactor2")] public double SalesFactor2 { get; set; }

        [JsonProperty("SalesFactor3")] public double SalesFactor3 { get; set; }

        [JsonProperty("SalesFactor4")] public double SalesFactor4 { get; set; }

        [JsonProperty("PurchaseFactor1")] public double PurchaseFactor1 { get; set; }

        [JsonProperty("PurchaseFactor2")] public double PurchaseFactor2 { get; set; }

        [JsonProperty("PurchaseFactor3")] public double PurchaseFactor3 { get; set; }

        [JsonProperty("PurchaseFactor4")] public double PurchaseFactor4 { get; set; }

        [JsonProperty("MovingAveragePrice")] public double MovingAveragePrice { get; set; }

        [JsonProperty("ForeignRevenuesAccount")] public string ForeignRevenuesAccount { get; set; }

        [JsonProperty("ECRevenuesAccount")] public string ECRevenuesAccount { get; set; }

        [JsonProperty("ForeignExpensesAccount")] public string ForeignExpensesAccount { get; set; }

        [JsonProperty("ECExpensesAccount")] public string ECExpensesAccount { get; set; }

        [JsonProperty("AvgStdPrice")] public double AvgStdPrice { get; set; }

        [JsonProperty("DefaultWarehouse")] public string DefaultWarehouse { get; set; }

        [JsonProperty("ShipType")] public string ShipType { get; set; }

        [JsonProperty("GLMethod")] public string GLMethod { get; set; }

        [JsonProperty("TaxType")] public string TaxType { get; set; }

        [JsonProperty("MaxInventory")] public double MaxInventory { get; set; }

        [JsonProperty("ManageStockByWarehouse")] public string ManageStockByWarehouse { get; set; }

        [JsonProperty("PurchaseHeightUnit1")] public double? PurchaseHeightUnit1 { get; set; }

        [JsonProperty("PurchaseUnitHeight1")] public double? PurchaseUnitHeight1 { get; set; }

        [JsonProperty("PurchaseLengthUnit1")] public double? PurchaseLengthUnit1 { get; set; }

        [JsonProperty("PurchaseUnitLength1")] public double? PurchaseUnitLength1 { get; set; }

        [JsonProperty("PurchaseWeightUnit1")] public double? PurchaseWeightUnit1 { get; set; }

        [JsonProperty("PurchaseUnitWeight1")] public double? PurchaseUnitWeight1 { get; set; }

        [JsonProperty("PurchaseWidthUnit1")] public double? PurchaseWidthUnit1 { get; set; }

        [JsonProperty("PurchaseUnitWidth1")] public double? PurchaseUnitWidth1 { get; set; }

        [JsonProperty("SalesHeightUnit1")] public double? SalesHeightUnit1 { get; set; }

        [JsonProperty("SalesUnitHeight1")] public double? SalesUnitHeight1 { get; set; }

        [JsonProperty("SalesLengthUnit1")] public double? SalesLengthUnit1 { get; set; }

        [JsonProperty("SalesUnitLength1")] public double? SalesUnitLength1 { get; set; }

        [JsonProperty("SalesWeightUnit1")] public double? SalesWeightUnit1 { get; set; }

        [JsonProperty("SalesUnitWeight1")] public double? SalesUnitWeight1 { get; set; }

        [JsonProperty("SalesWidthUnit1")] public double? SalesWidthUnit1 { get; set; }

        [JsonProperty("SalesUnitWidth1")] public double? SalesUnitWidth1 { get; set; }

        [JsonProperty("ForceSelectionOfSerialNumber")] public string ForceSelectionOfSerialNumber { get; set; }

        [JsonProperty("ManageSerialNumbersOnReleaseOnly")] public string ManageSerialNumbersOnReleaseOnly { get; set; }

        [JsonProperty("WTLiable")] public string WTLiable { get; set; }

        [JsonProperty("CostAccountingMethod")] public string CostAccountingMethod { get; set; }

        [JsonProperty("SWW")] public string SWW { get; set; }

        [JsonProperty("WarrantyTemplate")] public string WarrantyTemplate { get; set; }

        [JsonProperty("IndirectTax")] public string IndirectTax { get; set; }

        [JsonProperty("ArTaxCode")] public string ArTaxCode { get; set; }

        [JsonProperty("ApTaxCode")] public string ApTaxCode { get; set; }

        [JsonProperty("BaseUnitName")] public string BaseUnitName { get; set; }

        [JsonProperty("ItemCountryOrg")] public string ItemCountryOrg { get; set; }

        [JsonProperty("IssueMethod")] public string IssueMethod { get; set; }

        [JsonProperty("SRIAndBatchManageMethod")] public string SRIAndBatchManageMethod { get; set; }

        [JsonProperty("IsPhantom")] public string IsPhantom { get; set; }

        [JsonProperty("InventoryUOM")] public string InventoryUOM { get; set; }

        [JsonProperty("PlanningSystem")] public string PlanningSystem { get; set; }

        [JsonProperty("ProcurementMethod")] public string ProcurementMethod { get; set; }

        [JsonProperty("ComponentWarehouse")] public string ComponentWarehouse { get; set; }

        [JsonProperty("OrderIntervals")] public string OrderIntervals { get; set; }

        [JsonProperty("OrderMultiple")] public double OrderMultiple { get; set; }

        [JsonProperty("LeadTime")] public string LeadTime { get; set; }

        [JsonProperty("MinOrderQuantity")] public double MinOrderQuantity { get; set; }

        [JsonProperty("ItemType")] public string ItemType { get; set; }

        [JsonProperty("ItemClass")] public string ItemClass { get; set; }

        [JsonProperty("OutgoingServiceCode")] public int OutgoingServiceCode { get; set; }

        [JsonProperty("IncomingServiceCode")] public int IncomingServiceCode { get; set; }

        [JsonProperty("ServiceGroup")] public int ServiceGroup { get; set; }

        [JsonProperty("NCMCode")] public int NCMCode { get; set; }

        [JsonProperty("MaterialType")] public string MaterialType { get; set; }

        [JsonProperty("MaterialGroup")] public int MaterialGroup { get; set; }

        [JsonProperty("ProductSource")] public string ProductSource { get; set; }

        [JsonProperty("Properties1")] public string Properties1 { get; set; }

        [JsonProperty("Properties2")] public string Properties2 { get; set; }

        [JsonProperty("Properties3")] public string Properties3 { get; set; }

        [JsonProperty("Properties4")] public string Properties4 { get; set; }

        [JsonProperty("Properties5")] public string Properties5 { get; set; }

        [JsonProperty("Properties6")] public string Properties6 { get; set; }

        [JsonProperty("Properties7")] public string Properties7 { get; set; }

        [JsonProperty("Properties8")] public string Properties8 { get; set; }

        [JsonProperty("Properties9")] public string Properties9 { get; set; }

        [JsonProperty("Properties10")] public string Properties10 { get; set; }

        [JsonProperty("Properties11")] public string Properties11 { get; set; }

        [JsonProperty("Properties12")] public string Properties12 { get; set; }

        [JsonProperty("Properties13")] public string Properties13 { get; set; }

        [JsonProperty("Properties14")] public string Properties14 { get; set; }

        [JsonProperty("Properties15")] public string Properties15 { get; set; }

        [JsonProperty("Properties16")] public string Properties16 { get; set; }

        [JsonProperty("Properties17")] public string Properties17 { get; set; }

        [JsonProperty("Properties18")] public string Properties18 { get; set; }

        [JsonProperty("Properties19")] public string Properties19 { get; set; }

        [JsonProperty("Properties20")] public string Properties20 { get; set; }

        [JsonProperty("Properties21")] public string Properties21 { get; set; }

        [JsonProperty("Properties22")] public string Properties22 { get; set; }

        [JsonProperty("Properties23")] public string Properties23 { get; set; }

        [JsonProperty("Properties24")] public string Properties24 { get; set; }

        [JsonProperty("Properties25")] public string Properties25 { get; set; }

        [JsonProperty("Properties26")] public string Properties26 { get; set; }

        [JsonProperty("Properties27")] public string Properties27 { get; set; }

        [JsonProperty("Properties28")] public string Properties28 { get; set; }

        [JsonProperty("Properties29")] public string Properties29 { get; set; }

        [JsonProperty("Properties30")] public string Properties30 { get; set; }

        [JsonProperty("Properties31")] public string Properties31 { get; set; }

        [JsonProperty("Properties32")] public string Properties32 { get; set; }

        [JsonProperty("Properties33")] public string Properties33 { get; set; }

        [JsonProperty("Properties34")] public string Properties34 { get; set; }

        [JsonProperty("Properties35")] public string Properties35 { get; set; }

        [JsonProperty("Properties36")] public string Properties36 { get; set; }

        [JsonProperty("Properties37")] public string Properties37 { get; set; }

        [JsonProperty("Properties38")] public string Properties38 { get; set; }

        [JsonProperty("Properties39")] public string Properties39 { get; set; }

        [JsonProperty("Properties40")] public string Properties40 { get; set; }

        [JsonProperty("Properties41")] public string Properties41 { get; set; }

        [JsonProperty("Properties42")] public string Properties42 { get; set; }

        [JsonProperty("Properties43")] public string Properties43 { get; set; }

        [JsonProperty("Properties44")] public string Properties44 { get; set; }

        [JsonProperty("Properties45")] public string Properties45 { get; set; }

        [JsonProperty("Properties46")] public string Properties46 { get; set; }

        [JsonProperty("Properties47")] public string Properties47 { get; set; }

        [JsonProperty("Properties48")] public string Properties48 { get; set; }

        [JsonProperty("Properties49")] public string Properties49 { get; set; }

        [JsonProperty("Properties50")] public string Properties50 { get; set; }

        [JsonProperty("Properties51")] public string Properties51 { get; set; }

        [JsonProperty("Properties52")] public string Properties52 { get; set; }

        [JsonProperty("Properties53")] public string Properties53 { get; set; }

        [JsonProperty("Properties54")] public string Properties54 { get; set; }

        [JsonProperty("Properties55")] public string Properties55 { get; set; }

        [JsonProperty("Properties56")] public string Properties56 { get; set; }

        [JsonProperty("Properties57")] public string Properties57 { get; set; }

        [JsonProperty("Properties58")] public string Properties58 { get; set; }

        [JsonProperty("Properties59")] public string Properties59 { get; set; }

        [JsonProperty("Properties60")] public string Properties60 { get; set; }

        [JsonProperty("Properties61")] public string Properties61 { get; set; }

        [JsonProperty("Properties62")] public string Properties62 { get; set; }

        [JsonProperty("Properties63")] public string Properties63 { get; set; }

        [JsonProperty("Properties64")] public string Properties64 { get; set; }

        [JsonProperty("AutoCreateSerialNumbersOnRelease")] public string AutoCreateSerialNumbersOnRelease { get; set; }

        [JsonProperty("DNFEntry")] public int DNFEntry { get; set; }

        [JsonProperty("GTSItemSpec")] public string GTSItemSpec { get; set; }

        [JsonProperty("GTSItemTaxCategory")] public string GTSItemTaxCategory { get; set; }

        [JsonProperty("FuelID")] public int? FuelID { get; set; }

        [JsonProperty("BeverageTableCode")] public string BeverageTableCode { get; set; }

        [JsonProperty("BeverageGroupCode")] public string BeverageGroupCode { get; set; }

        [JsonProperty("BeverageCommercialBrandCode")] public int? BeverageCommercialBrandCode { get; set; }

        [JsonProperty("Series")] public int? Series { get; set; }

        [JsonProperty("ToleranceDays")] public string ToleranceDays { get; set; }

        [JsonProperty("TypeOfAdvancedRules")] public string TypeOfAdvancedRules { get; set; }

        [JsonProperty("IssuePrimarilyBy")] public string IssuePrimarilyBy { get; set; }

        [JsonProperty("NoDiscounts")] public string NoDiscounts { get; set; }

        [JsonProperty("AssetClass")] public string AssetClass { get; set; }

        [JsonProperty("AssetGroup")] public string AssetGroup { get; set; }

        [JsonProperty("InventoryNumber")] public string InventoryNumber { get; set; }

        [JsonProperty("Technician")] public string Technician { get; set; }

        [JsonProperty("Employee")] public string Employee { get; set; }

        [JsonProperty("Location")] public string Location { get; set; }

        [JsonProperty("AssetStatus")] public string AssetStatus { get; set; }

        [JsonProperty("CapitalizationDate")] public string CapitalizationDate { get; set; }

        [JsonProperty("StatisticalAsset")] public string StatisticalAsset { get; set; }

        [JsonProperty("Cession")] public string Cession { get; set; }

        [JsonProperty("DeactivateAfterUsefulLife")] public string DeactivateAfterUsefulLife { get; set; }

        [JsonProperty("ManageByQuantity")] public string ManageByQuantity { get; set; }

        [JsonProperty("UoMGroupEntry")] public int? UoMGroupEntry { get; set; }

        [JsonProperty("InventoryUoMEntry")] public int? InventoryUoMEntry { get; set; }

        [JsonProperty("DefaultSalesUoMEntry")] public string DefaultSalesUoMEntry { get; set; }

        [JsonProperty("DefaultPurchasingUoMEntry")] public string DefaultPurchasingUoMEntry { get; set; }

        [JsonProperty("DepreciationGroup")] public string DepreciationGroup { get; set; }

        [JsonProperty("AssetSerialNumber")] public string AssetSerialNumber { get; set; }

        [JsonProperty("InventoryWeight")] public double? InventoryWeight { get; set; }

        [JsonProperty("InventoryWeightUnit")] public string InventoryWeightUnit { get; set; }

        [JsonProperty("InventoryWeight1")] public double? InventoryWeight1 { get; set; }

        [JsonProperty("InventoryWeightUnit1")] public string InventoryWeightUnit1 { get; set; }

        [JsonProperty("DefaultCountingUnit")] public string DefaultCountingUnit { get; set; }

        [JsonProperty("CountingItemsPerUnit")] public double? CountingItemsPerUnit { get; set; }

        [JsonProperty("DefaultCountingUoMEntry")] public string DefaultCountingUoMEntry { get; set; }

        [JsonProperty("Excisable")] public string Excisable { get; set; }

        [JsonProperty("ChapterID")] public int? ChapterID { get; set; }

        [JsonProperty("ScsCode")] public string ScsCode { get; set; }

        [JsonProperty("SpProdType")] public string SpProdType { get; set; }

        [JsonProperty("ProdStdCost")] public double? ProdStdCost { get; set; }

        [JsonProperty("InCostRollup")] public string InCostRollup { get; set; }

        [JsonProperty("VirtualAssetItem")] public string VirtualAssetItem { get; set; }

        [JsonProperty("EnforceAssetSerialNumbers")] public string EnforceAssetSerialNumbers { get; set; }

        [JsonProperty("AttachmentEntry")] public string AttachmentEntry { get; set; }

        [JsonProperty("LinkedResource")] public string LinkedResource { get; set; }

        [JsonProperty("UpdateDate")] public string UpdateDate { get; set; }

        [JsonProperty("UpdateTime")] public string UpdateTime { get; set; }

        [JsonProperty("GSTRelevnt")] public string GSTRelevnt { get; set; }

        [JsonProperty("SACEntry")] public int SACEntry { get; set; }

        [JsonProperty("GSTTaxCategory")] public string GSTTaxCategory { get; set; }

        [JsonProperty("ServiceCategoryEntry")] public int? ServiceCategoryEntry { get; set; }

        [JsonProperty("CapitalGoodsOnHoldPercent")] public string CapitalGoodsOnHoldPercent { get; set; }

        [JsonProperty("CapitalGoodsOnHoldLimit")] public string CapitalGoodsOnHoldLimit { get; set; }

        [JsonProperty("AssessableValue")] public double? AssessableValue { get; set; }

        [JsonProperty("AssVal4WTR")] public double? AssVal4WTR { get; set; }

        [JsonProperty("SOIExcisable")] public string SOIExcisable { get; set; }

        [JsonProperty("TNVED")] public string TNVED { get; set; }

        [JsonProperty("ImportedItem")] public string ImportedItem { get; set; }

        [JsonProperty("PricingUnit")] public int PricingUnit { get; set; }

        [JsonProperty("CreateDate")] private string CreateDate { get; set; }

        [JsonProperty("CreateTime")] private string CreateTime { get; set; }

        //[JsonProperty("U_BPP_TIPEXIST")] public string UBPPTIPEXIST { get; set; }

        //[JsonProperty("U_BPP_TIPUNMED")] public string UBPPTIPUNMED { get; set; }

        //[JsonProperty("U_VS_IPTSELE")] public string UVSIPTSELE { get; set; }

        //[JsonProperty("U_VS_TIPITM")] public string UVSTIPITM { get; set; }

        //[JsonProperty("U_VS_COD_N1")] public string UVSCODN1 { get; set; }

        //[JsonProperty("U_VS_DSC_N1")] public string UVSDSCN1 { get; set; }

        //[JsonProperty("U_VS_COD_N2")] public string UVSCODN2 { get; set; }

        //[JsonProperty("U_VS_DSC_N2")] public string UVSDSCN2 { get; set; }

        //[JsonProperty("U_VS_CODITM")] public string UVSCODITM { get; set; }

        //[JsonProperty("U_VS_AFPRCP")] public string UVSAFPRCP { get; set; }

        //[JsonProperty("U_VS_CODIMP")] public string UVSCODIMP { get; set; }

        //[JsonProperty("U_VS_PDARNC")] public string UVSPDARNC { get; set; }

        //[JsonProperty("U_VS_GRPPRCP")] public string UVSGRPPRCP { get; set; }

        //[JsonProperty("U_LN_TIPREVAL")] public string ULNTIPREVAL { get; set; }

        //[JsonProperty("U_LN_ESTADOAF")] public string ULNESTADOAF { get; set; }

        //[JsonProperty("U_VS_VENLOT")] public string UVSVENLOT { get; set; }

        //[JsonProperty("U_VS_AFEDET")] public string UVSAFEDET { get; set; }

        //[JsonProperty("U_VS_CODDET")] public string UVSCODDET { get; set; }

        //[JsonProperty("U_VS_PORDET")] public double? UVSPORDET { get; set; }

        //[JsonProperty("U_VS_CTAORD")] public string UVSCTAORD { get; set; }

        //[JsonProperty("U_VS_AFFISE")] public string UVSAFFISE { get; set; }

        //[JsonProperty("U_VS_CODOSCE")] public string UVSCODOSCE { get; set; }

        //[JsonProperty("U_VS_CODCLA")] public string UVSCODCLA { get; set; }

        //[JsonProperty("U_VS_CCGS1")] public string UVSCCGS1 { get; set; }

        //[JsonProperty("U_VS_FACBAR")] public double? UVSFACBAR { get; set; }

        //[JsonProperty("U_VS_ICG_CTO")] public string UVSICGCTO { get; set; }

        //[JsonProperty("U_VS_ICG_DTO")] public string UVSICGDTO { get; set; }

        //[JsonProperty("U_VS_ICG_CSC")] public string UVSICGCSC { get; set; }

        //[JsonProperty("U_VS_ICG_DSC")] public string UVSICGDSC { get; set; }

        //[JsonProperty("U_VS_ICG_CFA")] public string UVSICGCFA { get; set; }

        //[JsonProperty("U_VS_ICG_DFA")] public string UVSICGDFA { get; set; }

        //[JsonProperty("U_VS_ICG_CSF")] public string UVSICGCSF { get; set; }

        //[JsonProperty("U_VS_ICG_DSF")] public string UVSICGDSF { get; set; }

        //[JsonProperty("U_VS_ICG_CMR")] public string UVSICGCMR { get; set; }

        //[JsonProperty("U_VS_ICG_DMR")] public string UVSICGDMR { get; set; }

        //[JsonProperty("U_VS_ICG_CLN")] public string UVSICGCLN { get; set; }

        //[JsonProperty("U_VS_ICG_DLN")] public string UVSICGDLN { get; set; }

        //[JsonProperty("U_VS_ICG_UNI")] public string UVSICGUNI { get; set; }
        
        public Dictionary<string, object> AdditionalDataDetail { get; set; } = new Dictionary<string, object>();

        public Dictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();

        [JsonProperty("ItemPrices")] private List<ItemPrice> ItemPrices { get; set; }

        [JsonProperty("ItemWarehouseInfoCollection")] public List<ItemWarehouseInfoCollection> ItemWarehouseInfoCollection { get; set; }

        [JsonProperty("ItemLocalizationInfos")] public List<string> ItemLocalizationInfos { get; set; }

        [JsonProperty("ItemProjects")] public List<string> ItemProjects { get; set; }

        [JsonProperty("ItemDistributionRules")] public List<string> ItemDistributionRules { get; set; }

        [JsonProperty("ItemAttributeGroups")] public List<string> ItemAttributeGroups { get; set; }

        [JsonProperty("ItemDepreciationParameters")] public List<string> ItemDepreciationParameters { get; set; }

        [JsonProperty("ItemPeriodControls")] public List<string> ItemPeriodControls { get; set; }

        [JsonProperty("ItemUnitOfMeasurementCollection")] public List<string> ItemUnitOfMeasurementCollection { get; set; }

        [JsonProperty("ItemBarCodeCollection")] public List<string> ItemBarCodeCollection { get; set; }
    }


    public class ItemPrice
    {
        [JsonProperty("PriceList")] public int PriceList { get; set; }

        [JsonProperty("Price")] public double? Price { get; set; }

        [JsonProperty("Currency")] public object Currency { get; set; }

        [JsonProperty("AdditionalPrice1")] public double? AdditionalPrice1 { get; set; }

        [JsonProperty("AdditionalCurrency1")] public object AdditionalCurrency1 { get; set; }

        [JsonProperty("AdditionalPrice2")] public double? AdditionalPrice2 { get; set; }

        [JsonProperty("AdditionalCurrency2")] public object AdditionalCurrency2 { get; set; }

        [JsonProperty("BasePriceList")] public int? BasePriceList { get; set; }

        [JsonProperty("Factor")] public double? Factor { get; set; }

        [JsonProperty("UoMPrices")] public List<object> UoMPrices { get; set; }
        public Dictionary<string, object> AdditionalDataDetail { get; set; } = new Dictionary<string, object>();
    }

    public class ItemWarehouseInfoCollection
    {
        [JsonProperty("MinimalStock")] public double? MinimalStock { get; set; }

        [JsonProperty("MaximalStock")] public double? MaximalStock { get; set; }

        [JsonProperty("MinimalOrder")] public double? MinimalOrder { get; set; }

        [JsonProperty("StandardAveragePrice")] public double? StandardAveragePrice { get; set; }

        [JsonProperty("Locked")] public string Locked { get; set; }

        [JsonProperty("InventoryAccount")] public object InventoryAccount { get; set; }

        [JsonProperty("CostAccount")] public object CostAccount { get; set; }

        [JsonProperty("TransferAccount")] public object TransferAccount { get; set; }

        [JsonProperty("RevenuesAccount")] public object RevenuesAccount { get; set; }

        [JsonProperty("VarienceAccount")] public object VarienceAccount { get; set; }

        [JsonProperty("DecreasingAccount")] public object DecreasingAccount { get; set; }

        [JsonProperty("IncreasingAccount")] public object IncreasingAccount { get; set; }

        [JsonProperty("ReturningAccount")] public object ReturningAccount { get; set; }

        [JsonProperty("ExpensesAccount")] public object ExpensesAccount { get; set; }

        [JsonProperty("EURevenuesAccount")] public object EURevenuesAccount { get; set; }

        [JsonProperty("EUExpensesAccount")] public object EUExpensesAccount { get; set; }

        [JsonProperty("ForeignRevenueAcc")] public object ForeignRevenueAcc { get; set; }

        [JsonProperty("ForeignExpensAcc")] public object ForeignExpensAcc { get; set; }

        [JsonProperty("ExemptIncomeAcc")] public object ExemptIncomeAcc { get; set; }

        [JsonProperty("PriceDifferenceAcc")] public object PriceDifferenceAcc { get; set; }

        [JsonProperty("WarehouseCode")] public string WarehouseCode { get; set; }

        [JsonProperty("InStock")] public double? InStock { get; set; }

        [JsonProperty("Committed")] public double? Committed { get; set; }

        [JsonProperty("Ordered")] public double? Ordered { get; set; }

        [JsonProperty("CountedQuantity")] public double? CountedQuantity { get; set; }

        [JsonProperty("WasCounted")] public string WasCounted { get; set; }

        [JsonProperty("UserSignature")] public int UserSignature { get; set; }

        [JsonProperty("Counted")] public double? Counted { get; set; }

        [JsonProperty("ExpenseClearingAct")] public object ExpenseClearingAct { get; set; }

        [JsonProperty("PurchaseCreditAcc")] public object PurchaseCreditAcc { get; set; }

        [JsonProperty("EUPurchaseCreditAcc")] public object EUPurchaseCreditAcc { get; set; }

        [JsonProperty("ForeignPurchaseCreditAcc")]
        public object ForeignPurchaseCreditAcc { get; set; }

        [JsonProperty("SalesCreditAcc")] public object SalesCreditAcc { get; set; }

        [JsonProperty("SalesCreditEUAcc")] public object SalesCreditEUAcc { get; set; }

        [JsonProperty("ExemptedCredits")] public object ExemptedCredits { get; set; }

        [JsonProperty("SalesCreditForeignAcc")]
        public object SalesCreditForeignAcc { get; set; }

        [JsonProperty("ExpenseOffsettingAccount")]
        public object ExpenseOffsettingAccount { get; set; }

        [JsonProperty("WipAccount")] public object WipAccount { get; set; }

        [JsonProperty("ExchangeRateDifferencesAcct")]
        public object ExchangeRateDifferencesAcct { get; set; }

        [JsonProperty("GoodsClearingAcct")] public object GoodsClearingAcct { get; set; }

        [JsonProperty("NegativeInventoryAdjustmentAccount")]
        public object NegativeInventoryAdjustmentAccount { get; set; }

        [JsonProperty("CostInflationOffsetAccount")]
        public object CostInflationOffsetAccount { get; set; }

        [JsonProperty("GLDecreaseAcct")] public object GLDecreaseAcct { get; set; }

        [JsonProperty("GLIncreaseAcct")] public object GLIncreaseAcct { get; set; }

        [JsonProperty("PAReturnAcct")] public object PAReturnAcct { get; set; }

        [JsonProperty("PurchaseAcct")] public object PurchaseAcct { get; set; }

        [JsonProperty("PurchaseOffsetAcct")] public object PurchaseOffsetAcct { get; set; }

        [JsonProperty("ShippedGoodsAccount")] public object ShippedGoodsAccount { get; set; }

        [JsonProperty("StockInflationOffsetAccount")]
        public object StockInflationOffsetAccount { get; set; }

        [JsonProperty("StockInflationAdjustAccount")]
        public object StockInflationAdjustAccount { get; set; }

        [JsonProperty("VATInRevenueAccount")] public object VATInRevenueAccount { get; set; }

        [JsonProperty("WipVarianceAccount")] public object WipVarianceAccount { get; set; }

        [JsonProperty("CostInflationAccount")] public object CostInflationAccount { get; set; }

        [JsonProperty("WHIncomingCenvatAccount")]
        public object WHIncomingCenvatAccount { get; set; }

        [JsonProperty("WHOutgoingCenvatAccount")]
        public object WHOutgoingCenvatAccount { get; set; }

        [JsonProperty("StockInTransitAccount")]
        public object StockInTransitAccount { get; set; }

        [JsonProperty("WipOffsetProfitAndLossAccount")]
        public object WipOffsetProfitAndLossAccount { get; set; }

        [JsonProperty("InventoryOffsetProfitAndLossAccount")]
        public object InventoryOffsetProfitAndLossAccount { get; set; }

        [JsonProperty("DefaultBin")] public object DefaultBin { get; set; }

        [JsonProperty("DefaultBinEnforced")] public string DefaultBinEnforced { get; set; }

        [JsonProperty("PurchaseBalanceAccount")]
        public object PurchaseBalanceAccount { get; set; }

        [JsonProperty("ItemCode")] public string ItemCode { get; set; }

        [JsonProperty("ItemCycleCounts")] public List<object> ItemCycleCounts { get; set; }
        public Dictionary<string, object> AdditionalDataDetail { get; set; } = new Dictionary<string, object>();
    }
}