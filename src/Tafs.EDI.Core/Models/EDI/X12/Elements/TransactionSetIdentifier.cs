//
//  TransactionSetIdentifier.cs
//
//  Author:
//       Devin Duanne <dduanne@tafs.com>
//
//  Copyright (c) Tafs, LLC.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using JetBrains.Annotations;
using Tafs.EDI.Core.Annotations.EDI;

namespace Tafs.EDI.Core.Models.EDI.X12.Elements
{
    /// <summary>
    /// Defines an identifier for the appropriate transaction set definition.
    /// </summary>
    /// <seealso href="https://www.stedi.com/edi/x12/element/143"/>
    [PublicAPI]
    [EdiElement(EdiFormat.X12, 8030, 143)]
    public enum TransactionSetIdentifier
    {
        /// <summary>
        /// Insurance Plan Description.
        /// </summary>
        InsurancePlanDescription = 100,

        /// <summary>
        /// Name and Address Lists.
        /// </summary>
        NameAndAddressLists = 101,

        /// <summary>
        /// Associated Data.
        /// </summary>
        AssociatedData = 102,

        /// <summary>
        /// Abandoned Property Filings.
        /// </summary>
        AbandonedPropertyFilings = 103,

        /// <summary>
        /// Air Shipment Information.
        /// </summary>
        AirShipmentInformation = 104,

        /// <summary>
        /// Business Entity Filings.
        /// </summary>
        BusinessEntityFilings = 105,

        /// <summary>
        /// Motor Carrier Rate Proposal.
        /// </summary>
        MotorCarrierRateProposal = 106,

        /// <summary>
        /// Request for Motor Carrier Rate Proposal.
        /// </summary>
        RequestForMotorCarrierRateProposal = 107,

        /// <summary>
        /// Response to a Motor Carrier Rate Proposal.
        /// </summary>
        ResponseToAMotorCarrierRateProposal = 108,

        /// <summary>
        /// Vessel Content Details.
        /// </summary>
        VesselContentDetails = 109,

        /// <summary>
        /// Air Freight Details and Invoice.
        /// </summary>
        AirFreightDetailsAndInvoice = 110,

        /// <summary>
        /// Individual Insurance Policy and Client Information.
        /// </summary>
        IndividualInsurancePolicyAndClientInformation = 111,

        /// <summary>
        /// Property Damage Report.
        /// </summary>
        PropertyDamageReport = 112,

        /// <summary>
        /// Election Campaign and Lobbyist Reporting.
        /// </summary>
        ElectionCampaignAndLobbyistReporting = 113,

        /// <summary>
        /// Vehicle Shipping Order.
        /// </summary>
        VehicleShippingOrder = 120,

        /// <summary>
        /// Vehicle Service.
        /// </summary>
        VehicleService = 121,

        /// <summary>
        /// Vehicle Damage.
        /// </summary>
        VehicleDamage = 124,

        /// <summary>
        /// Multilevel Railcar Load Details.
        /// </summary>
        MultilevelRailcarLoadDetails = 125,

        /// <summary>
        /// Vehicle Application Advice.
        /// </summary>
        VehicleApplicationAdvice = 126,

        /// <summary>
        /// Vehicle Baying Order.
        /// </summary>
        VehicleBayingOrder = 127,

        /// <summary>
        /// Dealer Information.
        /// </summary>
        DealerInformation = 128,

        /// <summary>
        /// Vehicle Carrier Rate Update.
        /// </summary>
        VehicleCarrierRateUpdate = 129,

        /// <summary>
        /// Student Educational Record (Transcript).
        /// </summary>
        StudentEducationalRecord = 130,

        /// <summary>
        /// Student Educational Record (Transcript) Acknowledgment.
        /// </summary>
        StudentEducationalRecordAcknowledgment = 131,

        /// <summary>
        /// Human Resource Information.
        /// </summary>
        HumanResourceInformation = 132,

        /// <summary>
        /// Educational Institution Record.
        /// </summary>
        EducationalInstitutionRecord = 133,

        /// <summary>
        /// Student Aid Origination Record.
        /// </summary>
        StudentAidOriginationRecord = 135,

        /// <summary>
        /// Educational Testing and Prospect Request and Report.
        /// </summary>
        EducationalTestingAndProspectRequestAndReport = 138,

        /// <summary>
        /// Student Loan Guarantee Result.
        /// </summary>
        StudentLoanGuaranteeResult = 139,

        /// <summary>
        /// Product Registration.
        /// </summary>
        ProductRegistration = 140,

        /// <summary>
        /// Product Service Claim Response.
        /// </summary>
        ProductServiceClaimResponse = 141,

        /// <summary>
        /// Product Service Claim.
        /// </summary>
        ProductServiceClaim = 142,

        /// <summary>
        /// Product Service Notification.
        /// </summary>
        ProductServiceNotification = 143,

        /// <summary>
        /// Student Loan Transfer and Status Verification.
        /// </summary>
        StudentLoanTransferAndStatusVerification = 144,

        /// <summary>
        /// Request for Student Educational Record (Transcript).
        /// </summary>
        RequestForStudentEducationalRecord = 146,

        /// <summary>
        /// Response to Request for Student Educational Record (Transcript).
        /// </summary>
        ResponseToRequestForStudentEducationalRecord = 147,

        /// <summary>
        /// Report of Injury, Illness or Incident.
        /// </summary>
        ReportOfInjuryIllnessOrIncident = 148,

        /// <summary>
        /// Notice of Tax Adjustment or Assessment.
        /// </summary>
        NoticeOfTaxAdjustmentOrAssessment = 149,

        /// <summary>
        /// Tax Rate Notification.
        /// </summary>
        TaxRateNotification = 150,

        /// <summary>
        /// Electronic Filing of Tax Return Data Acknowledgment.
        /// </summary>
        ElectronicFilingOfTaxReturnDataAcknowledgment = 151,

        /// <summary>
        /// Statistical Government Information.
        /// </summary>
        StatisticalGovernmentInformation = 152,

        /// <summary>
        /// Unemployment Insurance Tax Claim or Charge Information.
        /// </summary>
        UnemploymentInsuranceTaxClaimOrChargeInformation = 153,

        /// <summary>
        /// Secured Interest Filing.
        /// </summary>
        SecuredInterestFiling = 154,

        /// <summary>
        /// Business Credit Report.
        /// </summary>
        BusinessCreditReport = 155,

        /// <summary>
        /// Notice of Power of Attorney.
        /// </summary>
        NoticeOfPowerOfAttorney = 157,

        /// <summary>
        /// Tax Jurisdiction Sourcing.
        /// </summary>
        TaxJurisdictionSourcing = 158,

        /// <summary>
        /// Motion Picture Booking Confirmation.
        /// </summary>
        MotionPictureBookingConfirmation = 159,

        /// <summary>
        /// Transportation Automatic Equipment Identification.
        /// </summary>
        TransportationAutomaticEquipmentIdentification = 160,

        /// <summary>
        /// Train Sheet.
        /// </summary>
        TrainSheet = 161,

        /// <summary>
        /// Transportation Appointment Schedule Information.
        /// </summary>
        TransportationAppointmentScheduleInformation = 163,

        /// <summary>
        /// Revenue Receipts Statement.
        /// </summary>
        RevenueReceiptsStatement = 170,

        /// <summary>
        /// Court and Law Enforcement Notice.
        /// </summary>
        CourtAndLawEnforcementNotice = 175,

        /// <summary>
        /// Court Submission.
        /// </summary>
        CourtSubmission = 176,

        /// <summary>
        /// Environmental Compliance Reporting.
        /// </summary>
        EnvironmentalComplianceReporting = 179,

        /// <summary>
        /// Return Merchandise Authorization and Notification.
        /// </summary>
        ReturnMerchandiseAuthorizationAndNotification = 180,

        /// <summary>
        /// Royalty Regulatory Report.
        /// </summary>
        RoyaltyRegulatoryReport = 185,

        /// <summary>
        /// Insurance Underwriting Requirements Reporting.
        /// </summary>
        InsuranceUnderwritingRequirementsReporting = 186,

        /// <summary>
        /// Premium Audit Request and Return.
        /// </summary>
        PremiumAuditRequestAndReturn = 187,

        /// <summary>
        /// Educational Course Inventory.
        /// </summary>
        EducationalCourseInventory = 188,

        /// <summary>
        /// Application for Admission to Educational Institutions.
        /// </summary>
        ApplicationForAdmissionToEducationalInstitutions = 189,

        /// <summary>
        /// Student Enrollment Verification.
        /// </summary>
        StudentEnrollmentVerification = 190,

        /// <summary>
        /// Student Loan Pre-Claims and Claims.
        /// </summary>
        StudentLoanPreClaimsAndClaims = 191,

        /// <summary>
        /// Grant or Assistance Application.
        /// </summary>
        GrantOrAssistanceApplication = 194,

        /// <summary>
        /// Federal Communications Commission (FCC) License Application.
        /// </summary>
        FederalCommunicationsCommissionLicenseApplication = 195,

        /// <summary>
        /// Contractor Cost Data Reporting.
        /// </summary>
        ContractorCostDataReporting = 196,

        /// <summary>
        /// Real Estate Title Evidence.
        /// </summary>
        RealEstateTitleEvidence = 197,

        /// <summary>
        /// Loan Verification Information.
        /// </summary>
        LoanVerificationInformation = 198,

        /// <summary>
        /// Real Estate Settlement Information.
        /// </summary>
        RealEstateSettlementInformation = 199,

        /// <summary>
        /// Mortgage Credit Report.
        /// </summary>
        MortgageCreditReport = 200,

        /// <summary>
        /// Residential Loan Application.
        /// </summary>
        ResidentialLoanApplication = 201,

        /// <summary>
        /// Secondary Mortgage Market Loan Delivery.
        /// </summary>
        SecondaryMortgageMarketLoanDelivery = 202,

        /// <summary>
        /// Secondary Mortgage Market Investor Report.
        /// </summary>
        SecondaryMortgageMarketInvestorReport = 203,

        /// <summary>
        /// Motor Carrier Load Tender.
        /// </summary>
        MotorCarrierLoadTender = 204,

        /// <summary>
        /// Mortgage Note.
        /// </summary>
        MortgageNote = 205,

        /// <summary>
        /// Real Estate Inspection.
        /// </summary>
        RealEstateInspection = 206,

        /// <summary>
        /// Motor Carrier Freight Details and Invoice.
        /// </summary>
        MotorCarrierFreightDetailsAndInvoice = 210,

        /// <summary>
        /// Motor Carrier Bill of Lading.
        /// </summary>
        MotorCarrierBillOfLading = 211,

        /// <summary>
        /// Motor Carrier Delivery Trailer Manifest.
        /// </summary>
        MotorCarrierDeliveryTrailerManifest = 212,

        /// <summary>
        /// Motor Carrier Shipment Status Inquiry.
        /// </summary>
        MotorCarrierShipmentStatusInquiry = 213,

        /// <summary>
        /// Transportation Carrier Shipment Status Message.
        /// </summary>
        TransportationCarrierShipmentStatusMessage = 214,

        /// <summary>
        /// Motor Carrier Pickup Manifest.
        /// </summary>
        MotorCarrierPickupManifest = 215,

        /// <summary>
        /// Motor Carrier Shipment Pickup Notification.
        /// </summary>
        MotorCarrierShipmentPickupNotification = 216,

        /// <summary>
        /// Motor Carrier Loading and Route Guide.
        /// </summary>
        MotorCarrierLoadingAndRouteGuide = 217,

        /// <summary>
        /// Logistics Service Request.
        /// </summary>
        LogisticsServiceRequest = 219,

        /// <summary>
        /// Logistics Service Response.
        /// </summary>
        LogisticsServiceResponse = 220,

        /// <summary>
        /// Cartage Work Assignment.
        /// </summary>
        CartageWorkAssignment = 222,

        /// <summary>
        /// Consolidators Freight Bill and Invoice.
        /// </summary>
        ConsolidatorsFreightBillAndInvoice = 223,

        /// <summary>
        /// Motor Carrier Summary Freight Bill Manifest.
        /// </summary>
        MotorCarrierSummaryFreightBillManifest = 224,

        /// <summary>
        /// Response to a Cartage Work Assignment.
        /// </summary>
        ResponseToACartageWorkAssignment = 225,

        /// <summary>
        /// Trailer Usage Report.
        /// </summary>
        TrailerUsageReport = 227,

        /// <summary>
        /// Equipment Inspection Report.
        /// </summary>
        EquipmentInspectionReport = 228,

        /// <summary>
        /// Motor Carrier Package Status.
        /// </summary>
        MotorCarrierPackageStatus = 240,

        /// <summary>
        /// Data Status Tracking.
        /// </summary>
        DataStatusTracking = 242,

        /// <summary>
        /// Product Source Information.
        /// </summary>
        ProductSourceInformation = 244,

        /// <summary>
        /// Real Estate Tax Service Response.
        /// </summary>
        RealEstateTaxServiceResponse = 245,

        /// <summary>
        /// Account Assignment/Inquiry and Service/Status.
        /// </summary>
        AccountAssignmentInquiryAndServiceStatus = 248,

        /// <summary>
        /// Animal Toxicological Data.
        /// </summary>
        AnimalToxicologicalData = 249,

        /// <summary>
        /// Purchase Order Shipment Management Document.
        /// </summary>
        PurchaseOrderShipmentManagementDocument = 250,

        /// <summary>
        /// Pricing Support.
        /// </summary>
        PricingSupport = 251,

        /// <summary>
        /// Insurance Producer Administration.
        /// </summary>
        InsuranceProducerAdministration = 252,

        /// <summary>
        /// Underwriting Information Services.
        /// </summary>
        UnderwritingInformationServices = 255,

        /// <summary>
        /// Periodic Compensation.
        /// </summary>
        PeriodicCompensation = 256,

        /// <summary>
        /// Residential Mortgage Insurance Explanation of Benefits.
        /// </summary>
        ResidentialMortgageInsuranceExplanationOfBenefits = 259,

        /// <summary>
        /// Application for Mortgage Insurance Benefits.
        /// </summary>
        /// <remarks>
        /// A claim filed for mortgage insurance benefits.
        /// </remarks>
        ApplicationForMortgageInsuranceBenefits = 260,

        /// <summary>
        /// Real Estate Information Request.
        /// </summary>
        RealEstateInformationRequest = 261,

        /// <summary>
        /// Real Estate Information Report.
        /// </summary>
        RealEstateInformationReport = 262,

        /// <summary>
        /// Residential Mortgage Insurance Application Response.
        /// </summary>
        ResidentialMortgageInsuranceApplicationResponse = 263,

        /// <summary>
        /// Mortgage Loan Default Status.
        /// </summary>
        MortgageLoanDefaultStatus = 264,

        /// <summary>
        /// Real Estate Title Insurance Services Order.
        /// </summary>
        RealEstateTitleInsuranceServicesOrder = 265,

        /// <summary>
        /// Mortgage or Property Record Change Notification.
        /// </summary>
        MortgageOrPropertyRecordChangeNotification = 266,

        /// <summary>
        /// Individual Life, Annuity and Disability Application.
        /// </summary>
        IndividualLifeAnnuityAndDisabilityApplication = 267,

        /// <summary>
        /// Annuity Activity.
        /// </summary>
        AnnuityActivity = 268,

        /// <summary>
        /// Health Care Benefit Coordination Verification.
        /// </summary>
        HealthCareBenefitCoordinationVerification = 269,

        /// <summary>
        /// Eligibility, Coverage, or Benefit Inquiry.
        /// </summary>
        EligibilityCoverageOrBenefitInquiry = 270,

        /// <summary>
        /// Eligibility, Coverage, or Benefit Information.
        /// </summary>
        EligibilityCoverageOrBenefitInformation = 271,

        /// <summary>
        /// Property and Casualty Loss Notification.
        /// </summary>
        PropertyAndCasualtyLossNotification = 272,

        /// <summary>
        /// Insurance/Annuity Application Status.
        /// </summary>
        InsuranceAnnuityApplicationStatus = 273,

        /// <summary>
        /// Healthcare Provider Information.
        /// </summary>
        HealthcareProviderInformation = 274,

        /// <summary>
        /// Patient Information.
        /// </summary>
        PatientInformation = 275,

        /// <summary>
        /// Health Care Claim Status Request.
        /// </summary>
        HealthCareClaimStatusRequest = 276,

        /// <summary>
        /// Health Care Information Status Notification.
        /// </summary>
        HealthCareInformationStatusNotification = 277,

        /// <summary>
        /// Health Care Services Review Information.
        /// </summary>
        HealthCareServicesReviewInformation = 278,

        /// <summary>
        /// Voter Registration Information.
        /// </summary>
        VoterRegistrationInformation = 280,

        /// <summary>
        /// Tax or Fee Exemption Certification.
        /// </summary>
        TaxOrFeeExemptionCertification = 283,

        /// <summary>
        /// Commercial Vehicle Safety Reports.
        /// </summary>
        CommercialVehicleSafetyReports = 284,

        /// <summary>
        /// Commercial Vehicle Safety and Credentials Information Exchange.
        /// </summary>
        CommercialVehicleSafetyAndCredentialsInformationExchange = 285,

        /// <summary>
        /// Commercial Vehicle Credentials.
        /// </summary>
        CommercialVehicleCredentials = 286,

        /// <summary>
        /// Wage Determination.
        /// </summary>
        WageDetermination = 288,

        /// <summary>
        /// Cooperative Advertising Agreements.
        /// </summary>
        CooperativeAdvertisingAgreements = 290,

        /// <summary>
        /// Reservation (Booking Request) (Ocean).
        /// </summary>
        ReservationBookingRequestOcean = 300,

        /// <summary>
        /// Confirmation (Ocean).
        /// </summary>
        ConfirmationOcean = 301,

        /// <summary>
        /// Booking Cancellation (Ocean).
        /// </summary>
        BookingCancellationOcean = 303,

        /// <summary>
        /// Shipping Instructions.
        /// </summary>
        ShippingInstructions = 304,

        /// <summary>
        /// Customs Manifest.
        /// </summary>
        CustomsManifest = 309,

        /// <summary>
        /// Freight Receipt and Invoice (Ocean).
        /// </summary>
        FreightReceiptAndInvoiceOcean = 310,

        /// <summary>
        /// Canada Customs Information.
        /// </summary>
        CanadaCustomsInformation = 311,

        /// <summary>
        /// Arrival Notice (Ocean).
        /// </summary>
        ArrivalNoticeOcean = 312,

        /// <summary>
        /// Shipment Status Inquiry (Ocean).
        /// </summary>
        ShipmentStatusInquiryOcean = 313,

        /// <summary>
        /// Status Details (Ocean).
        /// </summary>
        StatusDetailsOcean = 315,

        /// <summary>
        /// Delivery/Pickup Order.
        /// </summary>
        DeliveryPickupOrder = 317,

        /// <summary>
        /// Terminal Information.
        /// </summary>
        TerminalInformation = 319,

        /// <summary>
        /// Terminal Operations and Intermodal Ramp Activity.
        /// </summary>
        TerminalOperationsAndIntermodalRampActivity = 322,

        /// <summary>
        /// Vessel Schedule and Itinerary (Ocean).
        /// </summary>
        VesselScheduleAndItineraryOcean = 323,

        /// <summary>
        /// Vessel Stow Plan (Ocean).
        /// </summary>
        VesselStowPlanOcean = 324,

        /// <summary>
        /// Consolidation of Goods In Container.
        /// </summary>
        ConsolidationOfGoodsInContainer = 325,

        /// <summary>
        /// Consignment Summary List.
        /// </summary>
        ConsignmentSummaryList = 326,

        /// <summary>
        /// Customs Status Information.
        /// </summary>
        CustomsStatusInformation = 350,

        /// <summary>
        /// Customs Carrier General Order Status.
        /// </summary>
        CustomsCarrierGeneralOrderStatus = 352,

        /// <summary>
        /// Customs Events Advisory Details.
        /// </summary>
        CustomsEventsAdvisoryDetails = 353,

        /// <summary>
        /// Customs Automated Manifest Archive Status.
        /// </summary>
        CustomsAutomatedManifestArchiveStatus = 354,

        /// <summary>
        /// Customs Acceptance/Rejection.
        /// </summary>
        CustomsAcceptanceRejection = 355,

        /// <summary>
        /// Customs Permit to Transfer Request.
        /// </summary>
        CustomsPermitToTransferRequest = 356,

        /// <summary>
        /// Customs In-Bond Information.
        /// </summary>
        CustomsInBondInformation = 357,

        /// <summary>
        /// Customs Consist Information.
        /// </summary>
        CustomsConsistInformation = 358,

        /// <summary>
        /// Customs Customer Profile Management.
        /// </summary>
        CustomsCustomerProfileManagement = 359,

        /// <summary>
        /// Carrier Interchange Agreement (Ocean).
        /// </summary>
        CarrierInterchangeAgreementOcean = 361,

        /// <summary>
        /// Cargo Insurance Advice of Shipment.
        /// </summary>
        CargoInsuranceAdviceOfShipment = 362,

        /// <summary>
        /// Rail Carrier Shipment Information.
        /// </summary>
        RailCarrierShipmentInformation = 404,

        /// <summary>
        /// Rail Carrier Freight Details and Invoice.
        /// </summary>
        RailCarrierFreightDetailsAndInvoice = 410,

        /// <summary>
        /// Trailer or Container Repair Billing.
        /// </summary>
        TrailerOrContainerRepairBilling = 412,

        /// <summary>
        /// Rail Carhire Settlements.
        /// </summary>
        RailCarhireSettlements = 414,

        /// <summary>
        /// Rail Carrier Waybill Interchange.
        /// </summary>
        RailCarrierWaybillInterchange = 417,

        /// <summary>
        /// Rail Advance Interchange Consist.
        /// </summary>
        RailAdvanceInterchangeConsist = 418,

        /// <summary>
        /// Advance Car Disposition.
        /// </summary>
        AdvanceCarDisposition = 419,

        /// <summary>
        /// Car Handling Information.
        /// </summary>
        CarHandlingInformation = 420,

        /// <summary>
        /// Estimated Time of Arrival and Car Scheduling.
        /// </summary>
        EstimatedTimeOfArrivalAndCarScheduling = 421,

        /// <summary>
        /// Equipment Order.
        /// </summary>
        EquipmentOrder = 422,

        /// <summary>
        /// Rail Industrial Switch List.
        /// </summary>
        RailIndustrialSwitchList = 423,

        /// <summary>
        /// Rail Carrier Services Settlement.
        /// </summary>
        RailCarrierServicesSettlement = 424,

        /// <summary>
        /// Rail Waybill Request.
        /// </summary>
        RailWaybillRequest = 425,

        /// <summary>
        /// Rail Revenue Waybill.
        /// </summary>
        RailRevenueWaybill = 426,

        /// <summary>
        /// Railroad Retirement Activity.
        /// </summary>
        RailroadRetirementActivity = 429,

        /// <summary>
        /// Railroad Station Master File.
        /// </summary>
        RailroadStationMasterFile = 431,

        /// <summary>
        /// Rail Car Hire Rate Negotiation.
        /// </summary>
        RailCarHireRateNegotiation = 432,

        /// <summary>
        /// Railroad Reciprocal Switch File.
        /// </summary>
        RailroadReciprocalSwitchFile = 433,

        /// <summary>
        /// Railroad Mark Register Update Activity.
        /// </summary>
        RailroadMarkRegisterUpdateActivity = 434,

        /// <summary>
        /// Standard Transportation Commodity Code Master.
        /// </summary>
        StandardTransportationCommodityCodeMaster = 435,

        /// <summary>
        /// Locomotive Information.
        /// </summary>
        LocomotiveInformation = 436,

        /// <summary>
        /// Railroad Junctions and Interchanges Activity.
        /// </summary>
        RailroadJunctionsAndInterchangesActivity = 437,

        /// <summary>
        /// Shipment Weights.
        /// </summary>
        ShipmentWeights = 440,

        /// <summary>
        /// Railroad Event Report.
        /// </summary>
        RailroadEventReport = 451,

        /// <summary>
        /// Railroad Problem Log Inquiry or Advice.
        /// </summary>
        RailroadProblemLogInquiryOrAdvice = 452,

        /// <summary>
        /// Railroad Service Commitment Advice.
        /// </summary>
        RailroadServiceCommitmentAdvice = 453,

        /// <summary>
        /// Railroad Parameter Trace Registration.
        /// </summary>
        RailroadParameterTraceRegistration = 455,

        /// <summary>
        /// Railroad Equipment Inquiry or Advice.
        /// </summary>
        RailroadEquipmentInquiryOrAdvice = 456,

        /// <summary>
        /// Railroad Price Distribution Request or Response.
        /// </summary>
        RailroadPriceDistributionRequestOrResponse = 460,

        /// <summary>
        /// Rail Rate Reply.
        /// </summary>
        RailRateReply = 463,

        /// <summary>
        /// Rate Request.
        /// </summary>
        RateRequest = 466,

        /// <summary>
        /// Rate Docket Journal Log.
        /// </summary>
        RateDocketJournalLog = 468,

        /// <summary>
        /// Railroad Clearance.
        /// </summary>
        RailroadClearance = 470,

        /// <summary>
        /// Rail Route File Maintenance.
        /// </summary>
        RailRouteFileMaintenance = 475,

        /// <summary>
        /// Ratemaking Action.
        /// </summary>
        RatemakingAction = 485,

        /// <summary>
        /// Rate Docket Expiration.
        /// </summary>
        RateDocketExpiration = 486,

        /// <summary>
        /// Rate Group Definition.
        /// </summary>
        RateGroupDefinition = 490,

        /// <summary>
        /// Miscellaneous Rates.
        /// </summary>
        MiscellaneousRates = 492,

        /// <summary>
        /// Rail Scale Rates.
        /// </summary>
        RailScaleRates = 494,

        /// <summary>
        /// Medical Event Reporting.
        /// </summary>
        MedicalEventReporting = 500,

        /// <summary>
        /// Vendor Performance Review.
        /// </summary>
        VendorPerformanceReview = 501,

        /// <summary>
        /// Pricing History.
        /// </summary>
        PricingHistory = 503,

        /// <summary>
        /// Clauses and Provisions.
        /// </summary>
        ClausesAndProvisions = 504,

        /// <summary>
        /// Requisition.
        /// </summary>
        /// <remarks>
        /// Transaction set for ordering equipment and material from a supply
        /// distribution system; this can also be used to inquire about, amend,
        /// or terminate the original order.
        /// </remarks>
        Requisition = 511,

        /// <summary>
        /// Material Obligation Validation.
        /// </summary>
        /// <remarks>
        /// Transaction set for verifying the continued need for open orders. Can
        /// also be used to confirm open order quantities and request reinstatement
        /// of previously cancelled open orders.
        /// </remarks>
        MaterialObligationValidation = 517,

        /// <summary>
        /// Income or Asset Offset.
        /// </summary>
        IncomeOrAssetOffset = 521,

        /// <summary>
        /// Material Due-In and Receipt.
        /// </summary>
        /// <remarks>
        /// Transaction set for reporting material dues-in, anticipated receipts,
        /// and receipts.
        /// </remarks>
        MaterialDueInAndReceipt = 527,

        /// <summary>
        /// Logistics Reassignment.
        /// </summary>
        /// <remarks>
        /// Transaction set for reporting information needed by a new manager when
        /// transferring inventory management responsibility between organizations.
        /// </remarks>
        LogisticsReassignment = 536,

        /// <summary>
        /// Notice of Employment Status.
        /// </summary>
        NoticeOfEmploymentStatus = 540,

        /// <summary>
        /// Contract Abstract.
        /// </summary>
        /// <remarks>
        /// A summary of the essential elements of a contract, sufficient to enable
        /// the contract administration process to commence.
        /// </remarks>
        ContractAbstract = 561,

        /// <summary>
        /// Contract Completion Status.
        /// </summary>
        /// <remarks>
        /// Transaction set for reporting the administrative closure status of
        /// physically completed contracts.
        /// </remarks>
        ContractCompletionStatus = 567,

        /// <summary>
        /// Contract Payment Management Report.
        /// </summary>
        ContractPaymentManagementReport = 568,

        /// <summary>
        /// Customs Export Shipment Information.
        /// </summary>
        CustomsExportShipmentInformation = 601,

        /// <summary>
        /// Transportation Equipment Registration.
        /// </summary>
        TransportationEquipmentRegistration = 603,

        /// <summary>
        /// Excavation Communication.
        /// </summary>
        ExcavationCommunication = 620,

        /// <summary>
        /// Well Information.
        /// </summary>
        WellInformation = 625,

        /// <summary>
        /// Maintenance Service Order.
        /// </summary>
        MaintenanceServiceOrder = 650,

        /// <summary>
        /// Intermodal Group Loading Plan.
        /// </summary>
        IntermodalGroupLoadingPlan = 715,

        /// <summary>
        /// Request for Routing Instructions.
        /// </summary>
        RequestForRoutingInstructions = 753,

        /// <summary>
        /// Routing Instructions.
        /// </summary>
        RoutingInstructions = 754,

        /// <summary>
        /// Contract Pricing Proposal.
        /// </summary>
        ContractPricingProposal = 805,

        /// <summary>
        /// Project Schedule Reporting.
        /// </summary>
        ProjectScheduleReporting = 806,

        /// <summary>
        /// Invoice.
        /// </summary>
        Invoice = 810,

        /// <summary>
        /// Consolidated Service Invoice/Statement.
        /// </summary>
        ConsolidatedServiceInvoiceStatement = 811,

        /// <summary>
        /// Credit/Debit Adjustment.
        /// </summary>
        CreditDebitAdjustment = 812,

        /// <summary>
        /// Electronic Filing of Tax Return Data.
        /// </summary>
        ElectronicFilingOfTaxReturnData = 813,

        /// <summary>
        /// General Request, Response or Confirmation.
        /// </summary>
        GeneralRequestResponseOrConfirmation = 814,

        /// <summary>
        /// Cryptographic Service Message.
        /// </summary>
        CryptographicServiceMessage = 815,

        /// <summary>
        /// Organizational Relationships.
        /// </summary>
        OrganizationalRelationships = 816,

        /// <summary>
        /// Commission Sales Report.
        /// </summary>
        CommissionSalesReport = 818,

        /// <summary>
        /// Joint Interest Billing and Operating Expense Statement.
        /// </summary>
        JointInterestBillingAndOperatingExpenseStatement = 819,

        /// <summary>
        /// Payment Order/Remittance Advice.
        /// </summary>
        PaymentOrderRemittanceAdvice = 820,

        /// <summary>
        /// Financial Information Reporting.
        /// </summary>
        FinancialInformationReporting = 821,

        /// <summary>
        /// Account Analysis.
        /// </summary>
        AccountAnalysis = 822,

        /// <summary>
        /// Lockbox.
        /// </summary>
        Lockbox = 823,

        /// <summary>
        /// Application Advice.
        /// </summary>
        ApplicationAdvice = 824,

        /// <summary>
        /// Tax Information Exchange.
        /// </summary>
        TaxInformationExchange = 826,

        /// <summary>
        /// Financial Return Notice.
        /// </summary>
        FinancialReturnNotice = 827,

        /// <summary>
        /// Debit Authorization.
        /// </summary>
        DebitAuthorization = 828,

        /// <summary>
        /// Payment Cancellation Request.
        /// </summary>
        PaymentCancellationRequest = 829,

        /// <summary>
        /// Planning Schedule with Release Capability.
        /// </summary>
        PlanningScheduleWithReleaseCapability = 830,

        /// <summary>
        /// Application Control Totals.
        /// </summary>
        ApplicationControlTotals = 831,

        /// <summary>
        /// Price/Sales Catalog.
        /// </summary>
        PriceSalesCatalog = 832,

        /// <summary>
        /// Mortgage Credit Report Order.
        /// </summary>
        MortgageCreditReportOrder = 833,

        /// <summary>
        /// Benefit Enrollment and Maintenance.
        /// </summary>
        BenefitEnrollmentAndMaintenance = 834,

        /// <summary>
        /// Health Care Claim Payment/Advice.
        /// </summary>
        HealthCareClaimPaymentAdvice = 835,

        /// <summary>
        /// Procurement Notices.
        /// </summary>
        ProcurementNotices = 836,

        /// <summary>
        /// Health Care Claim.
        /// </summary>
        HealthCareClaim = 837,

        /// <summary>
        /// Trading Partner Profile.
        /// </summary>
        TradingPartnerProfile = 838,

        /// <summary>
        /// Project Cost Reporting.
        /// </summary>
        ProjectCostReporting = 839,

        /// <summary>
        /// Request for Quotation.
        /// </summary>
        RequestForQuotation = 840,

        /// <summary>
        /// Specifications/Technical Information.
        /// </summary>
        SpecificationsTechnicalInformation = 841,

        /// <summary>
        /// Nonconformance Report.
        /// </summary>
        NonconformanceReport = 842,

        /// <summary>
        /// Response to Request for Quotation.
        /// </summary>
        ResponseToRequestForQuotation = 843,

        /// <summary>
        /// Product Transfer Account Adjustment.
        /// </summary>
        ProductTransferAccountAdjustment = 844,

        /// <summary>
        /// Price Authorization Acknowledgment/Status.
        /// </summary>
        PriceAuthorizationAcknowledgmentStatus = 845,

        /// <summary>
        /// Inventory Inquiry/Advice.
        /// </summary>
        InventoryInquiryAdvice = 846,

        /// <summary>
        /// Material Claim.
        /// </summary>
        MaterialClaim = 847,

        /// <summary>
        /// Material Safety Data Sheet.
        /// </summary>
        MaterialSafetyDataSheet = 848,

        /// <summary>
        /// Response to Product Transfer Account Adjustment.
        /// </summary>
        ResponseToProductTransferAccountAdjustment = 849,

        /// <summary>
        /// Purchase Order.
        /// </summary>
        PurchaseOrder = 850,

        /// <summary>
        /// Asset Schedule.
        /// </summary>
        AssetSchedule = 851,

        /// <summary>
        /// Product Activity Data.
        /// </summary>
        ProductActivityData = 852,

        /// <summary>
        /// Routing and Carrier Instruction.
        /// </summary>
        RoutingAndCarrierInstruction = 853,

        /// <summary>
        /// Shipment Delivery Discrepancy Information.
        /// </summary>
        ShipmentDeliveryDiscrepancyInformation = 854,

        /// <summary>
        /// Purchase Order Acknowledgment.
        /// </summary>
        PurchaseOrderAcknowledgment = 855,

        /// <summary>
        /// Ship Notice/Manifest.
        /// </summary>
        ShipNoticeManifest = 856,

        /// <summary>
        /// Shipment and Billing Notice.
        /// </summary>
        ShipmentAndBillingNotice = 857,

        /// <summary>
        /// Shipment Information.
        /// </summary>
        ShipmentInformation = 858,

        /// <summary>
        /// Freight Invoice.
        /// </summary>
        FreightInvoice = 859,

        /// <summary>
        /// Purchase Order Change Request - Buyer Initiated.
        /// </summary>
        PurchaseOrderChangeRequestBuyerInitiated = 860,

        /// <summary>
        /// Receiving Advice/Acceptance Certificate.
        /// </summary>
        ReceivingAdviceAcceptanceCertificate = 861,

        /// <summary>
        /// Shipping Schedule.
        /// </summary>
        ShippingSchedule = 862,

        /// <summary>
        /// Report of Test Results.
        /// </summary>
        ReportOfTestResults = 863,

        /// <summary>
        /// Text Message.
        /// </summary>
        TextMessage = 864,

        /// <summary>
        /// Purchase Order Change Acknowledgment/Request - Seller Initiated.
        /// </summary>
        PurchaseOrderChangeAcknowledgmentRequestSellerInitiated = 865,

        /// <summary>
        /// Production Sequence.
        /// </summary>
        ProductionSequence = 866,

        /// <summary>
        /// Product Transfer and Resale Report.
        /// </summary>
        ProductTransferAndResaleReport = 867,

        /// <summary>
        /// Electronic Form Structure.
        /// </summary>
        ElectronicFormStructure = 868,

        /// <summary>
        /// Order Status Inquiry.
        /// </summary>
        OrderStatusInquiry = 869,

        /// <summary>
        /// Order Status Report.
        /// </summary>
        OrderStatusReport = 870,

        /// <summary>
        /// Component Parts Content.
        /// </summary>
        ComponentPartsContent = 871,

        /// <summary>
        /// Residential Mortgage Insurance Application.
        /// </summary>
        ResidentialMortgageInsuranceApplication = 872,

        /// <summary>
        /// Commodity Movement Services.
        /// </summary>
        CommodityMovementServices = 873,

        /// <summary>
        /// Commodity Movement Services Response.
        /// </summary>
        CommodityMovementServicesResponse = 874,

        /// <summary>
        /// Grocery Products Purchase Order.
        /// </summary>
        GroceryProductsPurchaseOrder = 875,

        /// <summary>
        /// Grocery Products Purchase Order Change.
        /// </summary>
        GroceryProductsPurchaseOrderChange = 876,

        /// <summary>
        /// Manufacturer Coupon Family Code Structure.
        /// </summary>
        ManufacturerCouponFamilyCodeStructure = 877,

        /// <summary>
        /// Product Authorization/De-authorization.
        /// </summary>
        ProductAuthorizationDeauthorization = 878,

        /// <summary>
        /// Price Information.
        /// </summary>
        PriceInformation = 879,

        /// <summary>
        /// Grocery Products Invoice.
        /// </summary>
        GroceryProductsInvoice = 880,

        /// <summary>
        /// Manufacturer Coupon Redemption Detail.
        /// </summary>
        ManufacturerCouponRedemptionDetail = 881,

        /// <summary>
        /// Direct Store Delivery Summary Information.
        /// </summary>
        DirectStoreDeliverySummaryInformation = 882,

        /// <summary>
        /// Market Development Fund Allocation.
        /// </summary>
        MarketDevelopmentFundAllocation = 883,

        /// <summary>
        /// Market Development Fund Settlement.
        /// </summary>
        MarketDevelopmentFundSettlement = 884,

        /// <summary>
        /// Retail Account Characteristics.
        /// </summary>
        RetailAccountCharacteristics = 885,

        /// <summary>
        /// Customer Call Reporting.
        /// </summary>
        CustomerCallReporting = 886,

        /// <summary>
        /// Coupon Notification.
        /// </summary>
        CouponNotification = 887,

        /// <summary>
        /// Item Maintenance.
        /// </summary>
        ItemMaintenance = 888,

        /// <summary>
        /// Promotion Announcement.
        /// </summary>
        PromotionAnnouncement = 889,

        /// <summary>
        /// Contract and Rebate Management Transaction.
        /// </summary>
        ContractAndRebateManagementTransaction = 890,

        /// <summary>
        /// Deduction Research Report.
        /// </summary>
        DeductionResearchReport = 891,

        /// <summary>
        /// Trading Partner Performance Measurements.
        /// </summary>
        TradingPartnerPerformanceMeasurements = 892,

        /// <summary>
        /// Item Information Request.
        /// </summary>
        ItemInformationRequest = 893,

        /// <summary>
        /// Delivery/Return Base Record.
        /// </summary>
        DeliveryReturnBaseRecord = 894,

        /// <summary>
        /// Delivery/Return Acknowledgment or Adjustment.
        /// </summary>
        DeliveryReturnAcknowledgmentOrAdjustment = 895,

        /// <summary>
        /// Product Dimension Maintenance.
        /// </summary>
        ProductDimensionMaintenance = 896,

        /// <summary>
        /// Data Synchronization.
        /// </summary>
        DataSynchronization = 897,

        /// <summary>
        /// Loss or Damage Claim - General Commodities.
        /// </summary>
        LossOrDamageClaimGeneralCommodities = 920,

        /// <summary>
        /// Loss or Damage Claim - Motor Vehicle.
        /// </summary>
        LossOrDamageClaimMotorVehicle = 924,

        /// <summary>
        /// Claim Tracer.
        /// </summary>
        ClaimTracer = 925,

        /// <summary>
        /// Claim Status Report and Tracer Reply.
        /// </summary>
        ClaimStatusReportAndTracerReply = 926,

        /// <summary>
        /// Automotive Inspection Detail.
        /// </summary>
        AutomotiveInspectionDetail = 928,

        /// <summary>
        /// Warehouse Shipping Order.
        /// </summary>
        WarehouseShippingOrder = 940,

        /// <summary>
        /// Warehouse Stock Transfer Shipment Advice.
        /// </summary>
        WarehouseStockTransferShipmentAdvice = 943,

        /// <summary>
        /// Warehouse Stock Transfer Receipt Advice.
        /// </summary>
        WarehouseStockTransferReceiptAdvice = 944,

        /// <summary>
        /// Warehouse Shipping Advice.
        /// </summary>
        WarehouseShippingAdvice = 945,

        /// <summary>
        /// Warehouse Inventory Adjustment Advice.
        /// </summary>
        WarehouseInventoryAdjustmentAdvice = 947,

        /// <summary>
        /// Functional Group Totals.
        /// </summary>
        FunctionalGroupTotals = 980,

        /// <summary>
        /// Response to a Load Tender.
        /// </summary>
        ResponseToALoadTender = 990,

        /// <summary>
        /// Secured Receipt or Acknowledgment.
        /// </summary>
        SecuredReceiptOrAcknowledgment = 993,

        /// <summary>
        /// File Transfer.
        /// </summary>
        FileTransfer = 996,

        /// <summary>
        /// Functional Acknowledgment.
        /// </summary>
        FunctionalAcknowledgment = 997,

        /// <summary>
        /// Set Cancellation.
        /// </summary>
        SetCancellation = 998,

        /// <summary>
        /// Implementation Acknowledgment.
        /// </summary>
        ImplementationAcknowledgment = 999,
    }
}
