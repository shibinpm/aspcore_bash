using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "holeOpener", Namespace = "http://www.witsml.org/schemas/131")]
    public class HoleOpener
    {
        [XmlElement(ElementName = "typeHoleOpener", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeHoleOpener { get; set; }
        [XmlElement(ElementName = "numCutter", Namespace = "http://www.witsml.org/schemas/131")]
        public string NumCutter { get; set; }
        [XmlElement(ElementName = "manufacturer", Namespace = "http://www.witsml.org/schemas/131")]
        public string Manufacturer { get; set; }
        [XmlElement(ElementName = "diaHoleOpener", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaHoleOpener DiaHoleOpener { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
    }
}
