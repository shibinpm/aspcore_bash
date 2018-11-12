using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "rawData", Namespace = "http://www.witsml.org/schemas/1series")]
    public class RawData
    {
        [XmlElement(ElementName = "gravAxialRaw", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravAxialRaw GravAxialRaw { get; set; }
        [XmlElement(ElementName = "gravTran1Raw", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravTran1Raw GravTran1Raw { get; set; }
        [XmlElement(ElementName = "gravTran2Raw", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravTran2Raw GravTran2Raw { get; set; }
        [XmlElement(ElementName = "magAxialRaw", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagAxialRaw MagAxialRaw { get; set; }
        [XmlElement(ElementName = "magTran1Raw", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTran1Raw MagTran1Raw { get; set; }
        [XmlElement(ElementName = "magTran2Raw", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTran2Raw MagTran2Raw { get; set; }
    }
}
