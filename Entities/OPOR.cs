using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnIntercompany.Entities
{
    [SAPEntityName("PurchaseOrders")]
    public class OPOR
    {
        [JsonProperty("DocEntry"), SAPKey] public int? DocEntry { get; set; }

        [JsonProperty("DocNum")] public int? DocNum { get; set; }

        [JsonProperty("DocType")] public string DocType { get; set; }

        [JsonProperty("HandWritten")] public string HandWritten { get; set; }

        [JsonProperty("Printed")] public string Printed { get; set; }

        [JsonProperty("DocDate")] public string DocDate { get; set; }

        [JsonProperty("DocDueDate")] public string DocDueDate { get; set; }

        [JsonProperty("CardCode")] public string CardCode { get; set; }

        [JsonProperty("CardName")] public string CardName { get; set; }

        [JsonProperty("Address")] public string Address { get; set; }

        [JsonProperty("NumAtCard")] public string NumAtCard { get; set; }

        [JsonProperty("DocTotal")] public double? DocTotal { get; set; }

        [JsonProperty("AttachmentEntry")] public object AttachmentEntry { get; set; }

        [JsonProperty("DocCurrency")] public string DocCurrency { get; set; }

        [JsonProperty("DocRate")] public double? DocRate { get; set; }

        [JsonProperty("Reference1")] public string Reference1 { get; set; }

        [JsonProperty("Reference2")] public object Reference2 { get; set; }

        [JsonProperty("Comments")] public string Comments { get; set; }

        [JsonProperty("JournalMemo")] public string JournalMemo { get; set; }

        [JsonProperty("PaymentGroupCode")] public string PaymentGroupCode { get; set; }

        [JsonProperty("DocTime")] public string DocTime { get; set; }

        [JsonProperty("SalesPersonCode")] public int? SalesPersonCode { get; set; }

        [JsonProperty("TransportationCode")] public int? TransportationCode { get; set; }

        [JsonProperty("Confirmed")] public string Confirmed { get; set; }

        [JsonProperty("ImportFileNum")] public int? ImportFileNum { get; set; }

        [JsonProperty("SummeryType")] public string SummeryType { get; set; }

        [JsonProperty("ContactPersonCode")] public int? ContactPersonCode { get; set; }

        [JsonProperty("ShowSCN")] public string ShowSCN { get; set; }

        [JsonProperty("Series")] public int? Series { get; set; }

        [JsonProperty("TaxDate")] public string TaxDate { get; set; }

        [JsonProperty("PartialSupply")] public object PartialSupply { get; set; }

        [JsonProperty("DocObjectCode")] public string DocObjectCode { get; set; }

        [JsonProperty("ShipToCode")] public object ShipToCode { get; set; }

        [JsonProperty("Indicator")] public object Indicator { get; set; }

        [JsonProperty("FederalTaxID")] public string FederalTaxID { get; set; }

        [JsonProperty("DiscountPercent")] public double? DiscountPercent { get; set; }

        [JsonProperty("PaymentReference")] public string PaymentReference { get; set; }

        [JsonProperty("CreationDate")] public string CreationDate { get; set; }

        [JsonProperty("UpdateDate")] public string UpdateDate { get; set; }

        [JsonProperty("FinancialPeriod")] public int? FinancialPeriod { get; set; }

        [JsonProperty("TransNum")] public object TransNum { get; set; }

        [JsonProperty("VatSum")] public double? VatSum { get; set; }

        [JsonProperty("VatSumSys")] public double? VatSumSys { get; set; }

        [JsonProperty("VatSumFc")] public double? VatSumFc { get; set; }

        [JsonProperty("NetProcedure")] public string NetProcedure { get; set; }

        [JsonProperty("DocTotalFc")] public double? DocTotalFc { get; set; }

        [JsonProperty("DocTotalSys")] public double? DocTotalSys { get; set; }

        [JsonProperty("Form1099")] public object Form1099 { get; set; }

        [JsonProperty("Box1099")] public object Box1099 { get; set; }

        [JsonProperty("RevisionPo")] public string RevisionPo { get; set; }

        [JsonProperty("RequriedDate")] public object RequriedDate { get; set; }

        [JsonProperty("CancelDate")] public object CancelDate { get; set; }

        [JsonProperty("BlockDunning")] public string BlockDunning { get; set; }

        [JsonProperty("Submitted")] public string Submitted { get; set; }

        [JsonProperty("Segment")] public int? Segment { get; set; }

        [JsonProperty("PickStatus")] public string PickStatus { get; set; }

        [JsonProperty("Pick")] public string Pick { get; set; }

        [JsonProperty("PaymentMethod")] public string PaymentMethod { get; set; }

        [JsonProperty("PaymentBlock")] public string PaymentBlock { get; set; }

        [JsonProperty("PaymentBlockEntry")] public object PaymentBlockEntry { get; set; }

        [JsonProperty("CentralBankIndicator")] public object CentralBankIndicator { get; set; }

        [JsonProperty("MaximumCashDiscount")] public string MaximumCashDiscount { get; set; }

        [JsonProperty("Reserve")] public string Reserve { get; set; }

        [JsonProperty("Project")] public string Project { get; set; }

        [JsonProperty("ExemptionValidityDateFrom")] public object ExemptionValidityDateFrom { get; set; }

        [JsonProperty("ExemptionValidityDateTo")] public object ExemptionValidityDateTo { get; set; }

        [JsonProperty("WareHouseUpdateType")] public string WareHouseUpdateType { get; set; }

        [JsonProperty("Rounding")] public string Rounding { get; set; }

        [JsonProperty("ExternalCorrectedDocNum")] public object ExternalCorrectedDocNum { get; set; }

        [JsonProperty("InternalCorrectedDocNum")] public object InternalCorrectedDocNum { get; set; }

        [JsonProperty("NextCorrectingDocument")] public object NextCorrectingDocument { get; set; }

        [JsonProperty("DeferredTax")] public string DeferredTax { get; set; }

        [JsonProperty("TaxExemptionLetterNum")] public string TaxExemptionLetterNum { get; set; }

        [JsonProperty("WTApplied")] public double? WTApplied { get; set; }

        [JsonProperty("WTAppliedFC")] public double? WTAppliedFC { get; set; }

        [JsonProperty("BillOfExchangeReserved")] public string BillOfExchangeReserved { get; set; }

        [JsonProperty("AgentCode")] public object AgentCode { get; set; }

        [JsonProperty("WTAppliedSC")] public double? WTAppliedSC { get; set; }

        [JsonProperty("TotalEqualizationTax")] public double? TotalEqualizationTax { get; set; }

        [JsonProperty("TotalEqualizationTaxFC")] public double? TotalEqualizationTaxFC { get; set; }

        [JsonProperty("TotalEqualizationTaxSC")] public double? TotalEqualizationTaxSC { get; set; }

        [JsonProperty("NumberOfInstallments")] public int? NumberOfInstallments { get; set; }

        [JsonProperty("ApplyTaxOnFirstInstallment")] public string ApplyTaxOnFirstInstallment { get; set; }

        [JsonProperty("WTNonSubjectAmount")] public double? WTNonSubjectAmount { get; set; }

        [JsonProperty("WTNonSubjectAmountSC")] public double? WTNonSubjectAmountSC { get; set; }

        [JsonProperty("WTNonSubjectAmountFC")] public double? WTNonSubjectAmountFC { get; set; }

        [JsonProperty("WTExemptedAmount")] public double? WTExemptedAmount { get; set; }

        [JsonProperty("WTExemptedAmountSC")] public double? WTExemptedAmountSC { get; set; }

        [JsonProperty("WTExemptedAmountFC")] public double? WTExemptedAmountFC { get; set; }

        [JsonProperty("BaseAmount")] public double? BaseAmount { get; set; }

        [JsonProperty("BaseAmountSC")] public double? BaseAmountSC { get; set; }

        [JsonProperty("BaseAmountFC")] public double? BaseAmountFC { get; set; }

        [JsonProperty("WTAmount")] public double? WTAmount { get; set; }

        [JsonProperty("WTAmountSC")] public double? WTAmountSC { get; set; }

        [JsonProperty("WTAmountFC")] public double? WTAmountFC { get; set; }

        [JsonProperty("VatDate")] public object VatDate { get; set; }

        [JsonProperty("DocumentsOwner")] public object DocumentsOwner { get; set; }

        [JsonProperty("FolioPrefixString")] public object FolioPrefixString { get; set; }

        [JsonProperty("FolioNumber")] public object FolioNumber { get; set; }

        [JsonProperty("DocumentSubType")] public string DocumentSubType { get; set; }

        [JsonProperty("BPChannelCode")] public object BPChannelCode { get; set; }

        [JsonProperty("BPChannelContact")] public int? BPChannelContact { get; set; }

        [JsonProperty("Address2")] public string Address2 { get; set; }

        [JsonProperty("DocumentStatus")] public string DocumentStatus { get; set; }

        [JsonProperty("PeriodIndicator")] public string PeriodIndicator { get; set; }

        [JsonProperty("PayToCode")] public string PayToCode { get; set; }

        [JsonProperty("ManualNumber")] public object ManualNumber { get; set; }

        [JsonProperty("UseShpdGoodsAct")] public string UseShpdGoodsAct { get; set; }

        [JsonProperty("IsPayToBank")] public string IsPayToBank { get; set; }

        [JsonProperty("PayToBankCountry")] public object PayToBankCountry { get; set; }

        [JsonProperty("PayToBankCode")] public object PayToBankCode { get; set; }

        [JsonProperty("PayToBankAccountNo")] public object PayToBankAccountNo { get; set; }

        [JsonProperty("PayToBankBranch")] public object PayToBankBranch { get; set; }

        [JsonProperty("BPL_IDAssignedToInvoice")] public int? BPL_IDAssignedToInvoice { get; set; }

        [JsonProperty("DownPayment")] public double? DownPayment { get; set; }

        [JsonProperty("ReserveInvoice")] public string ReserveInvoice { get; set; }

        [JsonProperty("LanguageCode")] public int? LanguageCode { get; set; }

        [JsonProperty("TrackingNumber")] public object TrackingNumber { get; set; }

        [JsonProperty("PickRemark")] public object PickRemark { get; set; }

        [JsonProperty("ClosingDate")] public object ClosingDate { get; set; }

        [JsonProperty("SequenceCode")] public object SequenceCode { get; set; }

        [JsonProperty("SequenceSerial")] public object SequenceSerial { get; set; }

        [JsonProperty("SeriesString")] public object SeriesString { get; set; }

        [JsonProperty("SubSeriesString")] public object SubSeriesString { get; set; }

        [JsonProperty("SequenceModel")] public string SequenceModel { get; set; }

        [JsonProperty("UseCorrectionVATGroup")] public string UseCorrectionVATGroup { get; set; }

        [JsonProperty("TotalDiscount")] public double? TotalDiscount { get; set; }

        [JsonProperty("DownPaymentAmount")] public double? DownPaymentAmount { get; set; }

        [JsonProperty("DownPaymentPercentage")] public double? DownPaymentPercentage { get; set; }

        [JsonProperty("DownPaymentType")] public string DownPaymentType { get; set; }

        [JsonProperty("DownPaymentAmountSC")] public double? DownPaymentAmountSC { get; set; }

        [JsonProperty("DownPaymentAmountFC")] public double? DownPaymentAmountFC { get; set; }

        [JsonProperty("VatPercent")] public double? VatPercent { get; set; }

        [JsonProperty("ServiceGrossProfitPercent")] public double? ServiceGrossProfitPercent { get; set; }

        [JsonProperty("OpeningRemarks")] public object OpeningRemarks { get; set; }

        [JsonProperty("ClosingRemarks")] public object ClosingRemarks { get; set; }

        [JsonProperty("RoundingDiffAmount")] public double? RoundingDiffAmount { get; set; }

        [JsonProperty("RoundingDiffAmountFC")] public double? RoundingDiffAmountFC { get; set; }

        [JsonProperty("RoundingDiffAmountSC")] public double? RoundingDiffAmountSC { get; set; }

        [JsonProperty("Cancelled")] public string Cancelled { get; set; }

        [JsonProperty("SignatureInputMessage")] public object SignatureInputMessage { get; set; }

        [JsonProperty("SignatureDigest")] public object SignatureDigest { get; set; }

        [JsonProperty("CertificationNumber")] public object CertificationNumber { get; set; }

        [JsonProperty("PrivateKeyVersion")] public object PrivateKeyVersion { get; set; }

        [JsonProperty("ControlAccount")] public string ControlAccount { get; set; }

        [JsonProperty("InsuranceOperation347")] public string InsuranceOperation347 { get; set; }

        [JsonProperty("ArchiveNonremovableSalesQuotation")] public string ArchiveNonremovableSalesQuotation { get; set; }

        [JsonProperty("GTSChecker")] public object GTSChecker { get; set; }

        [JsonProperty("GTSPayee")] public object GTSPayee { get; set; }

        [JsonProperty("ExtraMonth")] public int? ExtraMonth { get; set; }

        [JsonProperty("ExtraDays")] public int? ExtraDays { get; set; }

        [JsonProperty("CashDiscountDateOffset")] public int? CashDiscountDateOffset { get; set; }

        [JsonProperty("StartFrom")] public string StartFrom { get; set; }

        [JsonProperty("NTSApproved")] public string NTSApproved { get; set; }

        [JsonProperty("ETaxWebSite")] public object ETaxWebSite { get; set; }

        [JsonProperty("ETaxNumber")] public object ETaxNumber { get; set; }

        [JsonProperty("NTSApprovedNumber")] public object NTSApprovedNumber { get; set; }

        [JsonProperty("EDocGenerationType")] public string EDocGenerationType { get; set; }

        [JsonProperty("EDocSeries")] public object EDocSeries { get; set; }

        [JsonProperty("EDocNum")] public object EDocNum { get; set; }

        [JsonProperty("EDocExportFormat")] public object EDocExportFormat { get; set; }

        [JsonProperty("EDocStatus")] public string EDocStatus { get; set; }

        [JsonProperty("EDocErrorCode")] public object EDocErrorCode { get; set; }

        [JsonProperty("EDocErrorMessage")] public object EDocErrorMessage { get; set; }

        [JsonProperty("DownPaymentStatus")] public string DownPaymentStatus { get; set; }

        [JsonProperty("GroupSeries")] public object GroupSeries { get; set; }

        [JsonProperty("GroupNumber")] public object GroupNumber { get; set; }

        [JsonProperty("GroupHandWritten")] public string GroupHandWritten { get; set; }

        [JsonProperty("ReopenOriginalDocument")] public object ReopenOriginalDocument { get; set; }

        [JsonProperty("ReopenManuallyClosedOrCanceledDocument")] public object ReopenManuallyClosedOrCanceledDocument { get; set; }

        [JsonProperty("CreateOnlineQuotation")] public string CreateOnlineQuotation { get; set; }

        [JsonProperty("POSEquipmentNumber")] public object POSEquipmentNumber { get; set; }

        [JsonProperty("POSManufacturerSerialNumber")] public object POSManufacturerSerialNumber { get; set; }

        [JsonProperty("POSCashierNumber")] public object POSCashierNumber { get; set; }

        [JsonProperty("ApplyCurrentVATRatesForDownPaymentsToDraw")] public string ApplyCurrentVATRatesForDownPaymentsToDraw { get; set; }

        [JsonProperty("ClosingOption")] public string ClosingOption { get; set; }

        [JsonProperty("SpecifiedClosingDate")] public object SpecifiedClosingDate { get; set; }

        [JsonProperty("OpenForLandedCosts")] public string OpenForLandedCosts { get; set; }

        [JsonProperty("AuthorizationStatus")] public string AuthorizationStatus { get; set; }

        [JsonProperty("TotalDiscountFC")] public double? TotalDiscountFC { get; set; }

        [JsonProperty("TotalDiscountSC")] public double? TotalDiscountSC { get; set; }

        [JsonProperty("RelevantToGTS")] public string RelevantToGTS { get; set; }

        [JsonProperty("BPLName")] public object BPLName { get; set; }

        [JsonProperty("VATRegNum")] public object VATRegNum { get; set; }

        [JsonProperty("AnnualInvoiceDeclarationReference")] public object AnnualInvoiceDeclarationReference { get; set; }

        [JsonProperty("Supplier")] public object Supplier { get; set; }

        [JsonProperty("Releaser")] public object Releaser { get; set; }

        [JsonProperty("Receiver")] public object Receiver { get; set; }

        [JsonProperty("BlanketAgreementNumber")] public object BlanketAgreementNumber { get; set; }

        [JsonProperty("IsAlteration")] public string IsAlteration { get; set; }

        [JsonProperty("CancelStatus")] public string CancelStatus { get; set; }

        [JsonProperty("AssetValueDate")] public string AssetValueDate { get; set; }

        [JsonProperty("DocumentDelivery")] public string DocumentDelivery { get; set; }

        [JsonProperty("AuthorizationCode")] public object AuthorizationCode { get; set; }

        [JsonProperty("StartDeliveryDate")] public object StartDeliveryDate { get; set; }

        [JsonProperty("StartDeliveryTime")] public object StartDeliveryTime { get; set; }

        [JsonProperty("EndDeliveryDate")] public object EndDeliveryDate { get; set; }

        [JsonProperty("EndDeliveryTime")] public object EndDeliveryTime { get; set; }

        [JsonProperty("VehiclePlate")] public object VehiclePlate { get; set; }

        [JsonProperty("ATDocumentType")] public object ATDocumentType { get; set; }

        [JsonProperty("ElecCommStatus")] public object ElecCommStatus { get; set; }

        [JsonProperty("ElecCommMessage")] public object ElecCommMessage { get; set; }

        [JsonProperty("ReuseDocumentNum")] public string ReuseDocumentNum { get; set; }

        [JsonProperty("ReuseNotaFiscalNum")] public string ReuseNotaFiscalNum { get; set; }

        [JsonProperty("PrintSEPADirect")] public string PrintSEPADirect { get; set; }

        [JsonProperty("FiscalDocNum")] public object FiscalDocNum { get; set; }

        [JsonProperty("POSDailySummaryNo")] public object POSDailySummaryNo { get; set; }

        [JsonProperty("POSReceiptNo")] public object POSReceiptNo { get; set; }

        [JsonProperty("PointOfIssueCode")] public object PointOfIssueCode { get; set; }

        [JsonProperty("Letter")] public object Letter { get; set; }

        [JsonProperty("FolioNumberFrom")] public object FolioNumberFrom { get; set; }

        [JsonProperty("FolioNumberTo")] public object FolioNumberTo { get; set; }

        [JsonProperty("InterimType")] public string InterimType { get; set; }

        [JsonProperty("RelatedType")] public int? RelatedType { get; set; }

        [JsonProperty("RelatedEntry")] public object RelatedEntry { get; set; }

        [JsonProperty("SAPPassport")] public object SAPPassport { get; set; }

        [JsonProperty("DocumentTaxID")] public object DocumentTaxID { get; set; }

        [JsonProperty("DateOfReportingControlStatementVAT")] public object DateOfReportingControlStatementVAT { get; set; }

        [JsonProperty("ReportingSectionControlStatementVAT")] public object ReportingSectionControlStatementVAT { get; set; }

        [JsonProperty("ExcludeFromTaxReportControlStatementVAT")] public string ExcludeFromTaxReportControlStatementVAT { get; set; }

        [JsonProperty("POS_CashRegister")] public object POSCashRegister { get; set; }

        [JsonProperty("UpdateTime")] public string UpdateTime { get; set; }

        [JsonProperty("PriceMode")] public object PriceMode { get; set; }

        [JsonProperty("ShipFrom")] public object ShipFrom { get; set; }

        [JsonProperty("CommissionTrade")] public string CommissionTrade { get; set; }

        [JsonProperty("CommissionTradeReturn")] public string CommissionTradeReturn { get; set; }

        [JsonProperty("UseBillToAddrToDetermineTax")] public string UseBillToAddrToDetermineTax { get; set; }

        [JsonProperty("Cig")] public object Cig { get; set; }

        [JsonProperty("Cup")] public object Cup { get; set; }

        //[JsonProperty("U_BPV_SERI")] public object UBPVSERI { get; set; }

        //[JsonProperty("U_BPV_NCON2")] public object UBPVNCON2 { get; set; }

        //[JsonProperty("U_BPP_MDTD")] public object UBPPMDTD { get; set; }

        //[JsonProperty("U_OK1_Anulada")] public string UOK1Anulada { get; set; }

        //[JsonProperty("U_BPP_MDCT")] public object UBPPMDCT { get; set; }

        //[JsonProperty("U_BPP_MDNT")] public object UBPPMDNT { get; set; }

        //[JsonProperty("U_BPP_MDDT")] public object UBPPMDDT { get; set; }

        //[JsonProperty("U_BPP_MDRT")] public object UBPPMDRT { get; set; }

        //[JsonProperty("U_BPP_MDFC")] public object UBPPMDFC { get; set; }

        //[JsonProperty("U_BPP_MDFN")] public object UBPPMDFN { get; set; }

        //[JsonProperty("U_BPP_MDVC")] public object UBPPMDVC { get; set; }

        //[JsonProperty("U_BPP_MDVN")] public object UBPPMDVN { get; set; }

        //[JsonProperty("U_BPP_MDVT")] public object UBPPMDVT { get; set; }

        //[JsonProperty("U_BPP_MDMT")] public object UBPPMDMT { get; set; }

        //[JsonProperty("U_BPP_MDTS")] public string UBPPMDTS { get; set; }

        //[JsonProperty("U_BPP_CDAD")] public string UBPPCDAD { get; set; }

        //[JsonProperty("U_BPP_DPFC")] public object UBPPDPFC { get; set; }

        //[JsonProperty("U_BPP_DPNM")] public object UBPPDPNM { get; set; }

        //[JsonProperty("U_BPP_MDBI")] public string UBPPMDBI { get; set; }

        //[JsonProperty("U_BPP_MDCD")] public object UBPPMDCD { get; set; }

        //[JsonProperty("U_BPP_MDCO")] public object UBPPMDCO { get; set; }

        //[JsonProperty("U_BPP_MDFD")] public object UBPPMDFD { get; set; }

        //[JsonProperty("U_BPP_MDFE")] public object UBPPMDFE { get; set; }

        //[JsonProperty("U_BPP_MDND")] public object UBPPMDND { get; set; }

        //[JsonProperty("U_BPP_MDOM")] public object UBPPMDOM { get; set; }

        //[JsonProperty("U_BPP_MDSD")] public object UBPPMDSD { get; set; }

        //[JsonProperty("U_BPP_MDSN")] public object UBPPMDSN { get; set; }

        //[JsonProperty("U_BPP_MDSO")] public object UBPPMDSO { get; set; }

        //[JsonProperty("U_BPP_MDTO")] public object UBPPMDTO { get; set; }

        //[JsonProperty("U_BPP_SDOCDATE")] public object UBPPSDOCDATE { get; set; }

        //[JsonProperty("U_BPP_SND")] public object UBPPSND { get; set; }

        //[JsonProperty("U_VS_OCCLIENTE")] public object UVSOCCLIENTE { get; set; }

        //[JsonProperty("U_VS_NRO_GR")] public object UVSNROGR { get; set; }

        //[JsonProperty("U_VS_NRO_FT")] public object UVSNROFT { get; set; }

        //[JsonProperty("U_VS_FLGCOTIZA")] public string UVSFLGCOTIZA { get; set; }

        //[JsonProperty("U_VS_ANTAPL")] public object UVSANTAPL { get; set; }

        //[JsonProperty("U_VS_DOCORG")] public object UVSDOCORG { get; set; }

        //[JsonProperty("U_VS_SDOCTOTAL")] public double? UVSSDOCTOTAL { get; set; }

        //[JsonProperty("U_VS_USRSV")] public string UVSUSRSV { get; set; }

        //[JsonProperty("U_VS_TDOCORG")] public object UVSTDOCORG { get; set; }

        //[JsonProperty("U_VS_FRMSAP")] public object UVSFRMSAP { get; set; }

        //[JsonProperty("U_VS_REPDNI")] public object UVSREPDNI { get; set; }

        //[JsonProperty("U_VS_REPNOM")] public object UVSREPNOM { get; set; }

        //[JsonProperty("U_BPP_JrlDestino")] public object UBPPJrlDestino { get; set; }

        //[JsonProperty("U_VS_LINAFPRCP")] public object UVSLINAFPRCP { get; set; }

        //[JsonProperty("U_VS_METVAL")] public string UVSMETVAL { get; set; }

        //[JsonProperty("U_VS_INCPRCP")] public object UVSINCPRCP { get; set; }

        //[JsonProperty("U_VS_MOTEMI")] public object UVSMOTEMI { get; set; }

        //[JsonProperty("U_VS_SUSTNT")] public object UVSSUSTNT { get; set; }

        //[JsonProperty("U_VS_FESTAT")] public string UVSFESTAT { get; set; }

        //[JsonProperty("U_VS_CDRRSM")] public object UVSCDRRSM { get; set; }

        //[JsonProperty("U_VS_GRATEN")] public string UVSGRATEN { get; set; }

        //[JsonProperty("U_VS_GUITRA")] public object UVSGUITRA { get; set; }

        //[JsonProperty("U_VS_PORTSUNAT")] public string UVSPORTSUNAT { get; set; }

        //[JsonProperty("U_BPP_MDCI")] public object UBPPMDCI { get; set; }

        //[JsonProperty("U_BPP_MDCF")] public object UBPPMDCF { get; set; }

        //[JsonProperty("U_BPP_MDTL")] public object UBPPMDTL { get; set; }

        //[JsonProperty("U_LN_TIPOCAP")] public string ULNTIPOCAP { get; set; }

        //[JsonProperty("U_VS_CODSER")] public string UVSCODSER { get; set; }

        //[JsonProperty("U_VS_AFEDET")] public string UVSAFEDET { get; set; }

        //[JsonProperty("U_VS_PORDET")] public double? UVSPORDET { get; set; }

        //[JsonProperty("U_VS_APLANT")] public string UVSAPLANT { get; set; }

        //[JsonProperty("U_BPP_MDSD2")] public object UBPPMDSD2 { get; set; }

        //[JsonProperty("U_VS_MONDET")] public double? UVSMONDET { get; set; }

        //[JsonProperty("U_VS_NATNUM")] public string UVSNATNUM { get; set; }

        //[JsonProperty("U_VS_ANULGUIA")] public string UVSANULGUIA { get; set; }

        //[JsonProperty("U_NUMER")] public object UNUMER { get; set; }

        //[JsonProperty("U_NUMCC")] public object UNUMCC { get; set; }

        //[JsonProperty("U_VS_DEVENG")] public string UVSDEVENG { get; set; }

        //[JsonProperty("U_VS_TYDEV")] public string UVSTYDEV { get; set; }

        //[JsonProperty("U_VS_DIRLLEG")] public object UVSDIRLLEG { get; set; }

        //[JsonProperty("U_VS_GLNLLEG")] public object UVSGLNLLEG { get; set; }

        //[JsonProperty("U_VS_PBRTOTAL")] public double? UVSPBRTOTAL { get; set; }

        //[JsonProperty("U_VS_BULPAL")] public object UVSBULPAL { get; set; }

        //[JsonProperty("U_VS_CODPUER")] public object UVSCODPUER { get; set; }

        //[JsonProperty("U_VS_MOTTRAS")] public object UVSMOTTRAS { get; set; }

        //[JsonProperty("U_VS_DIRPART")] public object UVSDIRPART { get; set; }

        //[JsonProperty("U_VS_GLNPART")] public object UVSGLNPART { get; set; }

        //[JsonProperty("U_VS_MODTRA")] public object UVSMODTRA { get; set; }

        //[JsonProperty("U_VS_DOCCOND")] public object UVSDOCCOND { get; set; }

        //[JsonProperty("U_VS_CODTCOND")] public object UVSCODTCOND { get; set; }

        //[JsonProperty("U_VS_NUMCONT")] public object UVSNUMCONT { get; set; }

        //[JsonProperty("U_VS_INTRASB")] public string UVSINTRASB { get; set; }

        //[JsonProperty("U_VS_FECTRAS")] public object UVSFECTRAS { get; set; }

        //[JsonProperty("U_VS_HMDS")] public double? UVSHMDS { get; set; }

        //[JsonProperty("U_VS_TIPO_FACT")] public string UVSTIPOFACT { get; set; }

        //[JsonProperty("U_VS_MPAGO")] public object UVSMPAGO { get; set; }

        //[JsonProperty("U_VS_MTRCL")] public object UVSMTRCL { get; set; }

        //[JsonProperty("U_VS_NMEMB")] public object UVSNMEMB { get; set; }

        //[JsonProperty("U_VS_DESESPC")] public object UVSDESESPC { get; set; }

        //[JsonProperty("U_VS_LGDESC")] public object UVSLGDESC { get; set; }

        //[JsonProperty("U_VS_CNESPC")] public double? UVSCNESPC { get; set; }

        //[JsonProperty("U_VS_FECDESC")] public object UVSFECDESC { get; set; }

        //[JsonProperty("U_VS_DIGESTVALUE")] public object UVSDIGESTVALUE { get; set; }

        //[JsonProperty("U_VS_CODBARRA")] public object UVSCODBARRA { get; set; }

        //[JsonProperty("U_VS_ENVIO_SUNAT")] public string UVSENVIOSUNAT { get; set; }

        //[JsonProperty("U_VS_HPDS")] public double? UVSHPDS { get; set; }

        //[JsonProperty("U_VS_CLSBYS")] public object UVSCLSBYS { get; set; }

        //[JsonProperty("U_VS_IDBENF")] public object UVSIDBENF { get; set; }

        //[JsonProperty("U_VS_RZBENF")] public object UVSRZBENF { get; set; }

        //[JsonProperty("U_VS_PAISBF")] public object UVSPAISBF { get; set; }

        //[JsonProperty("U_VS_CONVEN")] public object UVSCONVEN { get; set; }

        //[JsonProperty("U_VS_EXONER")] public object UVSEXONER { get; set; }

        //[JsonProperty("U_VS_TIPREN")] public object UVSTIPREN { get; set; }

        //[JsonProperty("U_VS_MODSRV")] public object UVSMODSRV { get; set; }

        //[JsonProperty("U_VS_TIPCREF")] public object UVSTIPCREF { get; set; }

        //[JsonProperty("U_VS_SI")] public string UVSSI { get; set; }

        //[JsonProperty("U_CL_REFORIG")] public object UCLREFORIG { get; set; }

        public Dictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();

        [JsonProperty("Document_ApprovalRequests")] public List<object> DocumentApprovalRequests { get; set; }

        [JsonProperty("DocumentLines")] public List<PurchaseOrderDocumentLine> DocumentLines { get; set; }

        [JsonProperty("ElectronicProtocols")] public List<object> ElectronicProtocols { get; set; }

        [JsonProperty("DocumentAdditionalExpenses")] public List<object> DocumentAdditionalExpenses { get; set; }

        [JsonProperty("WithholdingTaxDataWTXCollection")] public List<object> WithholdingTaxDataWTXCollection { get; set; }

        [JsonProperty("WithholdingTaxDataCollection")] public List<object> WithholdingTaxDataCollection { get; set; }

        [JsonProperty("DocumentSpecialLines")] public List<object> DocumentSpecialLines { get; set; }

        [JsonProperty("DocumentReferences")] public List<object> DocumentReferences { get; set; }
    }

    public class PuchaseOrderLineTaxJurisdiction
    {
        [JsonProperty("JurisdictionCode")] public string JurisdictionCode { get; set; }

        [JsonProperty("JurisdictionType")] public int? JurisdictionType { get; set; }

        [JsonProperty("TaxAmount")] public double? TaxAmount { get; set; }

        [JsonProperty("TaxAmountSC")] public double? TaxAmountSC { get; set; }

        [JsonProperty("TaxAmountFC")] public double? TaxAmountFC { get; set; }

        [JsonProperty("TaxRate")] public double? TaxRate { get; set; }

        [JsonProperty("DocEntry")] public int? DocEntry { get; set; }

        [JsonProperty("LineNumber")] public int? LineNumber { get; set; }

        [JsonProperty("RowSequence")] public int? RowSequence { get; set; }
    }

    public class PurchaseOrderDocumentLine
    {
        [JsonProperty("LineNum")] public int? LineNum { get; set; }

        [JsonProperty("ItemCode")] public string ItemCode { get; set; }

        [JsonProperty("ItemDescription")] public string ItemDescription { get; set; }

        [JsonProperty("Quantity")] public double? Quantity { get; set; }

        [JsonProperty("ShipDate")] public string ShipDate { get; set; }

        [JsonProperty("Price")] public double? Price { get; set; }

        [JsonProperty("PriceAfterVAT")] public double? PriceAfterVAT { get; set; }

        [JsonProperty("Currency")] public string Currency { get; set; }

        [JsonProperty("Rate")] public double? Rate { get; set; }

        [JsonProperty("DiscountPercent")] public double? DiscountPercent { get; set; }

        [JsonProperty("VendorNum")] public string VendorNum { get; set; }

        [JsonProperty("SerialNum")] public string SerialNum { get; set; }

        [JsonProperty("WarehouseCode")] public string WarehouseCode { get; set; }

        [JsonProperty("SalesPersonCode")] public int? SalesPersonCode { get; set; }

        [JsonProperty("CommisionPercent")] public double? CommisionPercent { get; set; }

        [JsonProperty("TreeType")] public string TreeType { get; set; }

        [JsonProperty("AccountCode")] public string AccountCode { get; set; }

        [JsonProperty("UseBaseUnits")] public string UseBaseUnits { get; set; }

        [JsonProperty("SupplierCatNum")] public string SupplierCatNum { get; set; }

        [JsonProperty("CostingCode")] public string CostingCode { get; set; }

        [JsonProperty("ProjectCode")] public string ProjectCode { get; set; }

        [JsonProperty("BarCode")] public object BarCode { get; set; }

        [JsonProperty("VatGroup")] public string VatGroup { get; set; }

        [JsonProperty("Height1")] public double? Height1 { get; set; }

        [JsonProperty("Hight1Unit")] public object Hight1Unit { get; set; }

        [JsonProperty("Height2")] public double? Height2 { get; set; }

        [JsonProperty("Height2Unit")] public object Height2Unit { get; set; }

        [JsonProperty("Lengh1")] public double? Lengh1 { get; set; }

        [JsonProperty("Lengh1Unit")] public object Lengh1Unit { get; set; }

        [JsonProperty("Lengh2")] public double? Lengh2 { get; set; }

        [JsonProperty("Lengh2Unit")] public object Lengh2Unit { get; set; }

        [JsonProperty("Weight1")] public double? Weight1 { get; set; }

        [JsonProperty("Weight1Unit")] public object Weight1Unit { get; set; }

        [JsonProperty("Weight2")] public double? Weight2 { get; set; }

        [JsonProperty("Weight2Unit")] public object Weight2Unit { get; set; }

        [JsonProperty("Factor1")] public double? Factor1 { get; set; }

        [JsonProperty("Factor2")] public double? Factor2 { get; set; }

        [JsonProperty("Factor3")] public double? Factor3 { get; set; }

        [JsonProperty("Factor4")] public double? Factor4 { get; set; }

        [JsonProperty("BaseType")] public int? BaseType { get; set; }

        [JsonProperty("BaseEntry")] public object BaseEntry { get; set; }

        [JsonProperty("BaseLine")] public object BaseLine { get; set; }

        [JsonProperty("Volume")] public double? Volume { get; set; }

        [JsonProperty("VolumeUnit")] public int? VolumeUnit { get; set; }

        [JsonProperty("Width1")] public double? Width1 { get; set; }

        [JsonProperty("Width1Unit")] public object Width1Unit { get; set; }

        [JsonProperty("Width2")] public double? Width2 { get; set; }

        [JsonProperty("Width2Unit")] public object Width2Unit { get; set; }

        [JsonProperty("Address")] public string Address { get; set; }

        [JsonProperty("TaxCode")] public string TaxCode { get; set; }

        [JsonProperty("TaxType")] public string TaxType { get; set; }

        [JsonProperty("TaxLiable")] public string TaxLiable { get; set; }

        [JsonProperty("PickStatus")] public string PickStatus { get; set; }

        [JsonProperty("PickQuantity")] public double? PickQuantity { get; set; }

        [JsonProperty("PickListIdNumber")] public object PickListIdNumber { get; set; }

        [JsonProperty("OriginalItem")] public string OriginalItem { get; set; }

        [JsonProperty("BackOrder")] public object BackOrder { get; set; }

        [JsonProperty("FreeText")] public string FreeText { get; set; }

        [JsonProperty("ShippingMethod")] public int? ShippingMethod { get; set; }

        [JsonProperty("POTargetNum")] public object POTargetNum { get; set; }

        [JsonProperty("POTargetEntry")] public string POTargetEntry { get; set; }

        [JsonProperty("POTargetRowNum")] public object POTargetRowNum { get; set; }

        [JsonProperty("CorrectionInvoiceItem")] public string CorrectionInvoiceItem { get; set; }

        [JsonProperty("CorrInvAmountToStock")] public double? CorrInvAmountToStock { get; set; }

        [JsonProperty("CorrInvAmountToDiffAcct")] public double? CorrInvAmountToDiffAcct { get; set; }

        [JsonProperty("AppliedTax")] public double? AppliedTax { get; set; }

        [JsonProperty("AppliedTaxFC")] public double? AppliedTaxFC { get; set; }

        [JsonProperty("AppliedTaxSC")] public double? AppliedTaxSC { get; set; }

        [JsonProperty("WTLiable")] public string WTLiable { get; set; }

        [JsonProperty("DeferredTax")] public string DeferredTax { get; set; }

        [JsonProperty("EqualizationTaxPercent")] public double? EqualizationTaxPercent { get; set; }

        [JsonProperty("TotalEqualizationTax")] public double? TotalEqualizationTax { get; set; }

        [JsonProperty("TotalEqualizationTaxFC")] public double? TotalEqualizationTaxFC { get; set; }

        [JsonProperty("TotalEqualizationTaxSC")] public double? TotalEqualizationTaxSC { get; set; }

        [JsonProperty("NetTaxAmount")] public double? NetTaxAmount { get; set; }

        [JsonProperty("NetTaxAmountFC")] public double? NetTaxAmountFC { get; set; }

        [JsonProperty("NetTaxAmountSC")] public double? NetTaxAmountSC { get; set; }

        [JsonProperty("MeasureUnit")] public string MeasureUnit { get; set; }

        [JsonProperty("UnitsOfMeasurment")] public double? UnitsOfMeasurment { get; set; }

        [JsonProperty("LineTotal")] public double? LineTotal { get; set; }

        [JsonProperty("TaxPercentagePerRow")] public double? TaxPercentagePerRow { get; set; }

        [JsonProperty("TaxTotal")] public double? TaxTotal { get; set; }

        [JsonProperty("ConsumerSalesForecast")] public string ConsumerSalesForecast { get; set; }

        [JsonProperty("ExciseAmount")] public double? ExciseAmount { get; set; }

        [JsonProperty("TaxPerUnit")] public double? TaxPerUnit { get; set; }

        [JsonProperty("TotalInclTax")] public double? TotalInclTax { get; set; }

        [JsonProperty("CountryOrg")] public object CountryOrg { get; set; }

        [JsonProperty("SWW")] public string SWW { get; set; }

        [JsonProperty("TransactionType")] public object TransactionType { get; set; }

        [JsonProperty("DistributeExpense")] public string DistributeExpense { get; set; }

        [JsonProperty("RowTotalFC")] public double? RowTotalFC { get; set; }

        [JsonProperty("RowTotalSC")] public double? RowTotalSC { get; set; }

        [JsonProperty("LastBuyInmPrice")] public double? LastBuyInmPrice { get; set; }

        [JsonProperty("LastBuyDistributeSumFc")] public double? LastBuyDistributeSumFc { get; set; }

        [JsonProperty("LastBuyDistributeSumSc")] public double? LastBuyDistributeSumSc { get; set; }

        [JsonProperty("LastBuyDistributeSum")] public double? LastBuyDistributeSum { get; set; }

        [JsonProperty("StockDistributesumForeign")] public double? StockDistributesumForeign { get; set; }

        [JsonProperty("StockDistributesumSystem")] public double? StockDistributesumSystem { get; set; }

        [JsonProperty("StockDistributesum")] public double? StockDistributesum { get; set; }

        [JsonProperty("StockInmPrice")] public double? StockInmPrice { get; set; }

        [JsonProperty("PickStatusEx")] public string PickStatusEx { get; set; }

        [JsonProperty("TaxBeforeDPM")] public double? TaxBeforeDPM { get; set; }

        [JsonProperty("TaxBeforeDPMFC")] public double? TaxBeforeDPMFC { get; set; }

        [JsonProperty("TaxBeforeDPMSC")] public double? TaxBeforeDPMSC { get; set; }

        [JsonProperty("CFOPCode")] public object CFOPCode { get; set; }

        [JsonProperty("CSTCode")] public object CSTCode { get; set; }

        [JsonProperty("Usage")] public object Usage { get; set; }

        [JsonProperty("TaxOnly")] public string TaxOnly { get; set; }

        [JsonProperty("VisualOrder")] public int? VisualOrder { get; set; }

        [JsonProperty("BaseOpenQuantity")] public double? BaseOpenQuantity { get; set; }

        [JsonProperty("UnitPrice")] public double? UnitPrice { get; set; }

        [JsonProperty("LineStatus")] public string LineStatus { get; set; }

        [JsonProperty("PackageQuantity")] public double? PackageQuantity { get; set; }

        [JsonProperty("Text")] public string Text { get; set; }

        [JsonProperty("LineType")] public string LineType { get; set; }

        [JsonProperty("COGSCostingCode")] public object COGSCostingCode { get; set; }

        [JsonProperty("COGSAccountCode")] public string COGSAccountCode { get; set; }

        [JsonProperty("ChangeAssemlyBoMWarehouse")] public string ChangeAssemlyBoMWarehouse { get; set; }

        [JsonProperty("GrossBuyPrice")] public double? GrossBuyPrice { get; set; }

        [JsonProperty("GrossBase")] public object GrossBase { get; set; }

        [JsonProperty("GrossProfitTotalBasePrice")] public double? GrossProfitTotalBasePrice { get; set; }

        [JsonProperty("CostingCode2")] public string CostingCode2 { get; set; }

        [JsonProperty("CostingCode3")] public string CostingCode3 { get; set; }

        [JsonProperty("CostingCode4")] public string CostingCode4 { get; set; }

        [JsonProperty("CostingCode5")] public string CostingCode5 { get; set; }

        [JsonProperty("ItemDetails")] public object ItemDetails { get; set; }

        [JsonProperty("LocationCode")] public object LocationCode { get; set; }

        [JsonProperty("ActualDeliveryDate")] public object ActualDeliveryDate { get; set; }

        [JsonProperty("RemainingOpenQuantity")] public double? RemainingOpenQuantity { get; set; }

        [JsonProperty("OpenAmount")] public double? OpenAmount { get; set; }

        [JsonProperty("OpenAmountFC")] public double? OpenAmountFC { get; set; }

        [JsonProperty("OpenAmountSC")] public double? OpenAmountSC { get; set; }

        [JsonProperty("ExLineNo")] public object ExLineNo { get; set; }

        [JsonProperty("RequiredDate")] public object RequiredDate { get; set; }

        [JsonProperty("RequiredQuantity")] public double? RequiredQuantity { get; set; }

        [JsonProperty("COGSCostingCode2")] public object COGSCostingCode2 { get; set; }

        [JsonProperty("COGSCostingCode3")] public object COGSCostingCode3 { get; set; }

        [JsonProperty("COGSCostingCode4")] public object COGSCostingCode4 { get; set; }

        [JsonProperty("COGSCostingCode5")] public object COGSCostingCode5 { get; set; }

        [JsonProperty("CSTforIPI")] public object CSTforIPI { get; set; }

        [JsonProperty("CSTforPIS")] public object CSTforPIS { get; set; }

        [JsonProperty("CSTforCOFINS")] public object CSTforCOFINS { get; set; }

        [JsonProperty("CreditOriginCode")] public object CreditOriginCode { get; set; }

        [JsonProperty("WithoutInventoryMovement")] public string WithoutInventoryMovement { get; set; }

        [JsonProperty("AgreementNo")] public object AgreementNo { get; set; }

        [JsonProperty("AgreementRowNumber")] public object AgreementRowNumber { get; set; }

        [JsonProperty("ActualBaseEntry")] public object ActualBaseEntry { get; set; }

        [JsonProperty("ActualBaseLine")] public object ActualBaseLine { get; set; }

        [JsonProperty("DocEntry")] public int? DocEntry { get; set; }

        [JsonProperty("Surpluses")] public double? Surpluses { get; set; }

        [JsonProperty("DefectAndBreakup")] public double? DefectAndBreakup { get; set; }

        [JsonProperty("Shortages")] public double? Shortages { get; set; }

        [JsonProperty("ConsiderQuantity")] public string ConsiderQuantity { get; set; }

        [JsonProperty("PartialRetirement")] public string PartialRetirement { get; set; }

        [JsonProperty("RetirementQuantity")] public double? RetirementQuantity { get; set; }

        [JsonProperty("RetirementAPC")] public double? RetirementAPC { get; set; }

        [JsonProperty("ThirdParty")] public string ThirdParty { get; set; }

        [JsonProperty("ExpenseType")] public object ExpenseType { get; set; }

        [JsonProperty("ReceiptNumber")] public object ReceiptNumber { get; set; }

        [JsonProperty("ExpenseOperationType")] public object ExpenseOperationType { get; set; }

        [JsonProperty("FederalTaxID")] public object FederalTaxID { get; set; }

        [JsonProperty("StgSeqNum")] public object StgSeqNum { get; set; }

        [JsonProperty("StgEntry")] public object StgEntry { get; set; }

        [JsonProperty("StgDesc")] public object StgDesc { get; set; }

        [JsonProperty("UoMEntry")] public int? UoMEntry { get; set; }

        [JsonProperty("UoMCode")] public string UoMCode { get; set; }

        [JsonProperty("InventoryQuantity")] public double? InventoryQuantity { get; set; }

        [JsonProperty("RemainingOpenInventoryQuantity")] public double? RemainingOpenInventoryQuantity { get; set; }

        [JsonProperty("ParentLineNum")] public object ParentLineNum { get; set; }

        [JsonProperty("Incoterms")] public int? Incoterms { get; set; }

        [JsonProperty("TransportMode")] public int? TransportMode { get; set; }

        [JsonProperty("ItemType")] public string ItemType { get; set; }

        [JsonProperty("ChangeInventoryQuantityIndependently")] public string ChangeInventoryQuantityIndependently { get; set; }

        [JsonProperty("FreeOfChargeBP")] public string FreeOfChargeBP { get; set; }

        [JsonProperty("SACEntry")] public object SACEntry { get; set; }

        [JsonProperty("HSNEntry")] public object HSNEntry { get; set; }

        [JsonProperty("GrossPrice")] public double? GrossPrice { get; set; }

        [JsonProperty("GrossTotal")] public double? GrossTotal { get; set; }

        [JsonProperty("GrossTotalFC")] public double? GrossTotalFC { get; set; }

        [JsonProperty("GrossTotalSC")] public double? GrossTotalSC { get; set; }

        [JsonProperty("NCMCode")] public int? NCMCode { get; set; }

        [JsonProperty("ShipFromCode")] public object ShipFromCode { get; set; }

        [JsonProperty("ShipFromDescription")] public object ShipFromDescription { get; set; }

        //[JsonProperty("U_BPP_CTAD")] public string UBPPCTAD { get; set; }

        //[JsonProperty("U_BPP_OPER")] public string UBPPOPER { get; set; }

        //[JsonProperty("U_tipoOpT12")] public string UTipoOpT12 { get; set; }

        //[JsonProperty("U_VS_DISPSTK")] public object UVSDISPSTK { get; set; }

        //[JsonProperty("U_VS_SERDOC")] public object UVSSERDOC { get; set; }

        //[JsonProperty("U_VS_FECEMI")] public object UVSFECEMI { get; set; }

        //[JsonProperty("U_VS_TIPDOC")] public object UVSTIPDOC { get; set; }

        //[JsonProperty("U_VS_CDMMOV")] public object UVSCDMMOV { get; set; }

        //[JsonProperty("U_VS_MOTMOV")] public object UVSMOTMOV { get; set; }

        //[JsonProperty("U_VS_TIPSAP")] public string UVSTIPSAP { get; set; }

        //[JsonProperty("U_VS_DOCSAP")] public object UVSDOCSAP { get; set; }

        //[JsonProperty("U_VS_DOCNUM")] public object UVSDOCNUM { get; set; }

        //[JsonProperty("U_VS_MNTPRCP")] public double? UVSMNTPRCP { get; set; }

        //[JsonProperty("U_VS_MNTCBRD")] public double? UVSMNTCBRD { get; set; }

        //[JsonProperty("U_VS_CODPRCP")] public object UVSCODPRCP { get; set; }

        //[JsonProperty("U_VS_GRPPRCP")] public object UVSGRPPRCP { get; set; }

        //[JsonProperty("U_VS_DOCSI")] public string UVSDOCSI { get; set; }

        //[JsonProperty("U_VS_DOCTOTAL")] public double? UVSDOCTOTAL { get; set; }

        //[JsonProperty("U_VS_ONEROSO")] public string UVSONEROSO { get; set; }

        //[JsonProperty("U_VS_TIPISC")] public object UVSTIPISC { get; set; }

        //[JsonProperty("U_VS_TIPAFE")] public object UVSTIPAFE { get; set; }

        //[JsonProperty("U_VS_T12IN")] public object UVST12IN { get; set; }

        //[JsonProperty("U_VS_GLNORG")] public object UVSGLNORG { get; set; }

        //[JsonProperty("U_VS_DIRORG")] public object UVSDIRORG { get; set; }

        //[JsonProperty("U_VS_GLNDEST")] public object UVSGLNDEST { get; set; }

        //[JsonProperty("U_VS_DIRDEST")] public object UVSDIRDEST { get; set; }

        //[JsonProperty("U_VS_DTVIAJE")] public object UVSDTVIAJE { get; set; }

        //[JsonProperty("U_VS_VLTRANS")] public object UVSVLTRANS { get; set; }

        //[JsonProperty("U_VS_VLEFEC")] public object UVSVLEFEC { get; set; }

        //[JsonProperty("U_VS_VLUTIL")] public object UVSVLUTIL { get; set; }

        //[JsonProperty("U_VS_CONFVEH")] public object UVSCONFVEH { get; set; }

        //[JsonProperty("U_VS_CGUTMS")] public object UVSCGUTMS { get; set; }

        //[JsonProperty("U_VS_CGEFEMS")] public object UVSCGEFEMS { get; set; }

        //[JsonProperty("U_VS_VLTM")] public object UVSVLTM { get; set; }

        //[JsonProperty("U_VS_VLCGUTL")] public object UVSVLCGUTL { get; set; }

        //[JsonProperty("U_VS_FCTRET")] public string UVSFCTRET { get; set; }

        //[JsonProperty("U_VS_PRCREF")] public object UVSPRCREF { get; set; }

        //[JsonProperty("U_VS_HIMPC")] public double? UVSHIMPC { get; set; }

        //[JsonProperty("U_VS_HIMPS")] public double? UVSHIMPS { get; set; }

        //[JsonProperty("U_VS_DOCTRM")] public object UVSDOCTRM { get; set; }

        //[JsonProperty("U_VS_IT_CODEXT")] public object UVSITCODEXT { get; set; }

        //[JsonProperty("U_VS_IT_LINEXT")] public object UVSITLINEXT { get; set; }

        public Dictionary<string, object> AdditionalDataDetail { get; set; } = new Dictionary<string, object>();

        [JsonProperty("LineTaxJurisdictions")] public List<PuchaseOrderLineTaxJurisdiction> LineTaxJurisdictions { get; set; }

        [JsonProperty("DocumentLineAdditionalExpenses")] public List<object> DocumentLineAdditionalExpenses { get; set; }

        [JsonProperty("WithholdingTaxLines")] public List<object> WithholdingTaxLines { get; set; }

        [JsonProperty("SerialNumbers")] public List<object> SerialNumbers { get; set; }

        [JsonProperty("BatchNumbers")] public List<object> BatchNumbers { get; set; }

        [JsonProperty("DocumentLinesBinAllocations")] public List<object> DocumentLinesBinAllocations { get; set; }
        public string BDDestino { get; set; }
    }
}