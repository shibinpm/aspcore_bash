using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "connection", Namespace = "http://www.witsml.org/schemas/131")]
    public class Connection
    {
        [XmlElement(ElementName = "id", Namespace = "http://www.witsml.org/schemas/131")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "od", Namespace = "http://www.witsml.org/schemas/131")]
        public Od Od { get; set; }
        [XmlElement(ElementName = "len", Namespace = "http://www.witsml.org/schemas/131")]
        public Len Len { get; set; }
        [XmlElement(ElementName = "typeThread", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeThread { get; set; }
        [XmlElement(ElementName = "sizeThread", Namespace = "http://www.witsml.org/schemas/131")]
        public SizeThread SizeThread { get; set; }
        [XmlElement(ElementName = "tensYield", Namespace = "http://www.witsml.org/schemas/131")]
        public TensYield TensYield { get; set; }
        [XmlElement(ElementName = "tqYield", Namespace = "http://www.witsml.org/schemas/131")]
        public TqYield TqYield { get; set; }
        [XmlElement(ElementName = "position", Namespace = "http://www.witsml.org/schemas/131")]
        public string Position { get; set; }
        [XmlElement(ElementName = "criticalCrossSection", Namespace = "http://www.witsml.org/schemas/131")]
        public CriticalCrossSection CriticalCrossSection { get; set; }
        [XmlElement(ElementName = "presLeak", Namespace = "http://www.witsml.org/schemas/131")]
        public PresLeak PresLeak { get; set; }
        [XmlElement(ElementName = "tqMakeup", Namespace = "http://www.witsml.org/schemas/131")]
        public TqMakeup TqMakeup { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
