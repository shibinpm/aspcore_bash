using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "bitRecord", Namespace = "http://www.witsml.org/schemas/131")]
    public class BitRecord
    {
        [XmlElement(ElementName = "numBit", Namespace = "http://www.witsml.org/schemas/131")]
        public string NumBit { get; set; }
        [XmlElement(ElementName = "diaBit", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaBit DiaBit { get; set; }
        [XmlElement(ElementName = "diaPassThru", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaPassThru DiaPassThru { get; set; }
        [XmlElement(ElementName = "diaPilot", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaPilot DiaPilot { get; set; }
        [XmlElement(ElementName = "manufacturer", Namespace = "http://www.witsml.org/schemas/131")]
        public string Manufacturer { get; set; }
        [XmlElement(ElementName = "typeBit", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeBit { get; set; }
        [XmlElement(ElementName = "cost", Namespace = "http://www.witsml.org/schemas/131")]
        public Cost Cost { get; set; }
        [XmlElement(ElementName = "codeIADC", Namespace = "http://www.witsml.org/schemas/131")]
        public string CodeIADC { get; set; }
        [XmlElement(ElementName = "condInitInner", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitInner { get; set; }
        [XmlElement(ElementName = "condInitOuter", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitOuter { get; set; }
        [XmlElement(ElementName = "condInitDull", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitDull { get; set; }
        [XmlElement(ElementName = "condInitLocation", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitLocation { get; set; }
        [XmlElement(ElementName = "condInitBearing", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitBearing { get; set; }
        [XmlElement(ElementName = "condInitGauge", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitGauge { get; set; }
        [XmlElement(ElementName = "condInitOther", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitOther { get; set; }
        [XmlElement(ElementName = "condInitReason", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondInitReason { get; set; }
        [XmlElement(ElementName = "condFinalInner", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalInner { get; set; }
        [XmlElement(ElementName = "condFinalOuter", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalOuter { get; set; }
        [XmlElement(ElementName = "condFinalDull", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalDull { get; set; }
        [XmlElement(ElementName = "condFinalLocation", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalLocation { get; set; }
        [XmlElement(ElementName = "condFinalBearing", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalBearing { get; set; }
        [XmlElement(ElementName = "condFinalGauge", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalGauge { get; set; }
        [XmlElement(ElementName = "condFinalOther", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalOther { get; set; }
        [XmlElement(ElementName = "condFinalReason", Namespace = "http://www.witsml.org/schemas/131")]
        public string CondFinalReason { get; set; }
        [XmlElement(ElementName = "drive", Namespace = "http://www.witsml.org/schemas/131")]
        public string Drive { get; set; }
        [XmlElement(ElementName = "bitClass", Namespace = "http://www.witsml.org/schemas/131")]
        public string BitClass { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
    }
}
