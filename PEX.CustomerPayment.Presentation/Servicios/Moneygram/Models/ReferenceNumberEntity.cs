using System.Xml.Serialization;

namespace PEX.CustomerPayment.Presentation.Servicios.Moneygram.Models
{
    [XmlRoot(ElementName = "redirectInfo")]
    public class RedirectInfo
    {
        [XmlElement(ElementName = "originalSendAmount")]
        public string OriginalSendAmount { get; set; }
        [XmlElement(ElementName = "originalSendCurrency")]
        public string OriginalSendCurrency { get; set; }
        [XmlElement(ElementName = "originalSendFee")]
        public string OriginalSendFee { get; set; }
        [XmlElement(ElementName = "originalExchangeRate")]
        public string OriginalExchangeRate { get; set; }
        [XmlElement(ElementName = "originalReceiveAmount")]
        public string OriginalReceiveAmount { get; set; }
        [XmlElement(ElementName = "originalReceiveCurrency")]
        public string OriginalReceiveCurrency { get; set; }
        [XmlElement(ElementName = "originalReceiveCountry")]
        public string OriginalReceiveCountry { get; set; }
        [XmlElement(ElementName = "newSendFee")]
        public string NewSendFee { get; set; }
        [XmlElement(ElementName = "newExchangeRate")]
        public string NewExchangeRate { get; set; }
        [XmlElement(ElementName = "newReceiveAmount")]
        public string NewReceiveAmount { get; set; }
        [XmlElement(ElementName = "newReceiveCurrency")]
        public string NewReceiveCurrency { get; set; }
        [XmlElement(ElementName = "feeDifference")]
        public string FeeDifference { get; set; }
        [XmlElement(ElementName = "redirectType")]
        public string RedirectType { get; set; }
    }

    [XmlRoot(ElementName = "referenceNumber")]
    public class ReferenceNumberEntity
    {
        [XmlElement(ElementName = "doCheckIn")]
        public string DoCheckIn { get; set; }
        [XmlElement(ElementName = "timeStamp")]
        public string TimeStamp { get; set; }
        [XmlElement(ElementName = "flags")]
        public string Flags { get; set; }
        [XmlElement(ElementName = "mgiTransactionSessionID")]
        public string MgiTransactionSessionID { get; set; }
        [XmlElement(ElementName = "senderFirstName")]
        public string SenderFirstName { get; set; }
        [XmlElement(ElementName = "senderMiddleName")]
        public string SenderMiddleName { get; set; }
        [XmlElement(ElementName = "senderLastName")]
        public string SenderLastName { get; set; }
        [XmlElement(ElementName = "senderLastName2")]
        public string SenderLastName2 { get; set; }
        [XmlElement(ElementName = "senderHomePhone")]
        public string SenderHomePhone { get; set; }
        [XmlElement(ElementName = "receiverFirstName")]
        public string ReceiverFirstName { get; set; }
        [XmlElement(ElementName = "receiverMiddleName")]
        public string ReceiverMiddleName { get; set; }
        [XmlElement(ElementName = "receiverLastName")]
        public string ReceiverLastName { get; set; }
        [XmlElement(ElementName = "receiverLastName2")]
        public string ReceiverLastName2 { get; set; }
        [XmlElement(ElementName = "agentCheckNumber")]
        public string AgentCheckNumber { get; set; }
        [XmlElement(ElementName = "agentCheckAmount")]
        public string AgentCheckAmount { get; set; }
        [XmlElement(ElementName = "agentCheckAuthorizationNumber")]
        public string AgentCheckAuthorizationNumber { get; set; }
        [XmlElement(ElementName = "customerCheckNumber")]
        public string CustomerCheckNumber { get; set; }
        [XmlElement(ElementName = "customerCheckAmount")]
        public string CustomerCheckAmount { get; set; }
        [XmlElement(ElementName = "okForAgent")]
        public string OkForAgent { get; set; }
        [XmlElement(ElementName = "deliveryOption")]
        public string DeliveryOption { get; set; }
        [XmlElement(ElementName = "transactionStatus")]
        public string TransactionStatus { get; set; }
        [XmlElement(ElementName = "dateTimeSent")]
        public string DateTimeSent { get; set; }
        [XmlElement(ElementName = "receiveCurrency")]
        public string ReceiveCurrency { get; set; }
        [XmlElement(ElementName = "receiveAmount")]
        public string ReceiveAmount { get; set; }
        [XmlElement(ElementName = "referenceNumber")]
        public string ReferenceNumber { get; set; }
        [XmlElement(ElementName = "originatingCountry")]
        public string OriginatingCountry { get; set; }
        [XmlElement(ElementName = "validIndicator")]
        public string ValidIndicator { get; set; }
        [XmlElement(ElementName = "indicativeReceiveAmount")]
        public string IndicativeReceiveAmount { get; set; }
        [XmlElement(ElementName = "indicativeExchangeRate")]
        public string IndicativeExchangeRate { get; set; }
        [XmlElement(ElementName = "expectedDateOfDelivery")]
        public string ExpectedDateOfDelivery { get; set; }
        [XmlElement(ElementName = "originalSendAmount")]
        public string OriginalSendAmount { get; set; }
        [XmlElement(ElementName = "originalSendCurrency")]
        public string OriginalSendCurrency { get; set; }
        [XmlElement(ElementName = "originalSendFee")]
        public string OriginalSendFee { get; set; }
        [XmlElement(ElementName = "originalExchangeRate")]
        public string OriginalExchangeRate { get; set; }
        [XmlElement(ElementName = "redirectIndicator")]
        public string RedirectIndicator { get; set; }
        [XmlElement(ElementName = "redirectInfo")]
        public RedirectInfo RedirectInfo { get; set; }
        [XmlElement(ElementName = "okForPickup")]
        public string OkForPickup { get; set; }
        [XmlElement(ElementName = "notOkForPickupReasonCode")]
        public string NotOkForPickupReasonCode { get; set; }
        [XmlElement(ElementName = "minutesUntilOkForPickup")]
        public string MinutesUntilOkForPickup { get; set; }
    }
}