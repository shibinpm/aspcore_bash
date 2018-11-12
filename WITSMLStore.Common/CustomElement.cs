using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "customElement", Namespace = "http://www.witsml.org/schemas/1series")]
    public class CustomElement
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "creationTime", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CreationTime { get; set; }
        [XmlElement(ElementName = "type", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Type { get; set; }
        [XmlElement(ElementName = "tag", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Tag { get; set; }
        [XmlElement(ElementName = "content", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Content { get; set; }
        [XmlElement(ElementName = "contentSize", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ContentSize { get; set; }
        [XmlElement(ElementName = "sequence", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Sequence { get; set; }
        [XmlElement(ElementName = "lastChanged", Namespace = "http://www.witsml.org/schemas/1series")]
        public string LastChanged { get; set; }
        [XmlElement(ElementName = "range", Namespace = "http://www.witsml.org/schemas/1series")]
        public Range Range { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
