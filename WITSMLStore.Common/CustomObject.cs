using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "customObject", Namespace = "http://www.witsml.org/schemas/1series")]
    public class CustomObject
    {
        [XmlElement(ElementName = "nameWell", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWell { get; set; }
        [XmlElement(ElementName = "nameWellbore", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWellbore { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "creationTime", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CreationTime { get; set; }
        [XmlElement(ElementName = "type", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Type { get; set; }
        [XmlElement(ElementName = "subtype", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Subtype { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Description { get; set; }
        [XmlElement(ElementName = "tag", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Tag { get; set; }
        [XmlElement(ElementName = "content", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Content { get; set; }
        [XmlElement(ElementName = "contentSize", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ContentSize { get; set; }
        [XmlElement(ElementName = "totalRange", Namespace = "http://www.witsml.org/schemas/1series")]
        public TotalRange TotalRange { get; set; }
        [XmlElement(ElementName = "customElement", Namespace = "http://www.witsml.org/schemas/1series")]
        public CustomElement CustomElement { get; set; }
        [XmlElement(ElementName = "commonData", Namespace = "http://www.witsml.org/schemas/1series")]
        public CommonData CommonData { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uidWell")]
        public string UidWell { get; set; }
        [XmlAttribute(AttributeName = "uidWellbore")]
        public string UidWellbore { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
