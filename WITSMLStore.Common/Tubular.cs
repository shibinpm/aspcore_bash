using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "tubular", Namespace = "http://www.witsml.org/schemas/131")]
    public class Tubular
    {
        [XmlElement(ElementName = "nameWell", Namespace = "http://www.witsml.org/schemas/131")]
        public string NameWell { get; set; }
        [XmlElement(ElementName = "nameWellbore", Namespace = "http://www.witsml.org/schemas/131")]
        public string NameWellbore { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/131")]
        public string Name { get; set; }
        [XmlElement(ElementName = "typeTubularAssy", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeTubularAssy { get; set; }
        [XmlElement(ElementName = "valveFloat", Namespace = "http://www.witsml.org/schemas/131")]
        public string ValveFloat { get; set; }
        [XmlElement(ElementName = "sourceNuclear", Namespace = "http://www.witsml.org/schemas/131")]
        public string SourceNuclear { get; set; }
        [XmlElement(ElementName = "diaHoleAssy", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaHoleAssy DiaHoleAssy { get; set; }
        [XmlElement(ElementName = "tubularComponent", Namespace = "http://www.witsml.org/schemas/131")]
        public TubularComponent TubularComponent { get; set; }
        [XmlElement(ElementName = "commonData", Namespace = "http://www.witsml.org/schemas/131")]
        public CommonData CommonData { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uidWell")]
        public string UidWell { get; set; }
        [XmlAttribute(AttributeName = "uidWellbore")]
        public string UidWellbore { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
