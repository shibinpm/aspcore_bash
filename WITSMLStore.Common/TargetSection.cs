using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "targetSection", Namespace = "http://www.witsml.org/schemas/1series")]
    public class TargetSection
    {
        [XmlElement(ElementName = "sectNumber", Namespace = "http://www.witsml.org/schemas/1series")]
        public string SectNumber { get; set; }
        [XmlElement(ElementName = "typeTargetSectionScope", Namespace = "http://www.witsml.org/schemas/1series")]
        public string TypeTargetSectionScope { get; set; }
        [XmlElement(ElementName = "lenRadius", Namespace = "http://www.witsml.org/schemas/1series")]
        public LenRadius LenRadius { get; set; }
        [XmlElement(ElementName = "angleArc", Namespace = "http://www.witsml.org/schemas/1series")]
        public AngleArc AngleArc { get; set; }
        [XmlElement(ElementName = "thickAbove", Namespace = "http://www.witsml.org/schemas/1series")]
        public ThickAbove ThickAbove { get; set; }
        [XmlElement(ElementName = "thickBelow", Namespace = "http://www.witsml.org/schemas/1series")]
        public ThickBelow ThickBelow { get; set; }
        [XmlElement(ElementName = "location", Namespace = "http://www.witsml.org/schemas/1series")]
        public Location Location { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
