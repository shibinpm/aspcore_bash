using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "nozzle", Namespace = "http://www.witsml.org/schemas/131")]
    public class Nozzle
    {
        [XmlElement(ElementName = "index", Namespace = "http://www.witsml.org/schemas/131")]
        public string Index { get; set; }
        [XmlElement(ElementName = "diaNozzle", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaNozzle DiaNozzle { get; set; }
        [XmlElement(ElementName = "typeNozzle", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeNozzle { get; set; }
        [XmlElement(ElementName = "len", Namespace = "http://www.witsml.org/schemas/131")]
        public Len Len { get; set; }
        [XmlElement(ElementName = "orientation", Namespace = "http://www.witsml.org/schemas/131")]
        public string Orientation { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
