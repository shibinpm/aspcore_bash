using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "mudGas", Namespace = "http://www.witsml.org/schemas/1series")]
    public class MudGas
    {
        [XmlElement(ElementName = "gasAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public GasAv GasAv { get; set; }
        [XmlElement(ElementName = "gasPeak", Namespace = "http://www.witsml.org/schemas/1series")]
        public GasPeak GasPeak { get; set; }
        [XmlElement(ElementName = "gasPeakType", Namespace = "http://www.witsml.org/schemas/1series")]
        public string GasPeakType { get; set; }
        [XmlElement(ElementName = "gasBackgnd", Namespace = "http://www.witsml.org/schemas/1series")]
        public GasBackgnd GasBackgnd { get; set; }
        [XmlElement(ElementName = "gasConAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public GasConAv GasConAv { get; set; }
        [XmlElement(ElementName = "gasConMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public GasConMx GasConMx { get; set; }
        [XmlElement(ElementName = "gasTrip", Namespace = "http://www.witsml.org/schemas/1series")]
        public GasTrip GasTrip { get; set; }
    }
}
